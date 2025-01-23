using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace PickmeJaeger.Controls
{
    public partial class RegisterControl : UserControl
    {
        public Authorization authorization;
        public RegisterControl(Authorization _authorization)
        {
            InitializeComponent();
            authorization = _authorization;
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (loginField.Text.Length > 0) // проверяем логин
                {
                    if (passField1.Password.Length > 0) // проверяем пароль
                    {
                        if (passField2.Password.Length > 0) // проверяем второй пароль
                        {
                            if (passField1.Password.Length >= 6)
                            {
                                bool en = true; // английская раскладка
                                bool symbol = false; // символ
                                bool number = false; // цифра

                                for (int i = 0; i < passField1.Password.Length; i++) // перебираем символы
                                {
                                    if (passField1.Password[i] >= 'А' && passField1.Password[i] <= 'Я') en = false; // если русская раскладка
                                    if (passField1.Password[i] >= 'а' && passField1.Password[i] <= 'я') en = false; // если русская раскладка
                                    if (passField1.Password[i] >= '0' && passField1.Password[i] <= '9') number = true; // если цифры
                                    if (passField1.Password[i] == '_' || passField1.Password[i] == '-' || passField1.Password[i] == '!') symbol = true; // если символ
                                }

                                if (en)
                                {
                                    if (symbol)
                                    {
                                        if (number)
                                        {
                                            if (loginField.Text.Length > 20)
                                            {
                                                Message.Show("Логин не может быть длиннее 20 символов", MessageBoxButton.OK);
                                            }
                                            else
                                            {
                                                if (passField1.Password.Length > 20 || passField2.Password.Length > 20)
                                                {
                                                    Message.Show("Пароль не может быть длиннее 20 символов", MessageBoxButton.OK);
                                                }
                                                else
                                                {
                                                    if (passField1.Password == passField2.Password) // проверка на совпадение паролей
                                                    {
                                                        DataTable dt_user1 = authorization.Select("SELECT * FROM [dbo].[USERS] WHERE [UserLogin] = '" + loginField.Text + "'");
                                                        if (dt_user1.Rows.Count == 0)
                                                        {
                                                            DataTable dt_user = authorization.Select("INSERT INTO [dbo].[USERS] ([UserLogin], [UserPassword]) VALUES ('" + loginField.Text + "','" + passField1.Password + "')");
                                                            Message.Show("Пользователь зарегистрирован", MessageBoxButton.OK);
                                                            loginField.Text = null;
                                                            passField1.Password = "Password";
                                                            passField2.Password = "Password";
                                                        }
                                                        else
                                                        {
                                                            Message.Show("Пользователь с таким именем уже зарегестрирован", MessageBoxButton.OK);
                                                            loginField.Text = null;
                                                            passField1.Password = "Password";
                                                            passField2.Password = "Password";
                                                        }
                                                    }
                                                    else Message.Show("Пароли не совпадают", MessageBoxButton.OK);
                                                }
                                            }
                                        }
                                        else Message.Show("Добавьте хотя бы одну цифру", MessageBoxButton.OK);
                                    }
                                    else Message.Show("Добавьте один из следующих символов: _ - !", MessageBoxButton.OK);
                                }
                                else Message.Show("Доступна только английская раскладка", MessageBoxButton.OK);
                            }
                            else Message.Show("Пароль слишком короткий, минимум 6 символов", MessageBoxButton.OK);
                        }
                        else Message.Show("Повторите пароль", MessageBoxButton.OK);
                    }
                    else Message.Show("Укажите пароль", MessageBoxButton.OK);
                }
                else Message.Show("Укажите логин", MessageBoxButton.OK);
            } 
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            authorization.OpenControl(Authorization.controls.login);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.authorization.Close();
        }
    }
}
