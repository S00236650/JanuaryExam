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
            lbxIncome.Items.Add(grant.Date.Day.ToString() + " : " + grant.Name + " " + grant.Amount.ToString() + " - (Reccuring)");
            BudgetItem bonus = new BudgetItem() { Name = "Bonus", Amount = 300, Date = new DateTime(2024, 1, 15), Recurring = false };
            lbxIncome.Items.Add(bonus.Date.Day.ToString() + " : " + bonus.Name + " " + bonus.Amount.ToString() + " - (One Off)");
            BudgetItem wages = new BudgetItem() { Name = "Wages", Amount = 100, Date = new DateTime(2024, 1, 25), Recurring = true };
            lbxIncome.Items.Add(wages.Date.Day.ToString() + " : " + wages.Name + " " + wages.Amount.ToString() + " - (Reccuring)");
            BudgetItem rent = new BudgetItem() { Name = "Rent", Amount = 400, Date = new DateTime(2024, 1, 1), Recurring = true };
            lbxExpense.Items.Add(rent.Date.Day.ToString() + " : " + rent.Name + " " + rent.Amount.ToString() + " - (Reccuring)");
            BudgetItem flight = new BudgetItem() { Name = "Flight", Amount = 100, Date = new DateTime(2024, 1, 5), Recurring = false };
            lbxExpense.Items.Add(flight.Date.Day.ToString() + " : " + flight.Name + " " + flight.Amount.ToString() + " - (Reccuring)");
            BudgetItem netflix = new BudgetItem() { Name = "Netflix", Amount = 10, Date = new DateTime(2024, 1, 15), Recurring = true };
            lbxExpense.Items.Add(netflix.Date.Day.ToString() + " : " + netflix.Name + " " + netflix.Amount.ToString() + " - (Reccuring)");
            BudgetItem spotify = new BudgetItem() { Name = "Spotify", Amount = 8, Date = new DateTime(2024, 1, 20), Recurring = true };
            lbxExpense.Items.Add(spotify.Date.Day.ToString() + " : " + spotify.Name + " " + spotify.Amount.ToString() + " - (Reccuring)");
        }
    }
}
