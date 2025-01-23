using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;

namespace PickmeJaeger.Windows
{
    public partial class EditUser : Window
    {
        private USERS _userItem = new USERS();
        public string type;

        public EditUser()
        {
            InitializeComponent();
            DataContext = _userItem;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            // Проверка логина
            if (string.IsNullOrWhiteSpace(_userItem.UserLogin))
            {
                errors.AppendLine("Укажите логин");
            }
            else if (_userItem.UserLogin.Length < 5 || _userItem.UserLogin.Length > 20)
            {
                errors.AppendLine("Логин должен содержать от 5 до 20 символов");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(_userItem.UserLogin, "^[a-zA-Z0-9]+$"))
            {
                errors.AppendLine("Логин может содержать только буквы латинского алфавита и цифры");
            }
            else if (_.GetContext().USERS.Any(u => u.UserLogin == _userItem.UserLogin && u.UserID != _userItem.UserID))
            {
                errors.AppendLine("Пользователь с таким логином уже существует");
            }

            // Проверка пароля
            if (string.IsNullOrWhiteSpace(_userItem.UserPassword))
            {
                errors.AppendLine("Укажите пароль");
            }
            else if (_userItem.UserPassword.Length < 8)
            {
                errors.AppendLine("Пароль должен содержать не менее 8 символов");
            }

            // Проверка роли
            if (_userItem.UserAffiliation == null)
            {
                errors.AppendLine("Укажите роль");
            }

            // Если есть ошибки, выводим их и завершаем выполнение
            if (errors.Length > 0)
            {
                Message.Show($"Вы допустили ошибку при изменении пользователя: {errors.ToString()}", MessageBoxButton.OKCancel);
                return;
            }

            // Если новый пользователь, добавляем его в контекст
            if (_userItem.UserID == 0)
            {
                _.GetContext().USERS.Add(_userItem);
                Message.Show("Информация сохранена", MessageBoxButton.OK);
                this.EditUserWindow.Close();
            }

            try
            {
                _.GetContext().SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(r => r.ValidationErrors)
                    .Select(r => $"Свойство: {r.PropertyName}, Ошибка: {r.ErrorMessage}");

                var fullErrorMessage = string.Join("\n", errorMessages);

                Message.Show($"Ошибка сохранения: {fullErrorMessage}", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                Message.Show($"Произошла ошибка: {ex.Message}", MessageBoxButton.OK);
            }
        }

        private void SelectionChangerUser(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem boxItem = (ComboBoxItem)ComboTypes.SelectedItem;
            type = boxItem.Name;
            _userItem.UserAffiliation = type;
            // MessageBox.Show(type);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.EditUserWindow.Close();
        }
    }
}