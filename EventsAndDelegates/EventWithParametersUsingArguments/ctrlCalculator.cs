using System;
using System.Windows.Forms;

namespace EventWithParametersUsingArguments
{
    public partial class ctrlCalculator : UserControl
    {
        public event EventHandler<ctrlCalculatorEventArgs> OnCalculationComplete;

        public ctrlCalculator()
        {
            InitializeComponent();
        }

        public class ctrlCalculatorEventArgs : EventArgs
        {
            public decimal Num1 { get; }
            public decimal Num2 { get; }
            public decimal Result { get; }

            public ctrlCalculatorEventArgs(decimal num1, decimal num2, decimal result)
            {
                this.Num1 = num1;
                this.Num2 = num2;
                this.Result = result;
            }
        }

        protected virtual void RaiseOnCalculationComplete(ctrlCalculatorEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        protected virtual void RaiseOnCalculationComplete(decimal num1, decimal num2, decimal result)
        {
            RaiseOnCalculationComplete(new ctrlCalculatorEventArgs(num1, num2, result));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum1.Text, out decimal num1)
                && decimal.TryParse(txtNum2.Text, out decimal num2))
            {
                decimal result = num1 + num2;

                lblResult.Text = result.ToString();
                RaiseOnCalculationComplete(num1, num2, result);
            }
        }
    }
}
