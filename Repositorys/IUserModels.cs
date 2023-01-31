using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurBudgets.Repositorys
{
    // ユーザインターフェース
    public interface IUserModels<T>
    {
        int GetUserId();
        void SetBuget(T value);
        void SetIncome(T income);
        void SetExpense(T expense);
    }
}
