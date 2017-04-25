using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double OldPrice;
        int[] NewPrice;
        string NewPrice1;
        string NewPrice2;
        string OldPrice1;
        int Cop;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода пустое. Введите значение.");
                return;
            }

            if (textBox1.Text.Length >= 10)
            {
                MessageBox.Show("Число слишком велико. Введите число поменьше.");
                return;
            }

            OldPrice = Convert.ToInt32(textBox1.Text);

            NewPrice = new int[2];
            NewPrice[0] = (int)OldPrice / 10000;
            NewPrice[1] = (int)OldPrice % 10000;
            Cop = NewPrice[1] / 100;

            textBox2.Text = NewPrice[0].ToString();
            textBox3.Text = Cop.ToString();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }

            if (textBox1.Text == "")
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 10)
            {
                MessageBox.Show("Число слишком велико. Введите число поменьше.");
                return;
            }

            if (textBox3.Text.Length == 2)
            {
                
            }

            NewPrice1 = textBox2.Text;
            NewPrice2 = textBox3.Text;

            OldPrice1 = NewPrice1 + NewPrice2;
            textBox1.Text = OldPrice1.ToString() + "00";

            if(textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            if (textBox3.TextLength == 1)
            {
                textBox1.Text = NewPrice1 + "0" + NewPrice2 + "00";
            }

            if(textBox2.Text.Length != 0)
            {
                if(textBox2.Text[0] == '0' )
                {
                    textBox1.Text = "";
                }
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }

            if (textBox2.Text == "")
            {
                textBox1.Text = "";
            }

            if (textBox3.Text == "")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;

            if (textBox3.Text.Length == 2)
                e.Handled = true;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }
    }
}
