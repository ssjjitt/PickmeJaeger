using PickmeJaeger.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PickmeJaeger
{
    public partial class WindowForAdmin : Window
    {
        public WindowForAdmin()
        {
            InitializeComponent();
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
                case 0: // Home
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new MainView());
                    break;
                case 1: // Menu
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new MenuControl());
                    break;
                case 2: // Orders
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new OrdersControl());
                    break;
                case 3: // Users
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new UsersControl());
                    break;
                default:
                    break;
            }
        }
    }
}
