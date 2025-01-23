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
using System.Net;
using System.Net.Mail;

namespace PickmeJaeger.Windows
{
    public partial class ConfirmOrder : Window
    {
        public string status;
        private ORDERS _currentOrder = new ORDERS();
        public ConfirmOrder(ORDERS selectedOrder)
        {
            InitializeComponent();
            if (selectedOrder != null)
                _currentOrder = selectedOrder;

            DataContext = _currentOrder;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Confirm.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            _currentOrder.OrderStatus = 1;
            
            if (_currentOrder.OrderStatus == null)
                errors.AppendLine("Для подтверждения нужно указать 1");

            if(errors.Length > 0)
            {
                Message.Show(errors.ToString(), MessageBoxButton.OKCancel);
            }

            try
            {
                _.GetContext().SaveChanges();
                Message.Show("Статус заказа обновлён", MessageBoxButton.OKCancel);


                MailAddress fromAdress = new MailAddress("ssjjitt@gmail.com", "PickmeJaeger Restaurant");
                MailAddress toAdress = new MailAddress(_currentOrder.UserEmail);
                MailMessage message = new MailMessage(fromAdress, toAdress);
                message.Body = $"Приветствуем в ресторане PickmeJaeger! Ваш заказ был подтверждён. Дата и время, на которое забронирован столик - {_currentOrder.BookingDatetime}, номер столика - {_currentOrder.TableOID}. Спасибо, что выбираете нас! Будем ждать Вас с нетерпением :)";
                message.Subject = "Подтверждение заказа";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "jgbi kidi orbq ursv");

                smtpClient.Send(message);

                this.Confirm.Close();
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OKCancel);
            }
        }
    }
}
