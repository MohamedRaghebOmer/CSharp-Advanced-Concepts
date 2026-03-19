namespace SendDataBackToFormUsingDelegate
{
    partial class Form2
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSendToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(495, 301);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(211, 30);
            this.txtData.TabIndex = 3;
            // 
            // btnSendToForm1
            // 
            this.btnSendToForm1.Location = new System.Drawing.Point(495, 337);
            this.btnSendToForm1.Name = "btnSendToForm1";
            this.btnSendToForm1.Size = new System.Drawing.Size(211, 64);
            this.btnSendToForm1.TabIndex = 2;
            this.btnSendToForm1.Text = "Send To Form1";
            this.btnSendToForm1.UseVisualStyleBackColor = true;
            this.btnSendToForm1.Click += new System.EventHandler(this.btnSendToForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSendToForm1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSendToForm1;
    }
}