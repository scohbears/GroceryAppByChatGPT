using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GroceryApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<GroceryItem> _groceryList = new ObservableCollection<GroceryItem>();
        public ObservableCollection<GroceryItem> GroceryList
        {
            get => _groceryList;
            set
            {
                _groceryList = value;
                OnPropertyChanged(nameof(GroceryList));
            }
        }

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        public MainViewModel()
        {
            AddCommand = new CustomCommand(AddItem);
            RemoveCommand = new CustomCommand(RemoveItem);
        }

        private void AddItem(object parameter)
        {
            // Add your logic to add a new item to the grocery list
            GroceryList.Add(new GroceryItem());
        }

        private void RemoveItem(object parameter)
        {
            // Add your logic to remove an item from the grocery list
            if (GroceryList.Count > 0)
            {
                GroceryList.RemoveAt(GroceryList.Count - 1);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CustomCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public CustomCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
