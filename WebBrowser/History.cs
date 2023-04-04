using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebBrowser
{
    public partial class History : Form
    {
        Form1 form1;
        public History(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            listBox1.Items.AddRange(File.ReadAllLines("История.txt", Encoding.Default));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw1 = new StreamWriter("История.txt", false))
            {
                sw1.WriteLine();
                listBox1.Text = "";

            }
            form1.indexHistory = 0;
            this.Close();
            MessageBox.Show("История удалена");
        }
    }
}
