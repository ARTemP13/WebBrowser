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

namespace WebBrowser
{
    
    public partial class Form1 : Form
    {
        public string search = "";
        public int indexHistory = 0;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            SearchPage.Click += SearchPage_Click;
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardPage_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void RefreshPage_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        public void SearchPage_Click(object sender, EventArgs e)
        {
            picture.Visible = false;    
            webBrowser1.Navigate(SearchText.Text);
            search = SearchText.Text;
            if (indexHistory == 0)
            {
                using (StreamWriter sw1 = new StreamWriter("История.txt"))
                {
                    sw1.WriteLine(SearchText.Text + " " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                }
                indexHistory++;
            }
            else
            {
                using (StreamWriter sw1 = new StreamWriter("История.txt", true))
                {
                    sw1.WriteLine(SearchText.Text + " " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                }   
            }       
        }

        private void Download_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            if(panel3.Visible == true)
            {
                panel3.Visible = false;
            } else {
                panel3.Visible = true;
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            History history = new History(this);
            history.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(this);
            bookmark.Show();
            bookmark.textBox1.Text = search;
        }
    }
}
