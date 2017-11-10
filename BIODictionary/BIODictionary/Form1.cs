using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIODictionary
{
    public partial class Form1 : Form
    {
        dictionaryClass dc = new dictionaryClass();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.TabIndex = 0;
            this.MaximizeBox = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.TopLevel = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wordToDefine=textBox1.Text;
            string result;
            if (textBox1.Text.Equals(null) || textBox1.Text=="")
            {
                MessageBox.Show(this, "Provide a word to define", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                result = dc.readFile(textBox1.Text);
                if(result.Equals(wordToDefine+"\n",StringComparison.OrdinalIgnoreCase) ||result==textBox1.Text+"\n")
                {
                    richTextBox1.Text = "Word not found";
                }
                else { richTextBox1.Text = result; }
            }
           
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        { Color colo = dc.setColor();
            if (colo.IsEmpty)
            { }

            else
            {

            
                Properties.Settings.Default.myColor = colo;
                Properties.Settings.Default.Save();
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color colo = dc.setColor();
            if (colo.IsEmpty)
            { }

            else
            {


                Properties.Settings.Default.foreColor = colo;
                Properties.Settings.Default.Save();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int textsize = Convert.ToInt16(comboBox1.SelectedText);
         //   textBox1.Font = new Font(textBox1.Font.FontFamily, textsize);
        }
    }
    
}
