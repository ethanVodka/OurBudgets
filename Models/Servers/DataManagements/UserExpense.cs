using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models.Servers.DataManagements
{
    public class UserExpense
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        public UserExpense() 
        {
            //
            //do something
            //
        }

        private string? _expenxeDate;
        private int? _expenseValue;
        private string? _expenseKind;

        /// <summary>
        /// 収入日付
        /// </summary>
        public string? ExpenseDate
        {
            get { return _expenxeDate; }
            set { _expenxeDate = value; }
        }

        /// <summary>
        /// 収入金額
        /// </summary>
        public int? ExpenseValue
        {
            get { return _expenseValue; }
            set { _expenseValue = value; }
        }

        /// <summary>
        /// 収入種別
        /// </summary>
        public string? ExpenseKind
        {
            get { return _expenseKind; }
            set { _expenseKind = value; }
        }

        /// <summary>
        /// 支出情報をサーバのUserBudgetへ送信
        /// </summary>
        /// <exception cref="InvalidOperationException">支出データエラー</exception>
        public void SendExpense()
        {
            if (_expenxeDate != null && _expenseValue != null && _expenseKind != null)
            {
                //
                //do something
                //
            }
            else
            {
                throw new InvalidOperationException("expense data error");
            }
        }
    }
}
