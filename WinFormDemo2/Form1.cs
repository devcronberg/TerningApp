using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = DRNyheder.Kerne.DRNyhed.Hent("https://www.dr.dk/nyheder/service/feeds/allenyheder/");
            DateTime a = monthCalendar1.SelectionRange.Start;
            textBox1.Text = a.ToLongDateString();
            textBox1.BackColor = System.Drawing.Color.Red;
            dataGridView1.DataSource = lst;
            
        }
    }
}
