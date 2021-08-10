namespace BX22
{
    partial class Serial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_listbox = new System.Windows.Forms.ListBox();
            this.panel_serial = new System.Windows.Forms.Panel();
            this.lbl_tareparse = new System.Windows.Forms.Label();
            this.lbl_grossparse = new System.Windows.Forms.Label();
            this.lbl_fisnumarasiparse = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            this.lbl_tare = new System.Windows.Forms.Label();
            this.lbl_gross = new System.Windows.Forms.Label();
            this.lbl_fisnumarasi = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.cbx_boud = new System.Windows.Forms.ComboBox();
            this.lbl_baud = new System.Windows.Forms.Label();
            this.cbx_name = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_netparse = new System.Windows.Forms.Label();
            this.panel_serial.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_listbox
            // 
            this.data_listbox.FormattingEnabled = true;
            this.data_listbox.Location = new System.Drawing.Point(17, 28);
            this.data_listbox.Name = "data_listbox";
            this.data_listbox.Size = new System.Drawing.Size(527, 342);
            this.data_listbox.TabIndex = 0;
            // 
            // panel_serial
            // 
            this.panel_serial.BackColor = System.Drawing.SystemColors.Control;
            this.panel_serial.Controls.Add(this.lbl_netparse);
            this.panel_serial.Controls.Add(this.lbl_tareparse);
            this.panel_serial.Controls.Add(this.lbl_grossparse);
            this.panel_serial.Controls.Add(this.lbl_fisnumarasiparse);
            this.panel_serial.Controls.Add(this.lbl_net);
            this.panel_serial.Controls.Add(this.lbl_tare);
            this.panel_serial.Controls.Add(this.lbl_gross);
            this.panel_serial.Controls.Add(this.lbl_fisnumarasi);
            this.panel_serial.Controls.Add(this.btn_close);
            this.panel_serial.Controls.Add(this.btn_open);
            this.panel_serial.Controls.Add(this.cbx_boud);
            this.panel_serial.Controls.Add(this.lbl_baud);
            this.panel_serial.Controls.Add(this.cbx_name);
            this.panel_serial.Controls.Add(this.lbl_name);
            this.panel_serial.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_serial.Location = new System.Drawing.Point(573, 28);
            this.panel_serial.Name = "panel_serial";
            this.panel_serial.Size = new System.Drawing.Size(207, 341);
            this.panel_serial.TabIndex = 1;
            // 
            // lbl_tareparse
            // 
            this.lbl_tareparse.AutoSize = true;
            this.lbl_tareparse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tareparse.Location = new System.Drawing.Point(107, 289);
            this.lbl_tareparse.Name = "lbl_tareparse";
            this.lbl_tareparse.Size = new System.Drawing.Size(0, 13);
            this.lbl_tareparse.TabIndex = 12;
            // 
            // lbl_grossparse
            // 
            this.lbl_grossparse.AutoSize = true;
            this.lbl_grossparse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_grossparse.Location = new System.Drawing.Point(107, 263);
            this.lbl_grossparse.Name = "lbl_grossparse";
            this.lbl_grossparse.Size = new System.Drawing.Size(0, 13);
            this.lbl_grossparse.TabIndex = 11;
            // 
            // lbl_fisnumarasiparse
            // 
            this.lbl_fisnumarasiparse.AutoSize = true;
            this.lbl_fisnumarasiparse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fisnumarasiparse.Location = new System.Drawing.Point(123, 236);
            this.lbl_fisnumarasiparse.Name = "lbl_fisnumarasiparse";
            this.lbl_fisnumarasiparse.Size = new System.Drawing.Size(0, 13);
            this.lbl_fisnumarasiparse.TabIndex = 10;
            this.lbl_fisnumarasiparse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_net.Location = new System.Drawing.Point(25, 315);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(27, 13);
            this.lbl_net.TabIndex = 9;
            this.lbl_net.Text = "Net:";
            // 
            // lbl_tare
            // 
            this.lbl_tare.AutoSize = true;
            this.lbl_tare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tare.Location = new System.Drawing.Point(25, 289);
            this.lbl_tare.Name = "lbl_tare";
            this.lbl_tare.Size = new System.Drawing.Size(32, 13);
            this.lbl_tare.TabIndex = 8;
            this.lbl_tare.Text = "Tare:";
            // 
            // lbl_gross
            // 
            this.lbl_gross.AutoSize = true;
            this.lbl_gross.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_gross.Location = new System.Drawing.Point(25, 263);
            this.lbl_gross.Name = "lbl_gross";
            this.lbl_gross.Size = new System.Drawing.Size(37, 13);
            this.lbl_gross.TabIndex = 7;
            this.lbl_gross.Text = "Gross:";
            // 
            // lbl_fisnumarasi
            // 
            this.lbl_fisnumarasi.AutoSize = true;
            this.lbl_fisnumarasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fisnumarasi.Location = new System.Drawing.Point(25, 236);
            this.lbl_fisnumarasi.Name = "lbl_fisnumarasi";
            this.lbl_fisnumarasi.Size = new System.Drawing.Size(70, 13);
            this.lbl_fisnumarasi.TabIndex = 6;
            this.lbl_fisnumarasi.Text = "Fiş Numarası:";
            // 
            // btn_close
            // 
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.Location = new System.Drawing.Point(49, 182);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(110, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_open.Location = new System.Drawing.Point(48, 145);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(112, 21);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "OPEN";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cbx_boud
            // 
            this.cbx_boud.FormattingEnabled = true;
            this.cbx_boud.Items.AddRange(new object[] {
            "9600"});
            this.cbx_boud.Location = new System.Drawing.Point(46, 90);
            this.cbx_boud.Name = "cbx_boud";
            this.cbx_boud.Size = new System.Drawing.Size(115, 21);
            this.cbx_boud.TabIndex = 3;
            // 
            // lbl_baud
            // 
            this.lbl_baud.AutoSize = true;
            this.lbl_baud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_baud.Location = new System.Drawing.Point(45, 71);
            this.lbl_baud.Name = "lbl_baud";
            this.lbl_baud.Size = new System.Drawing.Size(32, 13);
            this.lbl_baud.TabIndex = 2;
            this.lbl_baud.Text = "Baud";
            // 
            // cbx_name
            // 
            this.cbx_name.FormattingEnabled = true;
            this.cbx_name.Location = new System.Drawing.Point(42, 30);
            this.cbx_name.Name = "cbx_name";
            this.cbx_name.Size = new System.Drawing.Size(120, 21);
            this.cbx_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(39, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_netparse
            // 
            this.lbl_netparse.AutoSize = true;
            this.lbl_netparse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_netparse.Location = new System.Drawing.Point(107, 315);
            this.lbl_netparse.Name = "lbl_netparse";
            this.lbl_netparse.Size = new System.Drawing.Size(0, 13);
            this.lbl_netparse.TabIndex = 13;
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_serial);
            this.Controls.Add(this.data_listbox);
            this.Name = "Serial";
            this.Text = "BX22";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_serial.ResumeLayout(false);
            this.panel_serial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox data_listbox;
        private System.Windows.Forms.Panel panel_serial;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox cbx_boud;
        private System.Windows.Forms.Label lbl_baud;
        private System.Windows.Forms.ComboBox cbx_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.Label lbl_tare;
        private System.Windows.Forms.Label lbl_gross;
        private System.Windows.Forms.Label lbl_fisnumarasi;
        private System.Windows.Forms.Label lbl_fisnumarasiparse;
        private System.Windows.Forms.Label lbl_grossparse;
        private System.Windows.Forms.Label lbl_tareparse;
        private System.Windows.Forms.Label lbl_netparse;
    }
}

