using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PickmeJaeger.Controls;
using PickmeJaeger.Windows;
using PickmeJaeger.MenuWins;
using System;
using System.Windows;

namespace PickmeJaeger.ViewModel
{
    public class AppViewModel : INotifyPropertyChanged
    {
        private bool _isPanelVisible;
        private ICommand _showPanelCommand;
        private ICommand _hidePanelCommand;
        private ICommand _closeCommand;
        private string priceFrom;
        private object selectedType;
        private string priceTo;
        private string weightFrom;
        private string weightTo;

        public event PropertyChangedEventHandler PropertyChanged;

        public string PriceFrom { get => priceFrom; set => SetProperty(ref priceFrom, value); }
        public object SelectedType { get => selectedType; set => SetProperty(ref selectedType, value); }
        public string PriceTo { get => priceTo; set => SetProperty(ref priceTo, value); }
        public string WeightFrom { get => weightFrom; set => SetProperty(ref weightFrom, value); }
        public string WeightTo { get => weightTo; set => SetProperty(ref weightTo, value); }
        public bool IsPanelVisible
        {
            get
            {
                return _isPanelVisible;
            }
            set
            {
                _isPanelVisible = value;
                OnPropertyChanged("IsPanelVisible");
            }
        }

        public AppViewModel()
        {
            // Set Default Panel Visibility //
            IsPanelVisible = false;
        }

        public ICommand ShowPanelCommand
        {
            get
            {
                if (_showPanelCommand == null)
                {
                    _showPanelCommand = new RelayCommand.Command.RelayCommand(p => ShowPanel());
                }
                return _showPanelCommand;
            }
        }
        public ICommand HidePanelCommand
        {
            get
            {
                if (_hidePanelCommand == null)
                {
                    _hidePanelCommand = new RelayCommand.Command.RelayCommand(p => HidePanel());
                }
                return _hidePanelCommand;
            }
        }
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand.Command.RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }

        public void ShowPanel()
        {
            IsPanelVisible = true;
        }
        public void HidePanel()
        {
            IsPanelVisible = false;
        }
        public void CloseApp(object obj)
        {
            Authorization authorization = new Authorization();
            Authorization auth = obj as Authorization;
            WindowForUser win = obj as WindowForUser;
            WindowForAdmin win1 = obj as WindowForAdmin;
            MenuControl menu = obj as MenuControl;
            RegisterControl reg = obj as RegisterControl;
            MainView main = obj as MainView;
            EditMenu edit = obj as EditMenu;
            Steak steak = obj as Steak;
            Dinner dinner = obj as Dinner;
            Coctail coctail = obj as Coctail;
            Bowl bowl = obj as Bowl;
            Pasta pasta = obj as Pasta;
            Salad salad = obj as Salad;

            if (win != null)
            {
                win.Close();
                authorization.Show();
            }
            else if (win1 != null)
            {
                win1.Close();
                authorization.Show();
            }
            else if (menu != null || reg!= null)
            {
                menu.MainGrid.Children.Clear();
                menu.MainGrid.Children.Add(main);
            }
            else if (edit != null)
            {
                edit.Close();
            }
            else if (steak != null)
            {
                steak.Close();
            }
            else if (dinner != null)
            {
                dinner.Close();
            }
            else if (coctail != null)
            {
                coctail.Close();
            }
            else if (bowl != null)
            {
                bowl.Close();
            }
            else if (pasta != null)
            {
                pasta.Close();
            }
            else if (salad != null)
            {
                salad.Close();
            }
            else if (auth != null)
            {
                auth.Close();
            }

        }
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
    }
}
