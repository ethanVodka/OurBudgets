using OurBudgets.Models.Servers.DataManagements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models.Servers
{
    public class UserBudget
    {

        //フィールド
        private string? _userId;
        private string? _userName;
        private List<UserIncome> _userIncomes;
        private List<UserExpense> _userExpenses;

        /// <summary>
        /// コンストラクター
        /// </summary>
        private UserBudget()
        {
            _userIncomes = new List<UserIncome>();
            _userExpenses = new List<UserExpense>();
        }

        /// <summary>
        /// ユーザーID
        /// </summary>
        public string? UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        /// ユーザー名
        /// </summary>
        public string? UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// ユーザ収入データ
        /// </summary>
        public List<UserIncome> UseIncomes
        {
            get { return _userIncomes; }
            set { _userIncomes = value; }
        }

        /// <summary>
        /// ユーザ支出データ
        /// </summary>
        public List<UserExpense> UserExpenses
        {
            get { return _userExpenses; }
            set { _userExpenses = value; }
        }

        public void SetUserIncome(UserIncome income)
        {
            if (income != null)
            {
                UseIncomes.Add(income);
            }
            else
            {
                throw new InvalidOperationException("failed to set income data");
            }
        }

        public void SetUserExpense(UserExpense expense)
        {
            if (expense != null)
            {
                UserExpenses.Add(expense);
            }
            else 
            { 
                throw new InvalidOperationException("failed to set expense data");
            }
        }

        public void LoadBudget()
        {
            //
            //do something
            //
        }

    }
}
