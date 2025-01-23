using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Threading;
using PickmeJaeger.Windows;

namespace PickmeJaeger.Controls
{
    public partial class OrdersControl : UserControl
    {
        private ORDERS _order = new ORDERS();
        public OrdersControl()
        {
            InitializeComponent();
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(ItemReload);
            dispatcher.Interval = new TimeSpan(0, 0, 2);
            dispatcher.Start();
        }


        private void Order_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                try
                {
                    _.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGridOrders.ItemsSource = _.GetContext().ORDERS.Where(p => p.OrderStatus == 0).ToList();
                }
                catch (Exception ex)
                {
                    Message.Show(ex.Message, MessageBoxButton.OK);
                }
            }
        }

        private void ItemReload(object sender, EventArgs e)
        {
            DGridOrders.ItemsSource = _.GetContext().ORDERS.Where(p => p.OrderStatus == 0).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConfirmOrder confirmOrder = new ConfirmOrder((sender as Button).DataContext as ORDERS);
                confirmOrder.Show();
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }
    }
}
