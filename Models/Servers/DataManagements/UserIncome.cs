using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models.Servers.DataManagements
{
    public class UserIncome
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        public UserIncome()
        {
            //
            //do something
            //
        }

        private string? _incomeDate;
        private int? _incomeValue;
        private string? _incomeKind;

        /// <summary>
        /// 収入日付
        /// </summary>
        public string? IncomeDate
        {
            get { return _incomeDate; }
            set { _incomeDate = value; }
        }

        /// <summary>
        /// 収入金額
        /// </summary>
        public int? IncomeValue
        {
            get { return _incomeValue; }
            set { _incomeValue = value; }
        }

        /// <summary>
        /// 収入種別
        /// </summary>
        public string? IncomeKind
        {
            get { return _incomeKind; }
            set { _incomeKind = value; }
        }

        /// <summary>
        /// 収入情報をサーバのUserBudgetへ送信
        /// </summary>
        /// <exception cref="InvalidOperationException">収入データエラー</exception>
        public void SendIncome()
        {
            if (_incomeDate != null && _incomeValue != null && _incomeKind != null)
            {
                //
                //do something
                //
            }
            else
            {
                throw new InvalidOperationException("income data error");
            }
        }
    }
}
