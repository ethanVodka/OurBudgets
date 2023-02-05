using OurBudgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using static OurBudgets.Models.Data;

namespace OurBudgets.Server
{
    public class UserExpense
    {
        public UserExpense(int income, ExpenseKind kind, DateTime date, string desination) 
        {
            
            //コンストラクター

        }   

        public ExpenseKind Kind { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Destination { get; set; }


        //複数支出取得
        public bool GetExpense(Data.Span span)
        {
            return true;
        }
    }
}
