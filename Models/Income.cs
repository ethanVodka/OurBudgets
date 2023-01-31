using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Models
{
    public partial class Income
    {
        public enum IncomeType 
        {
            Undefine,
            Payee,
            Send
        }

        public IncomeType Kind { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; }
    }
}
