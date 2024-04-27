using LLC_SportsGoods.Classes;
using LLC_SportsGoods.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLC_SportsGoods
{
    public partial class LoginForm : Form
    {
        private int loginAttempts;

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                WarningMessage("Необходимо заполнить все поля, чтобы войти в аккаунт.");
                return;
            }
            
            try
            {
                string login = tbLogin.Text.Trim();
                string password = tbPassword.Text.Trim();

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("LoginCheck", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                UserData userData = new UserData(reader);

                                Welcome(UserData.lastName, UserData.firstName, UserData.patronymic);

                                ProductsForm productsForm = new ProductsForm();
                                productsForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                loginAttempts++;

                                WarningMessage("Пользователя с такими логином и паролем не существует.");

                                if (loginAttempts > 0)
                                {
                                    CaptchForm captchForm = new CaptchForm();
                                    captchForm.ShowDialog();

                                    // блокирую возможность ввода на 10 сек, если капча введена неверно
                                    if (captchForm.isCorrectAnswer == false)
                                    {
                                        WarningMessage("Возможность входа заблокирована на 10 сек.");

                                        DisableUserInput();
                                        await Task.Delay(10000);
                                        EnableUserInput();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine($"Ошибка авторизации {sqlex.Message}");
                ErrorMessage("Ошибка авторизации, проверьте подлкючение к базе данных.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка авторизации {ex.Message}");
                ErrorMessage("Произошла непредвиденная ошибка.");
            }
        }

        private void EnableUserInput()
        {
            tbLogin.Enabled = true;
            tbPassword.Enabled = true;
            btnLogin.Enabled = true;
            btnGuest.Enabled = true;
        }

        private void DisableUserInput()
        {
            tbLogin.Enabled = false;
            tbPassword.Enabled = false;
            btnLogin.Enabled = false;
            btnGuest.Enabled = false;
        }

        private void Welcome(string lastName, string firstName, string patronymic)
        {
            string welcome;

            if (DateTime.Now.Hour < 12)
            {
                welcome = "Доброе утро";
            }
            else if (DateTime.Now.Hour < 17)
            {
                welcome = "Добрый день";
            }
            else
            {
                welcome = "Добрый вечер";
            }
            MessageBox.Show($"{welcome} {lastName} {firstName} {patronymic}!");
        }

        private void WarningMessage(string message)
        {
            MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }
    }
}
