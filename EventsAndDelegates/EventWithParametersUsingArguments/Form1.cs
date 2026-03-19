using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWithParametersUsingArguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculator1_OnCalculationComplete(object sender, ctrlCalculator.ctrlCalculatorEventArgs e)
        {
            MessageBox.Show($"{e.Num1} + {e.Num2} = {e.Result}");
        }
    }
}
