using OurBudgets.Models;
using OurBudgets.Repositorys;
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
            ShowSettingBudgetView = new DelegateCommand(ShowSettingBudgetViewExecute);

            //...........
            //メインウィンドウ呼び出し時処理
            //
            //画面表示データ取得
            //ユーザ情報、予算、予算から残高計算,,,,
            //...........
        }

        //タイトルプロパティ
        private string _title = "OUR BUDGETS";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        //残高プロパティ
        private string balance = "1900000";

        public string Balance
        {
            get => balance;
            set => SetProperty(ref balance, value);
        }

        //予算プロパティ
        private string budget = "1000000";

        public string Budget
        {
            get => budget;
            set => SetProperty(ref budget, value);
        }

        public DelegateCommand ShowSettingBudgetView { get; }

        private void ShowSettingBudgetViewExecute()
        {
            //...........
            //予算設定view 呼び出し処理
            //Viewまだ作成してない
            //...........
        }

    }
}
