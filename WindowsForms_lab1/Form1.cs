using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Create_task_button_click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Не введена фамилия");
                return;
            }
            if (radioButton1.Checked)
            {
                Form2 tf2 = new Form2(textBox2.Text, comboBox1.Text, numericUpDown1.Value);
                radioButton1.Checked = true;
                tf2.ShowDialog();
            }
            if (radioButton2.Checked)
            {
                Form_simple tf3 = new Form_simple(textBox2.Text, comboBox1.Text, numericUpDown1.Value);
                radioButton2.Checked = true;
                tf3.ShowDialog();
            }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Form_simple tf = new Form_simple(textBox2.Text, comboBox1.Text, numericUpDown1.Value);
        }
    }
}
