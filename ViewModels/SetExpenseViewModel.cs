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
        readonly IMessageService messageService;

        //自身のコンストラクターへインスタンス追加で渡す
        public SetExpenseViewModel() : this(new MessageService())
        {
            ExpenseKindSelectionChanged = new DelegateCommand<object[]>(ExpenseKindSelectionChangeExcute);
            OKButtonClick = new DelegateCommand(OKButtonClickExcute);
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
        private string selectedText = "--";
        private ComboBoxViewModel selectedExpenseKind = null;
        private DateTime date;
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
        /// <summary>
        /// コンボボックス選択種別表示テキスト
        /// </summary>
        public string SelectedText
        {
            get { return selectedText; }
            set { SetProperty(ref selectedText, value); }
        }
        public ComboBoxViewModel SelectedExpenseKind
        {
            get { return selectedExpenseKind; }
            set { SetProperty(ref selectedExpenseKind, value); }
        }
        /// <summary>
        /// 日付取得
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        //Delegate
        public DelegateCommand<object[]> ExpenseKindSelectionChanged { get; }
        public DelegateCommand OKButtonClick { get; }
        #endregion

        /// <summary>
        /// コンボボックス選択変更処理
        /// </summary>
        /// <param name="selectItems">選択されたコンボボックスパラメータ</param>
        private void ExpenseKindSelectionChangeExcute(object[] selectItems)
        {
            try
            {
                ComboBoxViewModel selectedKind = selectItems[0] as ComboBoxViewModel;
                SelectedText = selectedKind.Value + " : " + selectedKind.DisplayValue;
            }
            catch (Exception e)
            {
                messageService.Error(e.Message);
            }
        }

        private void OKButtonClickExcute()
        {
            try
            {
                if (CheckInputExpenseData())
                {
                    if (messageService.Question("入力情報送信いたします\nよろしいですか？") == System.Windows.MessageBoxResult.OK)
                    {
                        RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
                    }
                    else
                    {
                        //入力に戻る
                    }
                }
            }
            catch (Exception e)
            {
                messageService.Error(e.Message);
            }
        }

        private bool CheckInputExpenseData()
        {
            try
            {
                //金額入力確認
                if (ExpenseValue == null)
                {
                    messageService.Information("金額を入力してください");
                    return false;
                }
                else
                {
                    if (!int.TryParse(ExpenseValue, out int value))
                    {
                        messageService.Information("金額は半角数字で入力してください");
                        return false;
                    }
                }
                //収入源入力確認
                if (Destination == null)
                {
                    messageService.Information("支出先を入力してください");
                    return false;
                }
                //収入種別入力確認
                if (SelectedExpenseKind == null)
                {
                    messageService.Information("支出種別を選択してください");
                    return false;
                }
                //名前入力確認
                if (Name == null)
                {
                    messageService.Information("名前を入力してください");
                    return false;
                }
                //ID入力確認
                if (Id == null)
                {
                    messageService.Information("IDを入力してください");
                    return false;
                }
                else
                {
                    if (!int.TryParse(Id, out int id))
                    {
                        messageService.Information("IDは半角数字で入力してください");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                messageService.Error(e.Message);
                return false;
            }
        }

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
