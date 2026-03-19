namespace SendDataBackToFormUsingDelegate
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
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.txtDataBack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(415, 243);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(211, 64);
            this.btnShowForm2.TabIndex = 0;
            this.btnShowForm2.Text = "Show Form2";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // txtDataBack
            // 
            this.txtDataBack.Location = new System.Drawing.Point(415, 207);
            this.txtDataBack.Name = "txtDataBack";
            this.txtDataBack.Size = new System.Drawing.Size(211, 30);
            this.txtDataBack.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 515);
            this.Controls.Add(this.txtDataBack);
            this.Controls.Add(this.btnShowForm2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm2;
        private System.Windows.Forms.TextBox txtDataBack;
    }
}

