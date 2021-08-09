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
            this.lbl_name = new System.Windows.Forms.Label();
            this.cbx_name = new System.Windows.Forms.ComboBox();
            this.lbl_baud = new System.Windows.Forms.Label();
            this.cbx_boud = new System.Windows.Forms.ComboBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(43, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // cbx_name
            // 
            this.cbx_name.FormattingEnabled = true;
            this.cbx_name.Location = new System.Drawing.Point(46, 108);
            this.cbx_name.Name = "cbx_name";
            this.cbx_name.Size = new System.Drawing.Size(120, 21);
            this.cbx_name.TabIndex = 1;
            // 
            // lbl_baud
            // 
            this.lbl_baud.AutoSize = true;
            this.lbl_baud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_baud.Location = new System.Drawing.Point(49, 149);
            this.lbl_baud.Name = "lbl_baud";
            this.lbl_baud.Size = new System.Drawing.Size(32, 13);
            this.lbl_baud.TabIndex = 2;
            this.lbl_baud.Text = "Baud";
            // 
            // cbx_boud
            // 
            this.cbx_boud.FormattingEnabled = true;
            this.cbx_boud.Items.AddRange(new object[] {
            "9600"});
            this.cbx_boud.Location = new System.Drawing.Point(50, 168);
            this.cbx_boud.Name = "cbx_boud";
            this.cbx_boud.Size = new System.Drawing.Size(115, 21);
            this.cbx_boud.TabIndex = 3;
            // 
            // btn_open
            // 
            this.btn_open.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_open.Location = new System.Drawing.Point(52, 223);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(112, 21);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "OPEN";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_serial);
            this.Controls.Add(this.data_listbox);
            this.Name = "Serial";
            this.Text = "Form1";
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
    }
}

