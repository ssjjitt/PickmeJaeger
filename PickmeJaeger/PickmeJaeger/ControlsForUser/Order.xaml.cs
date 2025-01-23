using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using PickmeJaeger.Controls;
using PickmeJaeger.Properties;

namespace PickmeJaeger.ControlsForUser
{
    public partial class Order : UserControl
    {
        DateTime date = DateTime.Now;
        private ORDERS _order = new ORDERS();
        int userid;
        public string email;
        public string wish;
        public DateTime reservedDate;
        List<PickmeJaeger.ORDERS> orderedtables;
        List<PickmeJaeger.ORDERS> usersOrdered;
        List<PickmeJaeger.ORDERS> usersOrdered1;
        public Order()
        {
            InitializeComponent();
            try
            {
                using (var db = new _())
                {
                    var user1 = _.GetContext().USERS.Where(p => p.UserLogin == MySettings.Default.ThisLogin).FirstOrDefault();
                    userid = user1.UserID;
                    usersOrdered = _.GetContext().ORDERS.Where(p => p.OrderStatus == 0).ToList();
                    usersOrdered1 = _.GetContext().ORDERS.Where(p => p.OrderStatus == 1).ToList();
                    orderedtables = _.GetContext().ORDERS.ToList();
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _order;
            try
            {
                // ПРИСВАИВАЕМ ВВЕДЁННЫЕ ДАННЫЕ
                // айдишник
                _order.UserOID = userid;
                //почта
                email = Email.Text;
                if (email.Length > 30)
                {
                    Message.Show("Вы превысили число символов, допустимое при вводе почты", MessageBoxButton.OK);
                } else _order.UserEmail = email;

                //пожелания
                wish = Wishes.Text;
                if (wish.Length > 200)
                {
                    Message.Show("Вы превысили число символов, допустимое в пожеланиях", MessageBoxButton.OK);
                } else _order.Wishes = wish;

                //дата и время
                reservedDate = (DateTime)Picker.Value;
                if (reservedDate.Hour > 23 && reservedDate.Hour < 8)
                {
                    Message.Show("Приносим извинения, но ресторан не работает в это время.", MessageBoxButton.OK);
                } else _order.BookingDatetime = reservedDate;

                //по умолчанию не обработан, поэтому 0
                _order.OrderStatus = Convert.ToInt32(0);
                _order.TableOID = MySettings.Default.ThisTable;
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }


            try
            {
                //Проверяем введённые данные
                StringBuilder errors = new StringBuilder();
                if (string.IsNullOrWhiteSpace(_order.UserEmail))
                    errors.AppendLine("Введите почту");

                if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase) == false)
                    errors.AppendLine("Неправильный формат почты");

                if (string.IsNullOrWhiteSpace(_order.Wishes))
                    errors.AppendLine("Укажите свои пожелания");

                if (_order.BookingDatetime == null)
                    errors.AppendLine("Выберите дату и время для брони");

                if (_order.TableOID == 0 || _order.TableOID == null)
                    errors.AppendLine("Вы не выбрали столик для заказа.");

                if (reservedDate.Year < date.Year)
                {
                    errors.AppendLine("Вы не можете выбрать прошедшие года для брони");
                }

                if (reservedDate.Year == date.Year && reservedDate.Month < date.Month)
                {
                    errors.AppendLine("Вы не можете выбрать прошедшие месяцы для брони");
                }

                if (reservedDate.Year == date.Year && reservedDate.Month == date.Month && reservedDate.Day < date.Day)
                {
                    errors.AppendLine("Вы не можете выбрать прошедшие дни для брони");
                }

                if (reservedDate.Year == date.Year && reservedDate.Month == date.Month && reservedDate.Day == date.Day && reservedDate.TimeOfDay < date.TimeOfDay)
                {
                    errors.AppendLine("Это время уже прошло, на него нельзя заказать");
                }

                if (reservedDate.Hour > 23 || reservedDate.Hour < 8)
                    errors.AppendLine("Приносим извинения, но ресторан не работает в это время");

                if (_order.TableOID == 0 || _order.UserEmail == null || _order.Wishes == null || _order.BookingDatetime == null)
                    errors.AppendLine("Нельзя оставлять данные пустыми");
               /* foreach (var t in usersOrdered)
                {
                    if (t.UserOID == userid)
                        errors.AppendLine("Вы уже сделали заказ.");
                }
                foreach (var t in usersOrdered1)
                {
                    if (t.UserOID == userid)
                        errors.AppendLine("Вы уже сделали заказ. Он был подтверждён нашим администратором");
                }*/

                if (errors.Length > 0)
                {
                    Message.Show($"Вы допустили ошибку при оформлении заказа: {errors.ToString()}", MessageBoxButton.OK);
                    return;
                }
                else
                {
                    if (_order.OrderID == 0)
                        _.GetContext().ORDERS.Add(_order);
                    Message.Show("Заказ успешно оформлен!", MessageBoxButton.OK);

                    
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
            
            
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
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }
    }
}
