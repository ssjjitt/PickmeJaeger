using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PickmeJaeger.Properties;


namespace PickmeJaeger.Controls
{
    public partial class LoginControl : UserControl
    {
        public Authorization authorization;
        public LoginControl(Authorization _authorization)
        {
            InitializeComponent();
            authorization = _authorization;
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(loginField.Text.Length == 0 && passwordField.Password.Length == 0)
                {
                    Message.Show("Логин и пароль должны быть заполнены", MessageBoxButton.OK);
                }
                if (loginField.Text.Length > 0)
                {
                    if (loginField.Text.Length > 20)
                    {
                        Message.Show("Логин не может быть длинной больше 20 символов!", MessageBoxButton.OK);
                    }
                    else
                    {
                        if (passwordField.Password.Length > 20)
                        {
                            Message.Show("Логин не может быть длинной больше 20 символов!", MessageBoxButton.OK);
                        }
                        else
                        {
                            if (passwordField.Password.Length > 0)
                            {
                                DataTable dt_user = authorization.Select("SELECT * FROM [dbo].[USERS] WHERE [UserLogin] = '" + loginField.Text +
                                                                                                    "' AND [UserPassword] = '" + passwordField.Password + "'");
                                if (dt_user.Rows.Count > 0)       
                                {
                                    MySettings.Default.ThisLogin = loginField.Text;
                                    MySettings.Default.Save();

                                    Message.Show("Рады приветствовать Вас в приложении PickmeJaeger!", MessageBoxButton.OK);
                                    WindowForAdmin win1 = new WindowForAdmin();
                                    WindowForUser win2 = new WindowForUser();
                                    if (loginField.Text == "Admin")
                                    {
                                        win1.Show();
                                    }
                                    else
                                    {
                                        win2.Show();
                                    }
                                    authorization.Close();
                                }
                                else Message.Show("Пользователь с таким логином и паролем не существует", MessageBoxButton.OK);
                            }
                            else Message.Show("Введите пароль", MessageBoxButton.OK);
                        }
                    }
                }
                else Message.Show("Введите логин", MessageBoxButton.OK);
            }
            catch (Exception  ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            authorization.OpenControl(Authorization.controls.register);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.authorization.Close();
            Application.Current.Shutdown();
        }
    }
}
