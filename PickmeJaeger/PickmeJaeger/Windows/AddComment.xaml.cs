using Microsoft.Win32;
using PickmeJaeger.Properties;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PickmeJaeger.Windows
{
    public partial class AddComment : Window
    {
       
        private REVIEWS _review = new REVIEWS();
        public string path;
        int userid;
        public AddComment()
        {
            InitializeComponent();
            DataContext = _review;
            try
            {
                using (var db = new _())
                {
                    var user1 = _.GetContext().USERS.Where(p => p.UserLogin == MySettings.Default.ThisLogin).FirstOrDefault();
                    userid = user1.UserID;
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OKCancel);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
                    _review.ReviewImage = path;
                }
                _review.UserRID = userid;
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_review.ReviewImage == null)
                errors.AppendLine("Выберите картинку");
            if (string.IsNullOrWhiteSpace(_review.ReviewText))
                errors.AppendLine("Введите текст вашего комментария");
         
            if (errors.Length > 0)
            {
                Message.Show($"Вы допустили ошибку при изменении блюда: {errors.ToString()}", MessageBoxButton.OKCancel);
                return;
            }
            if (_review.ReviewID == 0)
                _.GetContext().REVIEWS.Add(_review);
            Message.Show("Информация сохранена", MessageBoxButton.OKCancel);
            this.Comment.Close();

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Comment.Close();
        }
    }
}
