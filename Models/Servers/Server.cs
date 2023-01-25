using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OurBudgets.Models.Servers
{
    public class Server : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private UserBudget? _userBudget;
        /// <summary>
        /// ユーザ予算データ
        /// </summary>
        public UserBudget? UserBudget
        {
            get { return _userBudget; }
            set { _userBudget = value; OnPropertyChanged(nameof(UserBudget)); }
        }

        public void GetUserBudget()
        {
            //
            //do something
            //
        }
    }
}
