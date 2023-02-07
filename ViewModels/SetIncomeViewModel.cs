using ControlzEx.Standard;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OurBudgets.ViewModels
{
    public class SetIncomeViewModel : BindableBase, IDialogAware
    {
        public SetIncomeViewModel()
        {
            //コンボボックスに列挙型の文字列を入れておく
            foreach (Models.Data.IncomeKind kind in Enum.GetValues(typeof(Models.Data.IncomeKind)))
            {
                // 列挙型データバインド行う
                kinds.Add(kind.ToString());
            }
        }

        private string name;
        private string id;
        private string expensevVlue;
        private string source;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }


        public string ExpenseValue
        {
            get { return expensevVlue; }
            set { SetProperty(ref expensevVlue, value); }
        }


        public string Source
        {
            get { return source; }
            set { SetProperty(ref source, value); }
        }


        //コンボボックスデータバインド
        private ObservableCollection<string> kinds = new();


        public ObservableCollection<string> Kinds
        {
            get { return kinds; }
            set { SetProperty(ref kinds, value); }
        }

        //popupViewインターフェース
        public event Action<IDialogResult> RequestClose;
        public string Title => "入力";
        public bool CanCloseDialog()
        {
            return true;
        }
        public void OnDialogClosed()
        {
            //..
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            //..
        }
    }
}
