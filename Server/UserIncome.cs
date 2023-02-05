using OurBudgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OurBudgets.Models.Data;

namespace OurBudgets.Server
{
    public class UserIncome
    {
        public UserIncome(int income, IncomeKind kind, DateTime date, string source)
        {

            //コンストラクター

        }


        public IncomeKind Kind { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; }     
        

        //複数収入取得
        public bool GetIncome(Data.Span span)
        {
            return true;
        }
    }
}
