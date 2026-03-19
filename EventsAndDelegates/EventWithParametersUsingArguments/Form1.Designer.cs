namespace EventWithParametersUsingArguments
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlCalculator1 = new EventWithParametersUsingArguments.ctrlCalculator();
            this.SuspendLayout();
            // 
            // ctrlCalculator1
            // 
            this.ctrlCalculator1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ctrlCalculator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCalculator1.Location = new System.Drawing.Point(319, 153);
            this.ctrlCalculator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCalculator1.Name = "ctrlCalculator1";
            this.ctrlCalculator1.Size = new System.Drawing.Size(293, 160);
            this.ctrlCalculator1.TabIndex = 0;
            this.ctrlCalculator1.OnCalculationComplete += new System.EventHandler<EventWithParametersUsingArguments.ctrlCalculator.ctrlCalculatorEventArgs>(this.ctrlCalculator1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 586);
            this.Controls.Add(this.ctrlCalculator1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculator ctrlCalculator1;
    }
}

