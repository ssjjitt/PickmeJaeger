using System.Windows;
using System.Windows.Controls;
using PickmeJaeger.Properties;


namespace PickmeJaeger.ControlsForUser
{
    public partial class Reserve : UserControl
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 1;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 2;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 3;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 4;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 5;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 6;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 7;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 8;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 9;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 10;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 11;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 12;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 13;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 14;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MySettings.Default.ThisTable = 15;
            Message.Show($"Вы выбрали столик под номером {MySettings.Default.ThisTable.ToString()}", MessageBoxButton.OK);
        }
    }
}
