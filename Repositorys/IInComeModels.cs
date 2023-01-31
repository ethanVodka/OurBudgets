using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Repositorys
{
    public partial interface IInComeModels<T>
    {
        T GetIncome(int id);
    
        List<T> GetIncomes(int id);
    }
}
