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
            return MessageBox.Show($"Question: {message}", "確認", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
        public MessageBoxResult Warning(string message)
        {
            return MessageBox.Show($"Warning: {message}", "警告", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }
        public MessageBoxResult Error(string message)
        {
            return MessageBox.Show($"Error: {message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void ShowDialog(string message)
        {
            MessageBox.Show(message);
        }
    }
}
