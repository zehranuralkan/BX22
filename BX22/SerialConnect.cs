using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BX22
{
    public partial class Serial : Form
    {
        public Serial()
        {
            InitializeComponent();
        }

        public static SerialPort serialPort = new SerialPort();//serial port tanitimi
        public static string[] ports = SerialPort.GetPortNames();

        public void OpenConnection(string portName, int boudrate) {
            if (serialPort.IsOpen)
                serialPort.Close();
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = portName;
                    serialPort.BaudRate = boudrate;
                    serialPort.Open();
                    serialPort.Handshake = Handshake.None; //baglanti noktasi iletisiimde denetim
                    data_listbox.Items.Add("Serial port" + " " + cbx_name.Text +" "+ "is open");
                    data_listbox.Items.Add(deger);
                }
                catch
                {
                    MessageBox.Show("Connection Error");
                    data_listbox.Items.Add("Serial port" + " " + cbx_name.Text + " opening error");
                }
            }

        }

      
        public string deger = "";
        

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                deger = serialPort.ReadLine();
                //this.Invoke(new EventHandler(displayData_event));
                Control.CheckForIllegalCrossThreadCalls = false;
                data_listbox.Items.Add(deger);
                ParseIslemi(deger);
                
            }
            catch (System.IO.IOException)
            {
                //MessageBox.Show("Geçersiz i/o");
               
            }
            catch (InvalidOperationException)
            {
                deger = "";
            }
          
            catch (FormatException)
            {
                MessageBox.Show("Geçersiz format");
            }
         
            
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Geçersiz dizin");

            }

        }

        public void ComPortList()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbx_name.Items.Add(port);
            }
           
        }

        public void ParseIslemi(string yenideger)
        {
               
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived); //verileri alır

            ComPortList();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (cbx_name.Text != " " && cbx_boud.Text != " ")
            {
                OpenConnection(cbx_name.Text, Convert.ToInt32(cbx_boud.Text)); //kulanilacak port
                //serialPort.PortName = cbx_name.SelectedItem.ToString();
                backgroundWorker1.RunWorkerAsync();


            }

            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz");
            }
            btn_open.Visible = false;
            

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            btn_open.Visible = true;
            btn_close.Visible = false;
        }

      
    }
 
}