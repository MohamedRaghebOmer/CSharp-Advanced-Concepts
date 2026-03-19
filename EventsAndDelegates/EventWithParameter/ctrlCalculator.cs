using System;
using System.Windows.Forms;

namespace EventWithParameter
{
    public partial class ctrlCalculator : UserControl
    {
        public event Action<decimal> OnCalculationComplete;

        protected virtual void CalculationComplete(decimal value)
        {
            Action<decimal> handler = OnCalculationComplete;
            handler?.Invoke(value);
        }

        public ctrlCalculator()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal num1)
                && decimal.TryParse(textBox2.Text, out decimal num2))
            {
                decimal result = num1 + num2;

                label1.Text = result.ToString();
                CalculationComplete(result);
            }
        }
    }
}
