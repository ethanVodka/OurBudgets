using OurBudgets.Models;
using OurBudgets.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Server
{
    public class Server
    {
        private List<UserBudget> userBudgets { get; set; }

        public void SendUserBudget(int userId, DateTime date)
        {
            //
            //
            //
            //
            //
        }
        public void RecieveUserIncome(int userid, int income, Data.IncomeKind kind, string date, string source)
        {
            //
            //
            //
            //
            //
        }


        public void RecieveUserExpense(int userid, int expense, Data.IncomeKind kind, string date, string destination)
        {
            //
            //
            //
            //
            //
        }
    }
}
