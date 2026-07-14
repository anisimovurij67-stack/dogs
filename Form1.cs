using System;
using System.Windows.Forms;

namespace DogApp
{
    public partial class Form1 : Form
    {
        DogApiHelper apiHelper = new DogApiHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetFact_Click(object sender, EventArgs e)
        {
            txtFact.Text = "Загружаю...";
            string fact = await apiHelper.GetDogFactAsync();
            txtFact.Text = fact;
        }
    }
}