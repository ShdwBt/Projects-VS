using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            String Url_recup = Url_check.Text;
            NavigateurWeb.Navigate(Url_recup);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Url_check_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateurWeb.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateurWeb.GoForward();
        }

        private void home_Click(object sender, EventArgs e)
        {
            NavigateurWeb.Navigate("www.google.com");
        }

        private void Fav_Click(object sender, EventArgs e)
        {
            String Url_recup = Url_check.Text;
            comboBox1.Items.Add(Url_recup);
        }

        private void Favoris_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form();



            Form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Url_check.Text = ((ToolStripTextBox)sender).Text;
            //
        }
    }
}
