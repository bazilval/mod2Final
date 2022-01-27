using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mod2Final.Model;

namespace mod2Final.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        // Свойство, хранящее состояние поля ввода
        private string field;
        public string Field
        {
            get => field;
            set
            {
                field = value;
                OnPropertyChanged();
            }
        }

        // Свойство, хранящее состояние строки с операцией
        private string operationField;
        public string OperationField
        {
            get => operationField;
            set
            {
                operationField = value;
                OnPropertyChanged();
            }
        }

        // Свойство, хранящее первый операнд
        private double operand1;
        public double Operand1
        {
            get => operand1;
            set
            {
                operand1 = value;
                OnPropertyChanged();
            }
        }

        // Свойство, хранящее второй операнд
        private double operand2;
        public double Operand2
        {
            get => operand2;
            set
            {
                operand2 = value;
                OnPropertyChanged();
            }
        }

        // Перечисление для типов операций
        public enum Operations
        {
            Empty, Plus, Minus, Divide, Multiply
        }

        // Свойство, хранящее текущую операцию
        private Operations operation;
        public Operations Operation
        {
            get => operation;
            set
            {
                operation = value;
                OnPropertyChanged();
            }
        }

        // Инициация команд для ввода значений в поле


        // Инициация команд для расчёта

        public ICommand PlusOperationButton { get; }
        private void OnPlusOperationButtonExecute(object p)
        {
            Calculator.Input(Operations.Plus);
        }

        public ICommand MinusOperationButton { get; }
        private void OnMinusOperationButtonExecute(object p)
        {
            Calculator.Input(Operations.Minus);
        }

        public ICommand DivideOperationButton { get; }
        private void OnDivideOperationButtonExecute(object p)
        {
            Calculator.Input(Operations.Divide);
        }

        public ICommand MultiplyOperationButton { get; }
        private void OnMultiplyOperationButtonExecute(object p)
        {
            Calculator.Input(Operations.Multiply);
        }

        public ICommand BackspaceButton { get; }
        private void OnBackspaceButtonExecute(object p)
        {
            Calculator.Backspace();
        }

        public ICommand ClearButton { get; }
        private void OnClearButtonExecute(object p)
        {
            Calculator.Clear();
        }

        public ICommand CleanEntryButton { get; }
        private void OnCleanEntryButtonExecute(object p)
        {
            Calculator.CleanEntry();
        }

        public ICommand ChangeSignButton { get; }
        private void OnChangeSignButtonExecute(object p)
        {
            Calculator.ChangeSign();
        }

        public ICommand CommaButton { get; }
        private void OnCommaButtonExecute(object p)
        {
            Calculator.Comma();
        }

        public ICommand CalculateButton { get; }
        private void OnCalculateButtonExecute(object p)
        {
            Calculator.Calculate();
        }

        private bool AlwaysCanExecute(object p) => true;

        // Конструктор окна
        public MainWindowViewModel()
        {
            PlusOperationButton = new RelyCommand(OnPlusOperationButtonExecute, AlwaysCanExecute);
            PlusOperationButton = new RelyCommand(OnMinusOperationButtonExecute, AlwaysCanExecute);
            PlusOperationButton = new RelyCommand(OnDivideOperationButtonExecute, AlwaysCanExecute);
            PlusOperationButton = new RelyCommand(OnMultiplyOperationButtonExecute, AlwaysCanExecute);
            PlusOperationButton = new RelyCommand(OnBackspaceButtonExecute, AlwaysCanExecute);
            ClearButton = new RelyCommand(OnClearButtonExecute, AlwaysCanExecute);
            CleanEntryButton = new RelyCommand(OnCleanEntryButtonExecute, AlwaysCanExecute);
            ChangeSignButton = new RelyCommand(OnChangeSignButtonExecute, AlwaysCanExecute);
            CommaButton = new RelyCommand(OnCommaButtonExecute, AlwaysCanExecute);
            CalculateButton = new RelyCommand(OnCalculateButtonExecute, AlwaysCanExecute);
        }
    }
}
