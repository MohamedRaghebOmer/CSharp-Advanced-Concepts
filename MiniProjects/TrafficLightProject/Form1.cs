using System.Windows.Forms;

namespace TrafficLightProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ctrlTrafficLight1.Start();
        }

        private void ctrlTrafficLight1_OnLightIsGreen()
        {
            MessageBox.Show("Green");
        }

        private void ctrlTrafficLight1_OnLightIsRed()
        {
            MessageBox.Show("Red");
        }

        private void ctrlTrafficLight1_OnLightIsYellow()
        {
            MessageBox.Show("Yellow");
        }
    }
}
