using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
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
        public static string[] ports = SerialPort.GetPortNames();//seri baglanti noktasi adları dizisi
        public void OpenConnection(string portName, int boudrate) {
            if (serialPort.IsOpen)
                serialPort.Close();//serial port acik ise kapatir
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = portName;
                    serialPort.BaudRate = boudrate;
                    serialPort.Open();
                    serialPort.Handshake = Handshake.None; //baglanti noktasi iletisiminde denetim
                    data_listbox.Items.Add("Serial port" + " " + cbx_name.Text +" "+ "is open");
                }
                catch
                {
                    MessageBox.Show("Connection Error");
                    data_listbox.Items.Add("Serial port" + " " + cbx_name.Text + " opening error");
                }
            }
        }
        public string value = "";
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                value = serialPort.ReadLine();//serial okuma 
                Control.CheckForIllegalCrossThreadCalls = false;
                data_listbox.Items.Add(value); //okunan degerler listbox gosterilir
                ParseProcess(value);
            }

            catch (InvalidOperationException)
            {
                value = "";
            }

            catch (FormatException)
            {
                MessageBox.Show("Format exception");
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index Expection");

            }
            catch (SocketException)
            {
                MessageBox.Show("Socket Exception ");
            }
            catch (System.IO.IOException)
            { }

        }
        public void ComPortList()
        {
            //mevcut comportlari combobox'da listeleyen metod
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbx_name.Items.Add(port);
            }
        }
        public void ParseProcess(string newvalue)
        {
           
            newvalue = newvalue + "   ";
            lbl_receiptnumberparse.Text = newvalue.Substring(6, 4);
            lbl_grossparse.Text = newvalue.Substring(17, 9);
            lbl_tareparse.Text = newvalue.Substring(33, 9);
            lbl_netparse.Text = newvalue.Substring(47, 10+1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived); //verileri alır
            ComPortList();
            btn_close.Visible = false;
            btn_print.Visible = false;
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (cbx_name.Text != " " && cbx_boud.Text != " ")
            {
                OpenConnection(cbx_name.Text, Convert.ToInt32(cbx_boud.Text)); //kulanilacak port                                               
              
            }
            else
            {
                MessageBox.Show("Fill in the required fields");
            }
            btn_open.Visible = false;
            btn_close.Visible = true;
            btn_print.Visible = true;
        }
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            data_listbox.Items.Add("Serial port" + " " + cbx_name.Text + " is closed");
            btn_open.Visible = true;
            btn_close.Visible = false;
            lbl_receiptnumberparse.Text = " ";
            lbl_grossparse.Text = " ";
            lbl_tareparse.Text = " ";
            lbl_netparse.Text = " ";
            btn_print.Visible = false;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            serialPort.Write("P");
        }
    }
}