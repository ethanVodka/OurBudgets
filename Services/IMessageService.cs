using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OurBudgets.Services
{
    /// <summary>
    /// メッセージ表示インターフェース
    /// </summary>
    public interface IMessageService
    {
        void ShowDialog(string message);
        MessageBoxResult Question(string message);
        MessageBoxResult Error(string message);
        MessageBoxResult Warning(string message);
    }
}
