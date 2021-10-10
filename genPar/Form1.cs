using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int count = (int)numericUpDown1.Value;
            string str = string.Empty;
            int r;
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            for (int i = 0; i < count; i++)
            {
                r = rnd.Next(chars.Length);
                str += chars[r];
            }
            richTextBox1.Text = Convert.ToString(str);
        }
    }
}
