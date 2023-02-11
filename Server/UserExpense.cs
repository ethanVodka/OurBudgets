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
        public UserExpense(int income, ExpenseKind kind, DateTime date, string destination)
        {
            Value = income;
            Kind = kind;
            Date = date;
            Destination = destination;
        }

        public ExpenseKind Kind { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Destination { get; set; }


        //Todayから引数であるSpanの区間での支出データならtrueをそうでなければfalseを出力
        public bool GetExpense(Span span)
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
    }
}
