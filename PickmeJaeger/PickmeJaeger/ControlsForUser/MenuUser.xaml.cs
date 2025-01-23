using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PickmeJaeger.MenuWins;

namespace PickmeJaeger.ControlsForUser
{
    public partial class MenuUser : UserControl
    {
        
        public MenuUser()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Steak steak = new Steak();
            steak.Show();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Dinner dinner = new Dinner();
            dinner.Show();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Salad salad = new Salad();
            salad.Show();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Pasta pasta = new Pasta();
            pasta.Show();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Bowl bowl = new Bowl();
            bowl.Show();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            Coctail coctail = new Coctail();
            coctail.Show();
        }
    }
}
