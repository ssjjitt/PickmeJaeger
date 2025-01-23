using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PickmeJaeger.ControlsForUser;
using PickmeJaeger.Properties;
using PickmeJaeger.Controls;
using System.Globalization;
using System.Windows.Threading;

namespace PickmeJaeger
{
    public partial class WindowForUser : Window
    {
        List<PickmeJaeger.ORDERS> user;
        // List<PickmeJaeger.ORDERS> userrr;
        
        public WindowForUser()
        {
            InitializeComponent();
            MySettings.Default.ThisTable = 0;
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(ItemReload);
            dispatcher.Interval = new TimeSpan(0, 0, 2);
            dispatcher.Start();

            try
            {
                App.LanguageChanged += LanguageChanged;

                CultureInfo currLang = App.Language;

                //Заполняем меню смены языка:
                menuLanguage.Items.Clear();
                foreach (var lang in App.Languages)
                {
                    ComboBoxItem menuLang = new ComboBoxItem();
                    menuLang.Content = lang.DisplayName;
                    menuLang.Tag = lang;
                    menuLang.IsSelected = lang.Equals(currLang);
                    menuLang.Selected += ChangeLanguageClick;
                    menuLanguage.Items.Add(menuLang);
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OKCancel);
            }
        }

     
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (ComboBoxItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsSelected = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            ComboBoxItem mi = sender as ComboBoxItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = LV.SelectedIndex;
            LV.SelectedItem = null;
            switch (index)
            {
                case 0:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new MainView());
                    break;
                case 1:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new MenuUser());
                    break;
                case 2:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new SearchMenu());
                    break;
                case 3:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Order());
                    break;
                case 4:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Reserve());
                    break;
                case 5:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new Info());
                    break;
                default: break;
            }
        }

        private void ItemReload(object sender, EventArgs e)
        {
            var status = MySettings.Default.ThisStatus;
            var user1 = _.GetContext().USERS.Where(p => p.UserLogin == MySettings.Default.ThisLogin).FirstOrDefault();
            user = _.GetContext().ORDERS.Where(p => p.UserOID == user1.UserID).ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var status = MySettings.Default.ThisStatus;
                var user1 = _.GetContext().USERS.Where(p => p.UserLogin == MySettings.Default.ThisLogin).FirstOrDefault();
                user = _.GetContext().ORDERS.Where(p => p.UserOID == user1.UserID).ToList();


                foreach (var t in user)
                {
                    if (t.OrderStatus == 0)
                    {
                        status = 0;       
                    }
                    else if (t.OrderStatus == 1)
                    {
                        status = 1;
                    }
                }

                switch (status)
                {
                    case 1:
                        Message.Show("Ваш заказ подтверждён, проверьте почту", MessageBoxButton.OK);
                        break;
                    case 0:
                        Message.Show("Ваш заказ ещё не готов", MessageBoxButton.OK);
                        break;
                    case 3:
                        Message.Show("У вас ещё нет заказов", MessageBoxButton.OK);
                        break;
                }
                MySettings.Default.ThisStatus = 3;
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, MessageBoxButton.OK);
            }
        }
    }
}
