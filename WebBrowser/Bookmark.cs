using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebBrowser
{
    public partial class Bookmark : Form
    {
        Form1 form1;
        public Bookmark(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            listBox1.Items.AddRange(File.ReadAllLines("Закладки.txt", Encoding.Default));
        }

        private void AddBookmark_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            using (StreamWriter sw = new StreamWriter("Закладки.txt"))
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    sw.WriteLine(listBox1.Items[j]);
                }             
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            this.Close();
            form1.SearchText.Text = str;
            form1.webBrowser1.Navigate(form1.SearchText.Text);
            form1.panel3.Visible = false;
        }

        private void RemoveBookmake_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Нет выделенной строки");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                using (StreamWriter sw = new StreamWriter("Закладки.txt"))
                {
                    for (int j = 0; j < listBox1.Items.Count; j++)
                    {
                        sw.WriteLine(listBox1.Items[j]);
                    }   
                }
            }
        }
    }
}
