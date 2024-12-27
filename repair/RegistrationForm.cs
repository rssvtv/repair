using System;
using System.Windows.Forms;

namespace repair
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Добавляем элементы в ComboBox
            comboBoxRole.Items.Add("Администратор");
            comboBoxRole.Items.Add("Техник");
            comboBoxRole.Items.Add("Пользователь");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text;
            string password = txtRegisterPassword.Text;
            string role = comboBoxRole.SelectedItem?.ToString();

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Логика для сохранения пользователя
            MessageBox.Show("Регистрация прошла успешно!");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
