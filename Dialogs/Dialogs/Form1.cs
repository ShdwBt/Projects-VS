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

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.OpenFile();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void Font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
        
        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
            StreamReader ts;
            ts = new StreamReader(openFileDialog1.OpenFile());
            textBox1.Text = ts.ReadToEnd();
            ts.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter ts;
                ts = new StreamWriter(saveFileDialog1.FileName);
                //textBox1.Text = ts.;
                 
                ts.Write(textBox1.Text);
                ts.Close();
            }
           

            /*if (saveFileDialog1.FileName != ""){
                textBox1.Text = saveFileDialog1.OpenFile();
            }*/
        }
    }
}
