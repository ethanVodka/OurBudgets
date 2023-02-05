using OurBudgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OurBudgets.Models.Data;

namespace OurBudgets.Server
{
    public class UserBudget
    {
        private List<UserIncome> UserIncomes { get; set; }

        private List<UserExpense> UserExpenses { get; set; }

        private int UserId { get; set; }
        private string UserName { get; set; }


        public void SetUserIncome(int income, Data.IncomeKind kind, string date, string source)
        {
            //
            //
            //
            //
            //
        }

        public void SetUserExpense(int expense, Data.IncomeKind kind, string date, string destination)
        {
            //
            //
            //
            //
            //
        }

        //一定期間のデータ取得
        public void LoadBudget(Data.Span span)
        {
            //
            //
            //
            //
            //
        }
    }
}
