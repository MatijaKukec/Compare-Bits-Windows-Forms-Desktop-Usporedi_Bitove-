using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compareBits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            int x = 0;
            foreach (char c in data.ToCharArray())
            {
                if (x < 7)
                {
                    sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                    x++;
                }
                else if (x == 7)
                {
                    sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                    sb.Append(new char[] { ' ' });
                    x = 0;
                }

            }
            return sb.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var input1 = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var input2 = textBox2.Text;

        }

        private void UsporediGumb_Click(object sender, EventArgs e)
        {
            var input1 = textBox1.Text;
            var input2 = textBox2.Text;
            input1=StringToBinary(input1);
            input2 = StringToBinary(input2);
            InputBits1.Text = input1;

            InputBits2.Text = input2;

            if (input1 == input2)
            {
                label1.Text = "Isti su!";
            }
            else if (input1 != input2)
            {
                label1.Text = "Nisu isti!";
            }
        }
    }
}
