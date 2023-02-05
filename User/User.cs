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


        public void SendIncome(int userid, int income, Data.IncomeKind kind, string date, string source)
        {
            //
            //
            //
            //
        }

        public void SendExpense(int userid, int expense, Data.IncomeKind kind, string date, string destination)
        {
            //
            //
            //
            //
        }

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
