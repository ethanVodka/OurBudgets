using OurBudgets.Models;
using OurBudgets.Repositorys;
using Prism.Mvvm;
using System.Collections.Generic;

namespace OurBudgets.ViewModels
{
    public class MainWindowViewModel : BindableBase, IExpenseModels<Expense>
    {
        public MainWindowViewModel()
        {

        }

        //タイトルプロパティ
        private string _title = "OUR BUDGETS";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        //残高プロパティ
        private int balance;

        public int Balance 
        { 
            get => balance; 
            set => SetProperty(ref balance, value);
        }

        //予算プロパティ
        private int budget;

        public int Budget 
        { 
            get => budget; 
            set => SetProperty(ref budget, value); 
        }

        public Expense GetExpense(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Expense> GetExpenses(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
