using Microsoft.Maps.MapControl.WPF;
//using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
//using Microsoft.Toolkit.Wpf.UI.Controls;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PickmeJaeger.Windows;
using System.Windows.Threading;

namespace PickmeJaeger.ControlsForUser
{
    public partial class Info : UserControl
    {
        public ApplicationIdCredentialsProvider Provider { get; set; } = new ApplicationIdCredentialsProvider("yUEYrzfL9ZYgm1UQ5KJl~yFMemSXAmt9B1IMoY9TvNw~ApHWaiv9BWijN1VESXCP_2YdlGmU7SiG142BdT3NdWwtzcRsWQcd1eVJxGHdFeKY");
        public Info()
        {
            InitializeComponent();
            this.DataContext = this;
            // myMap.CredentialsProvider = Provider;
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(ItemReload);
            dispatcher.Interval = new TimeSpan(0, 0, 2);
            dispatcher.Start();
        }

        private void ItemReload(object sender, EventArgs e)
        {
            nood.ItemsSource = _.GetContext().REVIEWS.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddComment addComment = new AddComment();
            addComment.Show();
        }
    }
}
