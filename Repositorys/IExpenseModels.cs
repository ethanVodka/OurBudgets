using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Repositorys
{
    public partial interface IExpenseModels<T>
    {
        T GetExpense(int id);

        List<T> GetExpenses(int id);
    }
}
