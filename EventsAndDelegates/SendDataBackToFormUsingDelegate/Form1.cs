using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBackToFormUsingDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.DataBack += Form2_DataBack;
            frm.Show();
        }

        private void Form2_DataBack(string data)
        {
            txtDataBack.Text = data;
        }
    }
}
