using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nod
{
    public partial class FormEvklcs : Form
    {
        public FormEvklcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
             
            while (a != 0 & b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
              
                else
                {
                    b = b % a;
                }

            }

            textBox3.Text = Convert.ToString(b+a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
