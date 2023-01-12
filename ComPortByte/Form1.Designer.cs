namespace ComPortByte
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cBoxParityBits = new System.Windows.Forms.ComboBox();
			this.cBoxStopBits = new System.Windows.Forms.ComboBox();
			this.cBoxDataBits = new System.Windows.Forms.ComboBox();
			this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
			this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.lblStatusCom = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnSendData = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.FCT_ENTER_MODE = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.tBoxDataIN = new System.Windows.Forms.TextBox();
			this.fctTimer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cBoxParityBits);
			this.groupBox1.Controls.Add(this.cBoxStopBits);
			this.groupBox1.Controls.Add(this.cBoxDataBits);
			this.groupBox1.Controls.Add(this.CBoxBaudRate);
			this.groupBox1.Controls.Add(this.cBoxCOMPORT);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 192);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Com Port Control";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "PARITY BITS";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "STOP BITS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "DATA BITS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "BAUD RATE";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "COM PORT";
			// 
			// cBoxParityBits
			// 
			this.cBoxParityBits.FormattingEnabled = true;
			this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
			this.cBoxParityBits.Location = new System.Drawing.Point(101, 127);
			this.cBoxParityBits.Name = "cBoxParityBits";
			this.cBoxParityBits.Size = new System.Drawing.Size(121, 21);
			this.cBoxParityBits.TabIndex = 4;
			this.cBoxParityBits.Text = "None";
			// 
			// cBoxStopBits
			// 
			this.cBoxStopBits.FormattingEnabled = true;
			this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
			this.cBoxStopBits.Location = new System.Drawing.Point(101, 100);
			this.cBoxStopBits.Name = "cBoxStopBits";
			this.cBoxStopBits.Size = new System.Drawing.Size(121, 21);
			this.cBoxStopBits.TabIndex = 3;
			this.cBoxStopBits.Text = "One";
			// 
			// cBoxDataBits
			// 
			this.cBoxDataBits.FormattingEnabled = true;
			this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
			this.cBoxDataBits.Location = new System.Drawing.Point(101, 73);
			this.cBoxDataBits.Name = "cBoxDataBits";
			this.cBoxDataBits.Size = new System.Drawing.Size(121, 21);
			this.cBoxDataBits.TabIndex = 2;
			this.cBoxDataBits.Text = "8";
			// 
			// CBoxBaudRate
			// 
			this.CBoxBaudRate.FormattingEnabled = true;
			this.CBoxBaudRate.Items.AddRange(new object[] {
            "150",
            "152",
            "2400",
            "2400",
            "4800",
            "9600",
            "19200",
            "115200",
            "460800"});
			this.CBoxBaudRate.Location = new System.Drawing.Point(101, 46);
			this.CBoxBaudRate.Name = "CBoxBaudRate";
			this.CBoxBaudRate.Size = new System.Drawing.Size(121, 21);
			this.CBoxBaudRate.TabIndex = 1;
			this.CBoxBaudRate.Text = "9600";
			// 
			// cBoxCOMPORT
			// 
			this.cBoxCOMPORT.FormattingEnabled = true;
			this.cBoxCOMPORT.Location = new System.Drawing.Point(101, 19);
			this.cBoxCOMPORT.Name = "cBoxCOMPORT";
			this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
			this.cBoxCOMPORT.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox8);
			this.groupBox2.Controls.Add(this.progressBar1);
			this.groupBox2.Controls.Add(this.btnClose);
			this.groupBox2.Controls.Add(this.btnOpen);
			this.groupBox2.Location = new System.Drawing.Point(12, 204);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 152);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.lblStatusCom);
			this.groupBox8.Location = new System.Drawing.Point(101, 13);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(127, 98);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "COM PORT STATUS";
			// 
			// lblStatusCom
			// 
			this.lblStatusCom.AutoSize = true;
			this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusCom.Location = new System.Drawing.Point(37, 34);
			this.lblStatusCom.Name = "lblStatusCom";
			this.lblStatusCom.Size = new System.Drawing.Size(62, 29);
			this.lblStatusCom.TabIndex = 0;
			this.lblStatusCom.Text = "OFF";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(9, 117);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(218, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Crimson;
			this.btnClose.Location = new System.Drawing.Point(9, 66);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 45);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.LightGreen;
			this.btnOpen.Location = new System.Drawing.Point(9, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(88, 45);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "OPEN";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnSendData
			// 
			this.btnSendData.BackColor = System.Drawing.Color.Gold;
			this.btnSendData.Location = new System.Drawing.Point(42, 191);
			this.btnSendData.Name = "btnSendData";
			this.btnSendData.Size = new System.Drawing.Size(93, 33);
			this.btnSendData.TabIndex = 2;
			this.btnSendData.Text = "Send Data";
			this.btnSendData.UseVisualStyleBackColor = false;
			this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.FCT_ENTER_MODE);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.textBox11);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.btnSendData);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Location = new System.Drawing.Point(257, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(154, 343);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Transmitter Control";
			// 
			// FCT_ENTER_MODE
			// 
			this.FCT_ENTER_MODE.AutoSize = true;
			this.FCT_ENTER_MODE.Location = new System.Drawing.Point(8, 320);
			this.FCT_ENTER_MODE.Name = "FCT_ENTER_MODE";
			this.FCT_ENTER_MODE.Size = new System.Drawing.Size(127, 17);
			this.FCT_ENTER_MODE.TabIndex = 32;
			this.FCT_ENTER_MODE.Text = "FCT_ENTER_MODE";
			this.FCT_ENTER_MODE.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(67, 260);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(0, 13);
			this.label15.TabIndex = 31;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(5, 19);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(46, 13);
			this.label14.TabIndex = 30;
			this.label14.Text = "Uzunluk";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(55, 18);
			this.textBox11.Margin = new System.Windows.Forms.Padding(2);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(76, 20);
			this.textBox11.TabIndex = 29;
			this.textBox11.Text = "6";
			this.textBox11.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(4, 157);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "6.Byte";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 134);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "5.Byte";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 110);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "4.Byte";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 84);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "3.Byte";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 61);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "2.Byte";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 39);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "1.Byte";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(59, 153);
			this.textBox6.Margin = new System.Windows.Forms.Padding(2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(76, 20);
			this.textBox6.TabIndex = 10;
			this.textBox6.Text = "0xFA";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(59, 130);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(76, 20);
			this.textBox5.TabIndex = 10;
			this.textBox5.Text = "0x45";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(59, 108);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(76, 20);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "0x00";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(59, 85);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(76, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "0x01";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(59, 62);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(76, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "0x07";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 39);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(76, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "0x42";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.tBoxDataIN);
			this.groupBox9.Location = new System.Drawing.Point(417, 13);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(260, 343);
			this.groupBox9.TabIndex = 5;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Receiver Control";
			// 
			// tBoxDataIN
			// 
			this.tBoxDataIN.Location = new System.Drawing.Point(8, 18);
			this.tBoxDataIN.Multiline = true;
			this.tBoxDataIN.Name = "tBoxDataIN";
			this.tBoxDataIN.Size = new System.Drawing.Size(242, 319);
			this.tBoxDataIN.TabIndex = 6;
			this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
			// 
			// fctTimer
			// 
			this.fctTimer.Interval = 1000;
			this.fctTimer.Tick += new System.EventHandler(this.fctTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 366);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "C# COM PORT SERIAL";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Timer fctTimer;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox FCT_ENTER_MODE;
    }
}

