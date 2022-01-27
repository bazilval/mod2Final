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

        public ICommand OneButton { get; }
        private void OnOneButtonExecute(object p)
        {
            Calculator.InputSymbol("1");
        }

        public ICommand TwoButton { get; }
        private void OnTwoButtonExecute(object p)
        {
            Calculator.InputSymbol("2");
        }

        public ICommand ThreeButton { get; }
        private void OnThreeButtonExecute(object p)
        {
            Calculator.InputSymbol("3");
        }

        public ICommand FourButton { get; }
        private void OnFourButtonExecute(object p)
        {
            Calculator.InputSymbol("4");
        }

        public ICommand FiveButton { get; }
        private void OnFiveButtonExecute(object p)
        {
            Calculator.InputSymbol("5");
        }

        public ICommand SixButton { get; }
        private void OnSixButtonExecute(object p)
        {
            Calculator.InputSymbol("6");
        }

        public ICommand SevenButton { get; }
        private void OnSevenButtonExecute(object p)
        {
            Calculator.InputSymbol("7");
        }

        public ICommand EightButton { get; }
        private void OnEightButtonExecute(object p)
        {
            Calculator.InputSymbol("8");
        }

        public ICommand NineButton { get; }
        private void OnNineButtonExecute(object p)
        {
            Calculator.InputSymbol("9");
        }

        public ICommand ZeroButton { get; }
        private void OnZeroButtonExecute(object p)
        {
            Calculator.InputSymbol("0");
        }

        public ICommand CommaButton { get; }
        private void OnCommaButtonExecute(object p)
        {
            Calculator.InputSymbol(",");
        }

        // Инициация команд для расчёта

        public ICommand PlusButton { get; }
        private void OnPlusButtonExecute(object p)
        {
            Calculator.Input(Operations.Plus);
        }

        public ICommand MinusButton { get; }
        private void OnMinusButtonExecute(object p)
        {
            Calculator.Input(Operations.Minus);
        }

        public ICommand DivideButton { get; }
        private void OnDivideButtonExecute(object p)
        {
            Calculator.Input(Operations.Divide);
        }

        public ICommand MultiplyButton { get; }
        private void OnMultiplyButtonExecute(object p)
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


        public ICommand CalculateButton { get; }
        private void OnCalculateButtonExecute(object p)
        {
            Calculator.Calculate();
        }


        // Конструктор окна
        public MainWindowViewModel()
        {
            OneButton = new RelyCommand(OnOneButtonExecute);
            TwoButton = new RelyCommand(OnTwoButtonExecute);
            ThreeButton = new RelyCommand(OnThreeButtonExecute);
            FourButton = new RelyCommand(OnFourButtonExecute);
            FiveButton = new RelyCommand(OnFiveButtonExecute);
            SixButton = new RelyCommand(OnSixButtonExecute);
            SevenButton = new RelyCommand(OnSevenButtonExecute);
            EightButton = new RelyCommand(OnEightButtonExecute);
            NineButton = new RelyCommand(OnNineButtonExecute);
            ZeroButton = new RelyCommand(OnZeroButtonExecute);

            PlusButton = new RelyCommand(OnPlusButtonExecute);
            PlusButton = new RelyCommand(OnMinusButtonExecute);
            PlusButton = new RelyCommand(OnDivideButtonExecute);
            PlusButton = new RelyCommand(OnMultiplyButtonExecute);
            PlusButton = new RelyCommand(OnBackspaceButtonExecute);
            ClearButton = new RelyCommand(OnClearButtonExecute);
            CleanEntryButton = new RelyCommand(OnCleanEntryButtonExecute);
            ChangeSignButton = new RelyCommand(OnChangeSignButtonExecute);
            CommaButton = new RelyCommand(OnCommaButtonExecute);
            CalculateButton = new RelyCommand(OnCalculateButtonExecute);
        }
    }
}
