using PickmeJaeger.Windows;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PickmeJaeger.Controls
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(ItemReload);
            dispatcher.Interval = new TimeSpan(0, 0, 2);
            dispatcher.Start();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var usersToDelete = DGridUsers.SelectedItems.Cast<USERS>().ToList();

            var restrictedUser = usersToDelete.FirstOrDefault(user =>
            user.UserLogin == "Admin" && user.UserAffiliation == "administrator");

            if (restrictedUser != null)
            {
                Message.Show($"Нельзя удалить администратора", MessageBoxButton.OK);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить {usersToDelete.Count()} пользовател(я/ей)?", "Внимание",
               MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    foreach (var user in usersToDelete)
                    {
                        var relatedOrders = _.GetContext().ORDERS.Where(o => o.UserOID == user.UserID).ToList();
                        var relatedReviews = _.GetContext().REVIEWS.Where(r => r.UserRID == user.UserID).ToList();

                        _.GetContext().ORDERS.RemoveRange(relatedOrders);
                        _.GetContext().REVIEWS.RemoveRange(relatedReviews);
                    }
                    _.GetContext().USERS.RemoveRange(usersToDelete);
                    _.GetContext().SaveChanges();
                    Message.Show("Удаление прошло успешно!", MessageBoxButton.OK);

                    DGridUsers.ItemsSource = _.GetContext().USERS.ToList();
                }
                catch (Exception ex)
                {
                    Message.Show(ex.Message.ToString(), MessageBoxButton.OK);
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.Show();
        }

        private void UsersMenu_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (Visibility == Visibility.Visible)
                {
                    _.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGridUsers.ItemsSource = _.GetContext().USERS.ToList();
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }

        private void ItemReload(object sender, EventArgs e)
        {
            DGridUsers.ItemsSource = _.GetContext().USERS.ToList();
        }
    }
}
