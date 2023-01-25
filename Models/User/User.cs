using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OurBudgets.Models.User
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private string? _userName;
        private string? _userId;

        /// <summary>
        /// ユーザーIDメンバー
        /// </summary>
        public string? UserId 
        {
            get { return _userId; }
            set { _userId= value; OnPropertyChanged(nameof(UserId)); }
            
        }

        /// <summary>
        /// ユーザ名メンバー
        /// </summary>
        public string? UserName 
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(nameof(UserName)); }
        }

        /// <summary>
        /// 収入データ格納
        /// </summary>
        /// <exception cref="InvalidOperationException">データエラー</exception>
        public void SetIncome()
        {
            if (_userId != null && _userName != null)
            {
                //
                //do something
                //
            }
            else
            {
                throw new InvalidOperationException("please input user information");
            }
        }

        /// <summary>
        /// 支出データ格納
        /// </summary>
        /// <exception cref="InvalidOperationException">データエラー</exception>
        public void SetExpense()
        {
            if (_userId != null && _userName != null)
            {
                //
                //do something
                //
            }
            else
            {
                throw new InvalidOperationException("please input user information");
            }
        }

        /// <summary>
        /// 予算データ取得
        /// </summary>
        /// <exception cref="InvalidOperationException">データエラー</exception>
        public void GetBudget()
        {
            if (_userId != null && _userName != null)
            {
                //
                //do something
                //
            }
            else
            {
                throw new InvalidOperationException("please input user information");
            }
        }
    }
}
