using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DogPep
{
    public partial class Form1 : Form
    {
        DogApiHelper api = new DogApiHelper();

        public Form1()
        {
            InitializeComponent();

            button1.Click += BtnImage_Click;
            btnGetFact.Click += BtnFact_Click;
        }

        private async void BtnImage_Click(object sender, EventArgs e)
        {
            string url = await api.GetDogImage();
            if (url != "")
            {
                pictureBox1.Load(url);
            }
        }

        private async void BtnFact_Click(object sender, EventArgs e)
        {
            txtFact.Text = "»щем собаку...";
            string fact = await api.GetDogFact();
            txtFact.Text = fact;
        }
    }
}