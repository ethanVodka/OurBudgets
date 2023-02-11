using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OurBudgets.Services
{
    /// <summary>
    /// メッセージ表示クラス
    /// </summary>
    public class MessageService : IMessageService
    {
        public MessageBoxResult Question(string message)
        {
            return MessageBox.Show($"Question:\n\n{message}", "確認", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
        public MessageBoxResult Information(string message)
        {
            return MessageBox.Show($"Information:\n\n{message}","インフォーメーション", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public MessageBoxResult Warning(string message)
        {
            return MessageBox.Show($"Warning:\n\n{message}", "警告", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }
        public MessageBoxResult Error(string message)
        {
            return MessageBox.Show($"Error:\n\n{message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void ShowDialog(string message)
        {
            MessageBox.Show(message);
        }
    }
}
