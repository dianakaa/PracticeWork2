using System;
using System.IO;

namespace LabWork2
{
    public partial class Form1 : Form
    {
        FileInfo loginFile = new FileInfo("login.csv");

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (!loginFile.Exists)
            {
                label3.Text = ("Файл не существует.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните, пожалуйста, все поля.");
                return;
            }

            var loginRows = File.ReadAllLines(loginFile.FullName);
            foreach (var loginRow in loginRows)
            {
                string[] login = loginRow.Split(';');
                if (textBoxLogin.Text == login[0])
                {
                    MessageBox.Show("Логин уже существует.");
                }
            }
            File.AppendAllText(loginFile.FullName, $"{textBoxLogin.Text};{textBoxPassword.Text};{DateTime.Now}{Environment.NewLine}");
            MessageBox.Show("Вы успешно зарегистрированы.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
