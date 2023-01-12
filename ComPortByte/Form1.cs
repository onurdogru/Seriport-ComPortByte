using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ComPortByte
{
    public partial class Form1 : Form
    {
        byte[] array = new byte[256];
        int counterByte = 0;
        int byteLenght = 0;
        bool errorFlag = false;
        byte[] byteArray1 = new byte[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports); //ilkcheckbox

            btnOpen.Enabled = true; //Portu aktif etme butonları
            btnClose.Enabled = true;
        }







        //#1 break pointlerle check edildi.

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
                
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                //serialPort1.DtrEnable = true;
                serialPort1.ReceivedBytesThreshold = 1;
                serialPort1.Open();

                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ON";
                fctTimer.Start();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }








        //??????? SerialPort daha detaylı incelenecek.
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // tBoxDataIN.Text = "GELDİ1";
            while (serialPort1.BytesToRead > 0)
            {
                array[counterByte] = Convert.ToByte(serialPort1.ReadByte());
                counterByte++;
               // Thread.Sleep(100);
            }
            this.Invoke(new EventHandler(ShowData));

            
        }









        private void ShowData(object sender, EventArgs e)
        {
           // tBoxDataIN.Text = "";
           //counterbyte global'de 0 olarak atanmıştır.

            for (int j = 0; j < counterByte; j++)
            {
                tBoxDataIN.Text += "0x" + string.Format("{0:X}", array[j]) + " ";
            }
            counterByte = 0;
            tBoxDataIN.Text += "                         ";
            justFeedback();

        }






        //Veri Karşılaştır
        private void justFeedback()
        {
            byte[] byteArray = new byte[6];

            string metin = "0x24 0x0 0x1 0x0 0x45 0xAF";

            

            byteArray[0] = 36;  //PREAMBLE_FTC_Client  0x24
            byteArray[1] = 0;  //CMD_EnterFTCMode      0x0
            byteArray[2] = 1;  //Data Lenght LSB       0x1
            byteArray[3] = 0;  //Data Lenght MSB       0x0
            byteArray[4] = 69;  //Data Empty           0x45
            byteArray[5] = 175;  //FTC_Client CRC      0xAF
                                  //serialPort1.Write(byteArray, 0, 6);  //5 te olabilir

           // bool sonuc = metin.Contains("0x24");


            //if (textBox1.Text == byteArray[0].ToString() && tBoxDataIN.Text == sonuc.ToString())
            // if (textBox1.Text == byteArray[0].ToString() && tBoxDataIN.Text == "0x24"+ "0x0" + "0x1" + "0x0" + "0x45" + "0xAF")
            // if (textBox1.Text == 0x42.ToString() && tBoxDataIN.Text == sonuc.ToString())
            //if(tBoxDataIN.Text == sonuc.ToString())
            if(array[0]== byteArray[0] && array[1] == byteArray[1] && array[2] == byteArray[2] && array[3] == byteArray[3] && array[4] == byteArray[4] && array[5] == byteArray[5])
            {
                MessageBox.Show("Doğru Veri Girildi");
			}
            else
			{
                MessageBox.Show("Giriş Yapılan Veri Yanlıştır, Lütfen tekrar deneyiniz");
			}

          
          
        }

















        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                fctTimer.Stop();
            }
        }





        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                if (Convert.ToInt32(textBox11.Text) > 0 && Convert.ToInt32(textBox11.Text) < 7)
                {
                    if (serialPort1.IsOpen)
                    {
                        byte[] byteArray = new byte[6];
                        if (textBox1.Enabled == true && textBox1.Text != "")
                        {
                            int hex = hextointConvert(textBox1.Text.Substring(2, 1)) * 16 + hextointConvert(textBox1.Text.Substring(3, 1));
                            byteArray[0] = Convert.ToByte(hex);
                            byteLenght = 1;
                            label6.BackColor = Color.White;
                        }
                        else if (textBox1.Enabled == true && textBox1.Text == "")
                        {
                            label6.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (textBox2.Enabled == true && textBox2.Text != "")
                        {
                            int hex = hextointConvert(textBox2.Text.Substring(2, 1)) * 16 + hextointConvert(textBox2.Text.Substring(3, 1));
                            byteArray[1] = Convert.ToByte(hex);
                            byteLenght = 2;
                            label7.BackColor = Color.White;
                        }
                        else if (textBox2.Enabled == true && textBox2.Text == "")
                        {
                            label7.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (textBox3.Enabled == true && textBox3.Text != "")
                        {
                            int hex = hextointConvert(textBox3.Text.Substring(2, 1)) * 16 + hextointConvert(textBox3.Text.Substring(3, 1));
                            byteArray[2] = Convert.ToByte(hex);
                            byteLenght = 3;
                            label8.BackColor = Color.White;
                        }
                        else if (textBox3.Enabled == true && textBox3.Text == "")
                        {
                            label8.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (textBox4.Enabled == true && textBox4.Text != "")
                        {
                            int hex = hextointConvert(textBox4.Text.Substring(2, 1)) * 16 + hextointConvert(textBox4.Text.Substring(3, 1));
                            byteArray[3] = Convert.ToByte(hex);
                            byteLenght = 4;
                            label9.BackColor = Color.White;
                        }
                        else if (textBox4.Enabled == true && textBox4.Text == "")
                        {
                            label9.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (textBox5.Enabled == true && textBox5.Text != "")
                        {
                            int hex = hextointConvert(textBox5.Text.Substring(2, 1)) * 16 + hextointConvert(textBox5.Text.Substring(3, 1));
                            byteArray[4] = Convert.ToByte(hex);
                            byteLenght = 5;
                            label10.BackColor = Color.White;
                        }
                        else if (textBox5.Enabled == true && textBox5.Text == "")
                        {
                            label10.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (textBox6.Enabled == true && textBox6.Text != "")
                        {
                            int hex = hextointConvert(textBox6.Text.Substring(2, 1)) * 16 + hextointConvert(textBox6.Text.Substring(3, 1));
                            byteArray[5] = Convert.ToByte(hex);
                            byteLenght = 6;
                            label11.BackColor = Color.White;
                        }
                        else if (textBox6.Enabled == true && textBox6.Text == "")
                        {
                            label11.BackColor = Color.Red;
                            errorFlag = true;
                        }

                        if (!errorFlag)
                        {
                            serialPort1.Write(byteArray, 0, byteLenght);
                            reset();
                            label15.ForeColor = Color.Green;
                            label15.Text = "Veri Gönderildi";
                        }
                        else
                        {
                            errorFlag = false;
                            label15.ForeColor = Color.Red;
                            label15.Text = "Veri Gönderilemedi";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Comport'u Açınız");
                    }
                }
                else
                {
                    MessageBox.Show("Uzunluk 1 ile 8 aralığında olmalıdır.");
                    textBox11.Text = "1";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Uzunluğu Boş Bırakmayınız");
            }
        }

        private int hextointConvert(string hex)
        {
            if (hex == "1")
            {
                return 1;
            }
            else if (hex == "2")
            {
                return 2;
            }
            else if (hex == "3")
            {
                return 3;
            }
            else if (hex == "4")
            {
                return 4;
            }
            else if (hex == "5")
            {
                return 5;
            }
            else if (hex == "6")
            {
                return 6;
            }
            else if (hex == "7")
            {
                return 7;
            }
            else if (hex == "8")
            {
                return 8;
            }
            else if (hex == "9")
            {
                return 9;
            }
            else if (hex == "A")
            {
                return 10;
            }
            else if (hex == "B")
            {
                return 11;
            }
            else if (hex == "C")
            {
                return 12;
            }
            else if (hex == "D")
            {
                return 13;
            }
            else if (hex == "E")
            {
                return 14;
            }
            else if (hex == "F")
            {
                return 15;
            }
            return 0;
        }

        void reset()
        {
            errorFlag = false;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            label9.BackColor = Color.White;
            label10.BackColor = Color.White;
            label11.BackColor = Color.White;
        }
        public void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                if (Convert.ToInt32(textBox11.Text) > 0 && Convert.ToInt32(textBox11.Text) < 7)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    if (Convert.ToInt32(textBox11.Text) > 0)
                    {
                        textBox1.Enabled = true;
                    }
                    if (Convert.ToInt32(textBox11.Text) > 1)
                    {
                        textBox2.Enabled = true;
                    }
                    if (Convert.ToInt32(textBox11.Text) > 2)
                    {
                        textBox3.Enabled = true;
                    }
                    if (Convert.ToInt32(textBox11.Text) > 3)
                    {
                        textBox4.Enabled = true;
                    }
                    if (Convert.ToInt32(textBox11.Text) > 4)
                    {
                        textBox5.Enabled = true;
                    }
                    if (Convert.ToInt32(textBox11.Text) > 5)
                    {
                        textBox6.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Uzunluk 1 ile 6 aralığında olmalıdır.");
                    textBox11.Text = "6";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Uzunluğu Boş Bırakmayınız");
            }
        }

        private void fctTimer_Tick(object sender, EventArgs e)
        {
            if (FCT_ENTER_MODE.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    byte[] byteArray = new byte[6];

                    byteArray[0] = 0x42;  //PREAMBLE_FTC_Client
                    byteArray[1] = 0x00;  //CMD_EnterFTCMode
                    byteArray[2] = 0x01;  //Data Lenght LSB
                    byteArray[3] = 0x00;  //Data Lenght MSB
                    byteArray[4] = 0x45;  //Data Empty
                    byteArray[5] = 0xFA;  //FTC_Client CRC
                    serialPort1.Write(byteArray, 0, 6);  //5 te olabilir
                }
            }
        }

		private void tBoxDataIN_TextChanged(object sender, EventArgs e)
		{

		}

		/*
 private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
 {

     while (serialPort1.BytesToRead > 0)
     {
         tBoxDataIN.Text = Convert.ToString(serialPort1.ReadByte()) + tBoxDataIN.Text;
     }

     this.Invoke(new EventHandler(ShowData));

 }

 private void ShowData(object sender, EventArgs e)
 {
     tBoxDataIN.Text = "Geldi";
     tBoxDataIN.Text = dataIn;
     dataIn = string.Empty;
 }
 */
	}
}
