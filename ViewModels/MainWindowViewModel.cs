using OurBudgets.Models;
using OurBudgets.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Collections.Generic;

namespace OurBudgets.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {       
        private readonly IDialogService dialogService;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="_regionManager">MainViewのResion</param>
        public MainWindowViewModel(IDialogService _dialogService)
        {
            //...........
            //メインウィンドウ呼び出し時処理
            //...........
            dialogService= _dialogService;
            
            ShowSetIncomeView = new DelegateCommand(ShowSetIncomeViewExecute);
            ShowSetExpenseView =new DelegateCommand(ShowSetExpenseViewExcute);
            ShowUserBudgetsView = new DelegateCommand(ShowUserBudgetsViewExcute);
        }

        #region DefineDelegateCommand
        public DelegateCommand ShowSetIncomeView { get; }
        public DelegateCommand ShowSetExpenseView { get; }
        public DelegateCommand ShowUserBudgetsView { get; }
        #endregion

        #region DefineExecute
        //収入入力View
        private void ShowSetIncomeViewExecute()
        {
            dialogService.ShowDialog(nameof(SetIncomeView), null, null);
        }
        //支出入力View
        private void ShowSetExpenseViewExcute()
        {

        }
        //収支情報表示View
        private void ShowUserBudgetsViewExcute()
        {

        }
        #endregion
    }
}
