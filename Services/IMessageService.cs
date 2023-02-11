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
        public void ShowDialog(string message);
        public MessageBoxResult Information(string message);
        public MessageBoxResult Question(string message);
        public MessageBoxResult Error(string message);
        public MessageBoxResult Warning(string message);
    }
}
