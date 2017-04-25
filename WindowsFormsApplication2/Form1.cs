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
        int Cop;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Пустое поле");
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
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

         
    }
}
