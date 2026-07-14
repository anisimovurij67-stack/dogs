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

            // ВАЖНО: Ручная привязка. 
            // Если твои кнопки на форме называются как-то иначе (не button1 и button2),
            // просто поменяй названия ниже на те, что у тебя в конструкторе.

            button1.Click += BtnImage_Click;
            btnGetFact.Click += BtnFact_Click;
        }

        // Логика для картинки
        private async void BtnImage_Click(object sender, EventArgs e)
        {
            string url = await api.GetDogImage();
            if (url != "")
            {
                // Замени pictureBox1 на свое название, если нужно
                pictureBox1.Load(url);
            }
        }

        // Логика для текста
        private async void BtnFact_Click(object sender, EventArgs e)
        {
            // Замени textBox1 на свое название, если нужно
            txtFact.Text = "Ищем собаку...";
            string fact = await api.GetDogFact();
            txtFact.Text = fact;
        }
    }
}