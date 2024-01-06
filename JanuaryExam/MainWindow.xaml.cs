using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanuaryExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BudgetItem grant = new BudgetItem() { Name = "Grant", Amount = 300, Date = new DateTime(2024, 1, 5), Recurring = true };
            BudgetItem bonus = new BudgetItem() { Name = "Bonus", Amount = 300, Date = new DateTime(2024, 1, 15), Recurring = false };
            BudgetItem wages = new BudgetItem() { Name = "Wages", Amount = 100, Date = new DateTime(2024, 1, 25), Recurring = true };
            BudgetItem rent = new BudgetItem() { Name = "Rent", Amount = 400, Date = new DateTime(2024, 1, 1), Recurring = true };
            BudgetItem flight = new BudgetItem() { Name = "Flight", Amount = 100, Date = new DateTime(2024, 1, 5), Recurring = false };
            BudgetItem netflix = new BudgetItem() { Name = "Netflix", Amount = 10, Date = new DateTime(2024, 1, 15), Recurring = true };
            BudgetItem spotify = new BudgetItem() { Name = "Spotify", Amount = 8, Date = new DateTime(2024, 1, 20), Recurring = true };
        }
    }
}
