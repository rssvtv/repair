using repair;
using System;
using System.Windows.Forms;

namespace repair
{
    public partial class LoginForm : Form
        {
            private const string validUsername = "Админ";
            private const string validPassword = "12345";

            public LoginForm()
            {
                InitializeComponent();
                // Добавление ролей в ComboBox

            }

            private void LoginForm_Load(object sender, EventArgs e)
            {
                // Здесь можно добавить логику, которая будет выполняться при загрузке формы
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                // Проверка учетных данных
                if (username == validUsername && password == validPassword)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    // Открываем главную форму
                    MainForm mainForm = new MainForm();
                    mainForm.Show(); // Открываем главную форму
                    this.Hide(); // Скрываем форму авторизации
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }
            }

            private void btnRegister_Click(object sender, EventArgs e)
            {
                // Открываем форму регистрации
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.ShowDialog(); // Используйте ShowDialog для модального окна
            }
        }
    }


