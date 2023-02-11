using OurBudgets.Services;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OurBudgets.ViewModels
{
    public class SetIncomeViewModel : BindableBase, IDialogAware
    {
        IMessageService messageService;

        //自身のコンストラクターへインスタンス追加で渡す
        public SetIncomeViewModel() : this(new MessageService())
        {

        }

        public SetIncomeViewModel(IMessageService _messageService)
        {
            //コンボボックスに列挙型の文字列を入れておく
            Array dayOfWeekValues = Enum.GetValues(typeof(Models.Data.IncomeKind));
            foreach (object value in dayOfWeekValues)
            {
                // フィールドのオブジェクトと数値（int）に変換した値を出力
                incomeKinds.Add(new ComboBoxViewModel((int)value, value.ToString()));
            }

            this.messageService = _messageService;
        }

        #region Field
        private string name;
        private string id;
        private string incomeVlue;
        private string source;
        private ObservableCollection<ComboBoxViewModel> incomeKinds = new();
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
        public string IncomeValue
        {
            get { return incomeVlue; }
            set { SetProperty(ref incomeVlue, value); }
        }
        /// <summary>
        /// 収入元
        /// </summary>
        public string Source
        {
            get { return source; }
            set { SetProperty(ref source, value); }
        }
        /// <summary>
        /// コンボボックスリスト
        /// 中身はコンストラクターでインスタンス生成時に初期設定行う
        /// </summary>
        public ObservableCollection<ComboBoxViewModel> IncomeKinds
        {
            get { return incomeKinds; }
            set { SetProperty(ref incomeKinds, value); }
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
