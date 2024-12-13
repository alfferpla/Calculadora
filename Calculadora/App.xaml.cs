using Calculadora.MVVM;

namespace Calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcView();
        }
    }
}
