using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models
{
    public class Data
    {
        public enum IncomeKind
        {
            Undefine,
            Payee,
            Send
        }

        public enum ExpenseKind
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

        public enum Span
        {
            Week,
            Month,
            Year
        }

        public enum OutputType
        {
            Graoh,
            Text,
            DataGrid
        }
    }
}
