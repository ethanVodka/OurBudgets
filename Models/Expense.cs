using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models
{
    public partial class Expense
    {
        public enum ExpenseType
        {
            Undefine,
            Loarn,
            DailyUse,
            Rent,
            Utility,
            Food,
            Housing,
            Phone,
            TransPort,
            Cloth,
            Social,
            Education,
            Save,
            Hobbies
        }

        public ExpenseType Kind { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Destination { get; set; }
    }
}
