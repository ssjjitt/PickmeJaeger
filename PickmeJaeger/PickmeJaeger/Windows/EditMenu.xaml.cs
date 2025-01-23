using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PickmeJaeger.Windows
{
    public partial class EditMenu : Window
    {
        private MENU _menuItem = new MENU();
        public string path;
        public string type;

        public EditMenu()
        {
            InitializeComponent();
            DataContext = _menuItem;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (t1.Text.Length > 50)
                errors.AppendLine("Название блюда не может быть таким длинным");
            if (t4.Text.Length > 200)
                errors.AppendLine("Описание не может быть таким длинным");
            if (_menuItem.DishImage == null)
                errors.AppendLine("Выберите картинку");
            if (string.IsNullOrWhiteSpace(_menuItem.DishName))
                errors.AppendLine("Укажите название блюда");
            if (_menuItem.DishPrice == null)
                errors.AppendLine("Укажите цену блюда");
            if (_menuItem.DishWeight == null)
                errors.AppendLine("Введите вес блюда");
            if (string.IsNullOrWhiteSpace(_menuItem.DishDescription))
                errors.AppendLine("Добавьте описание");
            if (_menuItem.DishType == null)
                errors.AppendLine("Укажите тип блюда");

            if (errors.Length > 0)
            {
                Message.Show($"Вы допустили ошибку при изменении блюда: {errors.ToString()}", MessageBoxButton.OKCancel);
                return;
            }
            if (_menuItem.DishId == 0)
                _.GetContext().MENU.Add(_menuItem);
                Message.Show("Информация сохранена", MessageBoxButton.OKCancel);
                this.EditMenuWindow.Close();
                
            try
            {
                _.GetContext().SaveChanges();
                
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OKCancel);
            }
        }

        private void BtnLoadClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    path = openFileDialog.FileName;
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    imgDynamic.Source = new BitmapImage(fileUri);
                    _menuItem.DishImage = path;

                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
            
        }

        
        private void ComboTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem boxItem = (ComboBoxItem)ComboTypes.SelectedItem;
            type = boxItem.Name;
            _menuItem.DishType = type;
            // MessageBox.Show(type);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.EditMenuWindow.Close();
        }
    }
}
