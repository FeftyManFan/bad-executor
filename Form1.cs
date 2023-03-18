using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastXploits;

namespace _2MinuteWare
{
    public partial class Form1 : Form
    {
        FastAPI api = new FastAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.Execute(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.Inject();
        }
    }
}
