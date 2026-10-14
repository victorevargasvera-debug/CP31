namespace SpecialFeatures.Utilities
{
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private readonly Action<object> a;
        private readonly Predicate<object> b;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute);
        public RelayCommand(Action<object> execute, Predicate<object> canExecute);
        public bool CanExecute(object parameter);
        public void Execute(object parameter);
    }
}

