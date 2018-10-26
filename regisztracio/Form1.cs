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

namespace regisztracio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter("adatok.txt"))
            {
                              
                string nem = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                    nem = radioButton1.Text;
                else
                    nem = radioButton2.Text;
                sr.WriteLine(textBox2.Text + ";" + textBox3.Text + ";" + nem + ";" + HobbiList.Text);



            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxHobbi.Text!=" ")
            {
                HobbiList.Items.Add(this.textBoxHobbi.Text);
                this.textBoxHobbi.Focus();

                    
            }
            
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

        }
    }
}
