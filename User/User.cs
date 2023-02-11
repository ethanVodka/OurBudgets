using ControlzEx.Standard;
using OurBudgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace OurBudgets.User
{
    /// <summary>
    /// ユーザーモデル
    /// </summary>
    public class User
    {
        private int UserId { get; set; }
        private string UserName { get; set; }


        /// <summary>
        /// ユーザが入力した収入情報をサーバーへ送信
        /// </summary>
        /// <param name="userid">ユーザID</param>
        /// <param name="income">ン収入額</param>
        /// <param name="kind">収入種別</param>
        /// <param name="date">収入日付</param>
        /// <param name="source">収入元</param>
        public void SendIncome(int userid, int income, Data.IncomeKind kind, DateTime date, string source)
        {
            //
            //
            //
            //
        }

        /// <summary>
        /// ユーザが入力した支出情報をサーバーへ送信
        /// </summary>
        /// <param name="userid">ユーザID</param>
        /// <param name="expense">支出額</param>
        /// <param name="kind">支出種別</param>
        /// <param name="date">支出日付</param>
        /// <param name="destination">支出先</param>
        public void SendExpense(int userid, int expense, Data.IncomeKind kind, DateTime date, string destination)
        {
            //
            //
            //
            //
        }

        /// <summary>
        /// 予算額をサーバーから受け取る
        /// </summary>
        /// <param name="span">期間</param>
        /// <param name="outputType">出力種別</param>
        /// <returns></returns>
        public int GetBudget(Data.Span span, Data.OutputType outputType)
        {
            //
            //
            //
            //
            //
            return 0;
        }
    }
}
