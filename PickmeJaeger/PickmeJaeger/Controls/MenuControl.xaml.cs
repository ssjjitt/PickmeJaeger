using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using PickmeJaeger.Windows;

namespace PickmeJaeger.Controls
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(ItemReload);
            dispatcher.Interval = new TimeSpan(0, 0, 2);
            dispatcher.Start();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var dishesDelete = DGridMenu.SelectedItems.Cast<MENU>().ToList();

            if(MessageBox.Show($"Вы точно хотите удалить следующие {dishesDelete.Count()} Элементов?", "Внимание",
               MessageBoxButton.YesNo, MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                try
                {
                    _.GetContext().MENU.RemoveRange(dishesDelete);
                    _.GetContext().SaveChanges();
                    Message.Show("Данные удалены", MessageBoxButton.OKCancel);

                    DGridMenu.ItemsSource = _.GetContext().MENU.ToList();
                }
                catch(Exception ex)
                {
                    Message.Show(ex.Message.ToString(), MessageBoxButton.OKCancel);
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            EditMenu editMenu = new EditMenu();
            editMenu.Show();
        }

        private void Menu_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (Visibility == Visibility.Visible)
                {

                    _.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGridMenu.ItemsSource = _.GetContext().MENU.ToList();

                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
            
        }

        private void ItemReload(object sender, EventArgs e)
        {
            DGridMenu.ItemsSource = _.GetContext().MENU.ToList();
        }
    
    }
}
