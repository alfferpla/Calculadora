using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculadora.MVVM.ViewModels
{
    public class CalcViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";
        public ICommand OperationCommand =>
            new Command((number) => { Formula += number; });
    }
}
