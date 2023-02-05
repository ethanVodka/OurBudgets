using OurBudgets.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;

namespace OurBudgets.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager _regionManager)
        {
            regionManager = _regionManager;
            ShowIncomeView = new DelegateCommand(ShowIncomeViewExecute);
            ShowExpenseView =new DelegateCommand(ShowExpenseViewExcute);

            //...........
            //メインウィンドウ呼び出し時処理
            //...........
        }


        public DelegateCommand ShowIncomeView { get; }
        public DelegateCommand ShowExpenseView { get; }

        private void ShowIncomeViewExecute()
        {

        }

        private void ShowExpenseViewExcute()
        {

        }

    }
}
