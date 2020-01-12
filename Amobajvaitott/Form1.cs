using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amobajvaitott
{
    public partial class Form1 : Form
    {
        private string sajat;
        private string ellenfel;
        private int sajat_pont = 0;
        private int ellenfel_pont = 0;
        byte[] num = { 0 };
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient clientSocket;
        private bool jatekagoritmus()
        {
            //vizszintes
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if (button3.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button6.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button9.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            //fuggoleges
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button7.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button8.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button9.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                return true;
            }
            //átlós
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button9.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();;
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();
                }
                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button7.Text == sajat)
                {
                    sajat_pont += 1;
                    MessageBox.Show(sajat + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();
                }
                else
                {
                    ellenfel_pont += 1;
                    MessageBox.Show(ellenfel + ": játékos győzedelmeskedett");
                    label2.Text = sajat + " " + sajat_pont;
                    label5.Text = ellenfel + " " + ellenfel_pont;
                    inditas();
                }
                return true;
            }
            //döntetlen
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Döntetlen");
                inditas();
                return true;
            }
            return false;

        }
        private void fogadas()
        {
            clientSocket.Client.Receive(num);
            if (num[0] == 1)
            {
                button1.Text = ellenfel.ToString();
                button1.Enabled = false;
            }
            if (num[0] == 2)
            {
                button2.Text = ellenfel.ToString();
                button2.Enabled = false;
            }
            if (num[0] == 3)
            {
                button3.Text = ellenfel.ToString();
                button3.Enabled = false;
            }
            if (num[0] == 4)
            {
                button4.Text = ellenfel.ToString();
                button4.Enabled = false;
            }
            if (num[0] == 5)
            {
                button5.Text = ellenfel.ToString();
                button5.Enabled = false;
            }
            if (num[0] == 6)
            {
                button6.Text = ellenfel.ToString();
                button6.Enabled = false;
            }
            if (num[0] == 7)
            {
                button7.Text = ellenfel.ToString();
                button7.Enabled = false;
            }
            if (num[0] == 8)
            {
                button8.Text = ellenfel.ToString();
                button8.Enabled = false;
            }
            if (num[0] == 9)
            {
                button9.Text = ellenfel.ToString();
                button9.Enabled = false;
            }
        }
        private void inditas()
        {
            panel1.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Text = sajat;
            button.Enabled = false;
            num[0] = byte.Parse(button.Tag as string);
            clientSocket.Client.Send(num);
            fogadas();
            jatekagoritmus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(textBox1.Text, int.Parse(textBox2.Text));
            sajat = "O";
            ellenfel = "X";
            inditas();
            fogadas();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button11.Enabled = false;
            button14.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TcpListener host = new TcpListener(new IPEndPoint(IPAddress.Any, int.Parse(textBox2.Text)));
            host.Start();
            sajat = "X";
            ellenfel = "O";
            clientSocket = host.AcceptTcpClient();
            inditas();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button11.Enabled = false;
            button14.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inditas();
        }
    }
}
