using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number_lab1 = 0;
        double number_lab2 = 0;
        char ch = ' ';

        bool num_switch=true;

        public Form1()
        {
            InitializeComponent();
        }

        public void pressedNumber(string str)
        {
            if (num_switch)
            {
                label1.Text += str;
            }
            else
            {
                label2.Text += str;
            }
        }

        public void m_switch()
        {
            if (label1.Text != ""&&num_switch==true)
                num_switch = false;
            else if(label2.Text==""&&num_switch==false)
            {
                label1.Text = "";
                num_switch = true;
            }
        }

        public void sum()
        {
            if (label2.Text != "")
            {
                number_lab2 = Convert.ToDouble(label2.Text);

                switch (ch)
                {
                    case '+':
                        {
                            number_lab1 = number_lab1 + number_lab2;

                            label5.Text = Convert.ToString(number_lab1);
                            label2.Text = "";

                            m_switch();
                            break;
                        }
                    case '-':
                        {
                            number_lab1 = number_lab1 - number_lab2;

                            label5.Text = Convert.ToString(number_lab1);
                            label2.Text = "";

                            m_switch();
                            break;
                        }
                    case '*':
                        {
                            number_lab1 = number_lab1 * number_lab2;

                            label5.Text = Convert.ToString(number_lab1);
                            label2.Text = "";

                            m_switch();
                            break;
                        }
                    case '/':
                        {
                            if (number_lab2!=0)
                            {
                                number_lab1 = number_lab1 / number_lab2;

                                label5.Text = Convert.ToString(number_lab1);
                                label2.Text = "";

                                m_switch();
                            }
                            else
                            {
                                label5.Text = "На 0 делить нельзя";
                                label2.Text = "";

                                m_switch();
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkSign(char c)
        {
            string str = label1.Text;

            if (str.Length > 0)
            {
                if (str[str.Length - 1] == '/' || str[str.Length - 1] == '*' || str[str.Length - 1] == '-' ||
                    str[str.Length - 1] == '+')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        Point point;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void label22_MouseMove(object sender, MouseEventArgs e)
        {
            labelC.BackColor = Color.Silver;
        }

        private void labelC_MouseLeave(object sender, EventArgs e)
        {
            labelC.BackColor = Color.White;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.Silver;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.Silver;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label14_MouseMove(object sender, MouseEventArgs e)
        {
            label14.BackColor = Color.Silver;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.White;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.BackColor = Color.Silver;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.White;
        }

        private void label16_MouseMove(object sender, MouseEventArgs e)
        {
            label16.BackColor = Color.Silver;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.BackColor = Color.White;
        }

        private void label15_MouseMove(object sender, MouseEventArgs e)
        {
            label15.BackColor = Color.Silver;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.White;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.White;
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.BackColor = Color.Silver;
        }

        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            label13.BackColor = Color.Silver;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.White;
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            label12.BackColor = Color.Silver;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.White;
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label11.BackColor = Color.Silver;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.White;
        }

        private void label18_MouseMove(object sender, MouseEventArgs e)
        {
            label18.BackColor = Color.Silver;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.BackColor = Color.White;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            label9.BackColor = Color.Silver;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.White;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.BackColor = Color.Silver;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.White;
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            label17.BackColor = Color.Silver;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.BackColor = Color.White;
        }

        private void label22_MouseMove_1(object sender, MouseEventArgs e)
        {
            label22.BackColor = Color.Silver;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.BackColor = Color.White;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.Silver;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
        }

        private void label21_MouseMove(object sender, MouseEventArgs e)
        {
            label21.BackColor = Color.Silver;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.BackColor = Color.White;
        }

        private void label20_MouseMove(object sender, MouseEventArgs e)
        {
            label20.BackColor = Color.Silver;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.BackColor = Color.White;
        }

        private void label19_MouseMove(object sender, MouseEventArgs e)
        {
            label19.BackColor = Color.Silver;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label1.Text!=""&&num_switch&&label1.Text!="-")
            {
                number_lab1 = Convert.ToDouble(label1.Text);
                label1.Text += "/";

                m_switch();
                ch = '/';
            }
        }

        private void labelC_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label5.Text = "";

            number_lab1 = 0;
            number_lab2 = 0;
            ch = ' ';
            num_switch = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label1.Text!=""&&num_switch&&label1.Text!="-")
            {
                number_lab1 = Convert.ToDouble(label1.Text);
                label1.Text += "*";

                m_switch();
                ch = '*';
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

            string str = label1.Text;

            if (label1.Text!=""&&num_switch&&str.Length>1)
            {
                number_lab1 = Convert.ToDouble(label1.Text);
                label1.Text += "-";

                m_switch();
                ch = '-';
            }

            if (label1.Text=="")
            {
                label1.Text = "-";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (label1.Text!=""&&num_switch&&label1.Text!="-")
            {
                number_lab1 = Convert.ToDouble(label1.Text);
                label1.Text += "+";

                m_switch();
                ch = '+';
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

            if (label2.Text != "")
            {
                //равно
                sum();
            }
        }

        //цифры
        private void label22_Click(object sender, EventArgs e)
        {
            string str;
            int n = 0;

            if (num_switch)
            {
                str = label1.Text;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i]==',')
                    {
                        n++;
                    }
                }

                if (n<1&&label1.Text!=""&&label1.Text!="-")
                {
                    label1.Text += ',';
                }
            }
            else
            {
                str = label2.Text;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ',')
                    {
                        n++;
                    }
                }

                if (n < 1&&label2.Text!="")
                {
                    label2.Text += ',';
                }
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            pressedNumber("0");
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            pressedNumber("1");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            pressedNumber("2");

        }

        private void label17_Click(object sender, EventArgs e)
        {
            pressedNumber("3");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pressedNumber("4");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pressedNumber("5");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pressedNumber("6");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pressedNumber("7");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            pressedNumber("8");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pressedNumber("9");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            sum();

            if (label5.Text!="")
            {
                label5.Text = Convert.ToString( Math.Round(Convert.ToDouble(label5.Text)));
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            sum();

            if (label5.Text != "")
            {
                label5.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(label5.Text)));
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            sum();

            if (label5.Text != "")
            {
                label5.Text = Convert.ToString(Math.Truncate(Convert.ToDouble(label5.Text)));
            }
        }
    }
}