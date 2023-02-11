using OurBudgets.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OurBudgets.ViewModels
{
    public class SetExpenseViewModel : BindableBase, IDialogAware
    {
        IMessageService messageService;

        //自身のコンストラクターへインスタンス追加で渡す
        public SetExpenseViewModel() : this(new MessageService())
        {

        }

        public SetExpenseViewModel(IMessageService _messageService)
        {
            //コンボボックスに列挙型の文字列を入れておく
            Array dayOfWeekValues = Enum.GetValues(typeof(Models.Data.ExpenseKind));
            foreach (object value in dayOfWeekValues)
            {
                // フィールドのオブジェクトと数値（int）に変換した値を出力
                expenseKinds.Add(new ComboBoxViewModel((int)value, value.ToString()));
            }

            this.messageService = _messageService;
        }

        #region Field
        private string name;
        private string id;
        private string expenseVlue;
        private string destination;
        private ObservableCollection<ComboBoxViewModel> expenseKinds = new();
        #endregion

        #region Property
        /// <summary>
        /// ユーザ名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        /// <summary>
        /// ユーザID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
        /// <summary>
        /// 収入額
        /// </summary>
        public string ExpenseValue
        {
            get { return expenseVlue; }
            set { SetProperty(ref expenseVlue, value); }
        }
        /// <summary>
        /// 収入元
        /// </summary>
        public string Destination
        {
            get { return destination; }
            set { SetProperty(ref destination, value); }
        }
        /// <summary>
        /// コンボボックスリスト
        /// 中身はコンストラクターでインスタンス生成時に初期設定行う
        /// </summary>
        public ObservableCollection<ComboBoxViewModel> ExpenseKinds
        {
            get { return expenseKinds; }
            set { SetProperty(ref expenseKinds, value); }
        }
        #endregion

        #region DialogInterfaceMethods
        /// <summary>
        /// ダイアログクローズリクエスdelegate
        /// </summary>
        public event Action<IDialogResult> RequestClose;
        /// <summary>
        /// ダイアログタイトル
        /// </summary>
        public string Title => "入力";
        /// <summary>
        /// ダイアログクローズ判定
        /// </summary>
        /// <returns>trueでクローズ可能
        /// falseではクローズできない条件判定行う</returns>
        public bool CanCloseDialog()
        {
            return true;
        }
        /// <summary>
        /// ダイアログクローズ時処理
        /// </summary>
        public void OnDialogClosed()
        {
            //..
        }
        /// <summary>
        /// ダイアログ起動時処理
        /// </summary>
        /// <param name="parameters">ダイアログ起動時に受け取るパラメータ</param>
        public void OnDialogOpened(IDialogParameters parameters)
        {
            //..
        }
        #endregion
    }
}
