namespace TrafficLightProject
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
            this.ctrlTrafficLight1 = new TrafficLightProject.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTrafficLight1.GreenTime = 10;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(486, 126);
            this.ctrlTrafficLight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.RedTime = 5;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(127, 238);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.TrafficLightColor = TrafficLightProject.ctrlTrafficLight.LightColor.Yellow;
            this.ctrlTrafficLight1.YellowTime = 10;
            this.ctrlTrafficLight1.OnLightIsRed += new TrafficLightProject.ctrlTrafficLight.LightChangedEventHandler(this.ctrlTrafficLight1_OnLightIsRed);
            this.ctrlTrafficLight1.OnLightIsYellow += new TrafficLightProject.ctrlTrafficLight.LightChangedEventHandler(this.ctrlTrafficLight1_OnLightIsYellow);
            this.ctrlTrafficLight1.OnLightIsGreen += new TrafficLightProject.ctrlTrafficLight.LightChangedEventHandler(this.ctrlTrafficLight1_OnLightIsGreen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
    }
}

