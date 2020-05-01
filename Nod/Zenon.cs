using System;

using System.Windows.Forms;
using System.Drawing; 
namespace Nod
{
    public partial class Zenon : Form
    {
        int x1, x2, v1, v2, t, s;
        public Zenon()
        {
            InitializeComponent();          
            timer1.Interval = 500;            
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                x1 = Convert.ToInt32(textBox1.Text);
                x2 = Convert.ToInt32(textBox2.Text);
                pictureBox1.Location = new Point(x1, 51);
                pictureBox2.Location = new Point(x2, 153);
             
                if (x1 < 0)
                {
                    textBox1.Clear();
                }
                if (x2 < 0)
                {
                    textBox2.Clear();
                }

                if(x1 >= x2)
                {
                    x1 = 0;
                    x2 = 0;           
                }
                textBox3.Text = Convert.ToString(x1);
                textBox4.Text = Convert.ToString(x2);
            
            }        
            catch
            {
                textBox1.Clear();
                textBox2.Clear();
            }
           
        }
       public void button2_Click(object sender, EventArgs e)
        {                
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
             v1 = Convert.ToInt32(textBox5.Text);
             v2 = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
                v1 = 2;
                v2 = 1;
                textBox5.Text = Convert.ToString(v1);
                textBox6.Text = Convert.ToString(v2);
            }           
            s = x2 - x1;
            t = s / v1;
            x1 = x2;
            x2 = x2 + t * v2;
            pictureBox1.Location = new Point(x1, 51);
            pictureBox2.Location = new Point(x2, 153);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            t = 0;
            x1 = 0;
            x2 = 0;
            textBox1.Text = Convert.ToString(x1);
            textBox2.Text = Convert.ToString(x2);
            textBox3.Text = Convert.ToString(x1);
            textBox4.Text = Convert.ToString(x2);          
            pictureBox1.Location = new Point(x1, 51);
            pictureBox2.Location = new Point(x2, 153);
        }


        
    }
}
