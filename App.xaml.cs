using OurBudgets.ViewModels;
using OurBudgets.Views;
using Prism.Ioc;
using System.Windows;

namespace OurBudgets
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<SetIncomeView, SetIncomeViewModel>();
        }
    }
}
