using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    internal class BudgetItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public enum ItemType { Income, Expense }
        public DateTime Date { get; set; }
        public bool Recurring { get; set; }

        public BudgetItem() { }
    }
}
