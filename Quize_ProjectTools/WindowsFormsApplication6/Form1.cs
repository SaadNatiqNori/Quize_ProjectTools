using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result;

            result = num1 + num2;
            label3.Text =result.ToString();

            if (label3.Text != "5")
            {
                groupBox1.Visible = true;
                button3.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            button3.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (checkBox1.Checked == true)
            {
                sum += Convert.ToInt32(label4.Text);
            }
            if (checkBox2.Checked == true)
            {
                sum += Convert.ToInt32(label5.Text);
            }
            if (radioButton1.Checked == true)
            {
                sum += Convert.ToInt32(label9.Text);
            }
            if (radioButton2.Checked == true)
            {
                sum += Convert.ToInt32(label10.Text);
            }

            if (radioButton1.Checked == true)
            {
                label13.Text = sum.ToString();
                if (checkBox1.Checked == true && radioButton1.Checked == true)
                {
                    comboBox1.Items.Add(label13.Text);
                }else
                {
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                }
            }
            if (radioButton2.Checked == true)
            {
                label13.Text = sum.ToString();
                if (checkBox1.Checked == true && radioButton1.Checked == true)
                {
                    comboBox1.Items.Add(label13.Text);
                }
                else
                {
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                }
            }
        }
    }
}
