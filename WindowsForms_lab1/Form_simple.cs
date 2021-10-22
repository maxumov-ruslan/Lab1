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
    public partial class Form_simple : Form
    {
        public Form_simple()
        {
            InitializeComponent();
        }
        public Form_simple(string p1, string p2, decimal p3)
        {
            InitializeComponent();
            
            int n = Convert.ToInt32(p3);
            for (int i = 0; i < n; i++)
            {
                TextBox t = new TextBox();
                t.Text = ("Задачки какие нибудь");
                int x, y;
                x = 20;
                y = i * 30;
                t.Location = new Point(x, y);
                this.Controls.Add(t);
            }
        }
        private void Form_simple_Load(object sender, EventArgs e)
        {

        }
    }
}
