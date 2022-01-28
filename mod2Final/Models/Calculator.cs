using mod2Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2Final.Model
{
    public static class Calculator
    {
        internal static string Calculate(double operand1, double operand2, MainWindowViewModel.Operations operation)
        {
            switch (operation)
            {
                case MainWindowViewModel.Operations.Empty:
                    return "";
                case MainWindowViewModel.Operations.Plus:
                    return $"{operand1 + operand2}";
                case MainWindowViewModel.Operations.Minus:
                    return $"{operand1 - operand2}";
                case MainWindowViewModel.Operations.Divide:
                    if (operand2 == 0)
                    {
                        return "Нельзя";
                    }
                    return $"{operand1 / operand2}";
                case MainWindowViewModel.Operations.Multiply:
                    return $"{operand1 * operand2}";
                default:
                    break;
            }
            return "";
        }
    }
}
