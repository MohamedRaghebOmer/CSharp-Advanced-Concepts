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
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(string data);
        public event DataBackEventHandler DataBack;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendToForm1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(txtData.Text);
        }
    }
}
