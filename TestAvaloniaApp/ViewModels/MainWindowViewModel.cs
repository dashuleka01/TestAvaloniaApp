using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TestAvaloniaApp.Models;

namespace TestAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public string Greeting => "Welcome to Avalonia!";

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _number1;
        public int Number1
        {
            get { return 5; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number3"); // уведомление View о том, что изменилась сумма
            }
        }

        private int _number2;
        public int Number2
        {
            get { return 6; }
            set { _number1 = value; OnPropertyChanged("Number3"); }
        }

        public int Number3 { get => MathFuncs.GetSumOf(Number1, Number2); }
    }
}
