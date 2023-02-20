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

        //初期化として収入情報リストUserIncomes、支出情報リストUserExpenseを宣言
        public UserBudget()
        {
            var UserIncomes = new List<UserIncome>();
            var UserExpenses = new List<UserExpense>();
        }


        //新しい収入情報をUserIncomesリストに追加
        public void SetUserIncome(int income, Data.IncomeKind kind, DateTime date, string source)
        {
            UserIncome hoge = new UserIncome(income, kind, date, source);
            UserIncomes.Add(hoge);
        }
        //新しい支出情報をUserExpnseリストに追加
        public void SetUserExpense(int expense, Data.ExpenseKind kind, DateTime date, string payee)
        {
            UserExpense hoge = new UserExpense(expense, kind, date, payee);
            UserExpenses.Add(hoge);
        }

        //一定期間のデータ取得
        public int LoadBudget(Data.Span span)
        {
            //インスタンスの宣言
            var spanIncomes = new List<UserIncome>();//探索範囲内の収入情報を格納するリスト
            var spanExpenses = new List<UserExpense>();//探索範囲内の支出情報を格納するリスト
            int sumIncome = 0;                      //収入の合計値
            int sumExpense = 0;                     //支出の合計値
            int result = 0;                         //収支の合計値


            //関数GetIncomeを使って期間内のインスタンスをspanIncomesに格納しその要素ValueをsumIncomeに加算
            spanIncomes = UserIncomes.FindAll(n => n.GetIncome(span));  
            spanIncomes.ForEach(n =>
            {
                sumIncome += n.GetValue();
            });

            //関数GetExpenseを使って期間内のインスタンスをspanExpensesに格納しその要素ValueをsumExpenseに加算
            spanExpenses = UserExpenses.FindAll(n => n.GetExpense(span));
            spanExpenses.ForEach(n =>
            {
                sumExpense += n.GetValue();
            });

            result = sumIncome - sumExpense;            //算出した収支それぞれの合計から期間内の収支を計算
            return result;

        }
    }
}
