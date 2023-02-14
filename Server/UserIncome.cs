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
            Value = income;
            Kind = kind;
            Date = date;
            Source = source;
        }


        private IncomeKind Kind { get; set; }
        private int Value { get; set; }
        private DateTime Date { get; set; }
        private string Source { get; set; }     
        

        //複数収入取得
        public bool GetIncome(Data.Span span)
        {
            DateTime tmp = DateTime.Today;

            switch (span)
            {
                case Span.Week:
                    if (Date >= tmp.AddDays(-7))
                        return true;
                    break;

                case Span.Month:
                    if (Date >= tmp.AddMonths(-1))
                        return true;
                    break;

                case Span.Year:
                    if (Date >= tmp.AddYears(-1))
                        return true;
                    break;
            }

            return false;
        }

        public int GetValue()
        {
            return Value;
        }

        public IncomeKind GetKind()
        {
            return Kind;
        }

        public DateTime GetDate()
        {
            return Date;
        }

        public string GetSource()
        {
            return Source;
        }
    }
}
