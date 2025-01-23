using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PickmeJaeger.ControlsForUser
{
    /// <summary>
    /// Логика взаимодействия для SearchMenu.xaml
    /// </summary>
    public partial class SearchMenu : UserControl, INotifyPropertyChanged
    {
        private List<MENU> _menuItems;
        private string _currentSearchText = string.Empty;
        private const int ItemsPerPage = 3;
        private int _currentPage = 1;
        private List<MENU> _currentItems;
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public decimal? WeightFrom { get; set; }
        public decimal? WeightTo { get; set; }
        public string SelectedType { get; set; }

        public SearchMenu()
        {
            InitializeComponent();
            _menuItems = _.GetContext().MENU.ToList();
            DataContext = this;
            _currentSearchText = string.Empty;
            _currentPage = 1;
            _currentItems = _menuItems.Take(ItemsPerPage).ToList();
            MenuItemsControl.ItemsSource = _currentItems;
            UpdatePageButtons(_menuItems.Count);
            DishTypes = new List<string> { "Салат", "Стейк", "Паста", "Ужин", "Боул", "Коктейль" };

        }

        private void LoadMenuItems()
        {
            try
            {
                _menuItems = _.GetContext().MENU.ToList();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки меню: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdatePageButtons(int totalFilteredItemsCount)
        {
            int totalPages = (int)Math.Ceiling((double)totalFilteredItemsCount / ItemsPerPage);
            CanGoPrevious = _currentPage > 1;
            CanGoNext = _currentPage < totalPages;
            CurrentPageText = $"{_currentPage} / {totalPages}";
        }

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                ApplyFilters();
            }
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            int totalFilteredItemsCount = _menuItems.Count(item =>
                (string.IsNullOrEmpty(_currentSearchText) || item.DishName.ToLower().Contains(_currentSearchText.ToLower())) &&
                (!PriceFrom.HasValue || item.DishPrice >= PriceFrom) &&
                (!PriceTo.HasValue || item.DishPrice <= PriceTo) &&
                (!WeightFrom.HasValue || item.DishWeight >= WeightFrom) &&
                (!WeightTo.HasValue || item.DishWeight <= WeightTo) &&
                (string.IsNullOrEmpty(SelectedType) || item.DishType.Equals(SelectedType, StringComparison.OrdinalIgnoreCase))
            );

            if (_currentPage < (int)Math.Ceiling((double)totalFilteredItemsCount / ItemsPerPage))
            {
                _currentPage++;
                ApplyFilters();
            }
        }



        private bool _canGoPrevious;
        public bool CanGoPrevious
        {
            get => _canGoPrevious;
            set
            {
                _canGoPrevious = value;
                OnPropertyChanged(nameof(CanGoPrevious));
            }
        }

        private bool _canGoNext;
        public bool CanGoNext
        {
            get => _canGoNext;
            set
            {
                _canGoNext = value;
                OnPropertyChanged(nameof(CanGoNext));
            }
        }

        private string _currentPageText;
        public string CurrentPageText
        {
            get => _currentPageText;
            set
            {
                _currentPageText = value;
                OnPropertyChanged(nameof(CurrentPageText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ApplyFilters()
        {
            var filteredItems = _menuItems
                .Where(item => (string.IsNullOrEmpty(_currentSearchText) || item.DishName.ToLower().Contains(_currentSearchText.ToLower())) &&
                               (!PriceFrom.HasValue || item.DishPrice >= PriceFrom) &&
                               (!PriceTo.HasValue || item.DishPrice <= PriceTo) &&
                               (!WeightFrom.HasValue || item.DishWeight >= WeightFrom) &&
                               (!WeightTo.HasValue || item.DishWeight <= WeightTo) &&
                               (string.IsNullOrEmpty(SelectedType) || item.DishType.Equals(SelectedType, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            _currentItems = filteredItems.Skip((_currentPage - 1) * ItemsPerPage).Take(ItemsPerPage).ToList();
            MenuItemsControl.ItemsSource = _currentItems;
            UpdatePageButtons(filteredItems.Count);
        }

        private void ApplyFilters(decimal? priceFrom = null, decimal? priceTo = null, decimal? weightFrom = null, decimal? weightTo = null, string selectedType = null)
        {
            // Удаляем пробелы в начале и конце строки поиска
            var searchLower = _currentSearchText?.Trim().ToLower() ?? string.Empty;

            // Сбрасываем номер страницы на 1 при каждом новом поиске или фильтрации
            _currentPage = 1;

            var filteredItems = _menuItems
                .Where(item =>
                    (string.IsNullOrEmpty(searchLower) ||
                     (item.DishName?.Trim().ToLower().Contains(searchLower) ?? false)) && // Очистка пробелов и регистр
                    (!priceFrom.HasValue || item.DishPrice >= priceFrom) &&
                    (!priceTo.HasValue || item.DishPrice <= priceTo) &&
                    (!weightFrom.HasValue || item.DishWeight >= weightFrom) &&
                    (!weightTo.HasValue || item.DishWeight <= weightTo) &&
                    (string.IsNullOrEmpty(selectedType) ||
                     (item.DishType?.Trim().Equals(selectedType, StringComparison.OrdinalIgnoreCase) ?? false)))
                .ToList();

            _currentItems = filteredItems.Skip((_currentPage - 1) * ItemsPerPage).Take(ItemsPerPage).ToList();
            MenuItemsControl.ItemsSource = _currentItems;

            // Обновляем кнопки пагинации
            UpdatePageButtons(filteredItems.Count);
        }



        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSearchText = SearchTextBox.Text.Trim();
            ApplyFilters();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _currentSearchText = SearchTextBox.Text.Trim();
            ApplyFilters();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal? priceFrom = ParseDecimal(PriceFromTextBox.Text);
                decimal? priceTo = ParseDecimal(PriceToTextBox.Text);
                decimal? weightFrom = ParseDecimal(WeightFromTextBox.Text);
                decimal? weightTo = ParseDecimal(WeightToTextBox.Text);
                string selectedType = (string)TypeComboBox.SelectedItem;

                if (priceFrom > priceTo)
                {
                    MessageBox.Show("Цена 'от' не может быть больше цены 'до'.", "Ошибка фильтрации", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (weightFrom > weightTo)
                {
                    MessageBox.Show("Вес 'от' не может быть больше веса 'до'.", "Ошибка фильтрации", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                ApplyFilters();

                ApplyFilters(priceFrom, priceTo, weightFrom, weightTo, selectedType);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при применении фильтров: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private decimal? ParseDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (decimal.TryParse(value, out var result))
                return result;

            throw new FormatException($"Некорректное числовое значение: '{value}'.");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PriceFromTextBox.Text))
                PriceFromTextBox.Text = string.Empty;

            if (!string.IsNullOrWhiteSpace(PriceToTextBox.Text))
                PriceToTextBox.Text = string.Empty;

            if (!string.IsNullOrWhiteSpace(WeightFromTextBox.Text))
                WeightFromTextBox.Text = string.Empty;

            if (!string.IsNullOrWhiteSpace(WeightToTextBox.Text))
                WeightToTextBox.Text = string.Empty;

            if (TypeComboBox.SelectedItem != null)
                TypeComboBox.SelectedItem = null;

            if (!string.IsNullOrWhiteSpace(SearchTextBox.Text))
                SearchTextBox.Text = string.Empty;

            _currentSearchText = string.Empty;
            _currentPage = 1;
            _currentItems = _menuItems.Take(ItemsPerPage).ToList();
            MenuItemsControl.ItemsSource = _currentItems;
            UpdatePageButtons(_menuItems.Count);
        }

        private List<string> _dishTypes;
        public List<string> DishTypes
        {
            get => _dishTypes;
            set
            {
                _dishTypes = value;
                OnPropertyChanged(nameof(DishTypes));
            }
        }



    }
}