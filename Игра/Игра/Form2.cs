using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show(" Ответ верный");
                this.radioButton2.ForeColor = Color.Green;
                Form3 frm = new Form3();
                frm.Show();
                this.Close();
            }
            else if (radioButton1.Checked)
            {
                MessageBox.Show(" Ответ неверный");
                this.radioButton1.ForeColor = Color.Red;
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show(" Ответ неверный");
                this.radioButton3.ForeColor = Color.Red;
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show(" Ответ неверный");
                this.radioButton4.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
