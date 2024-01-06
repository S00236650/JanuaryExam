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
        /*
                                                                Github Link: https://github.com/S00236650/JanuaryExam
        */

        // Variables
        decimal totalIncome = 0;
        decimal totalExpense = 0;

        public MainWindow()
        {
            InitializeComponent();
            // Making sure one of the radio buttons are checked on startup
            rbIncome.IsChecked = true;

            // Adding income
            BudgetItem grant = new BudgetItem() { Name = "Grant", Amount = 300, Date = new DateTime(2024, 1, 5), Recurring = true };
            lbxIncome.Items.Add(grant.Date.Day.ToString() + " : " + grant.Name + " " + grant.Amount.ToString() + " - (Reccuring)");
            totalIncome+= grant.Amount;
            BudgetItem bonus = new BudgetItem() { Name = "Bonus", Amount = 300, Date = new DateTime(2024, 1, 15), Recurring = false };
            lbxIncome.Items.Add(bonus.Date.Day.ToString() + " : " + bonus.Name + " " + bonus.Amount.ToString() + " - (One Off)");
            totalIncome += bonus.Amount;
            BudgetItem wages = new BudgetItem() { Name = "Wages", Amount = 100, Date = new DateTime(2024, 1, 25), Recurring = true };
            lbxIncome.Items.Add(wages.Date.Day.ToString() + " : " + wages.Name + " " + wages.Amount.ToString() + " - (Reccuring)");
            totalIncome += wages.Amount;

            // Adding expenses
            BudgetItem rent = new BudgetItem() { Name = "Rent", Amount = 400, Date = new DateTime(2024, 1, 1), Recurring = true };
            lbxExpense.Items.Add(rent.Date.Day.ToString() + " : " + rent.Name + " " + rent.Amount.ToString() + " - (Reccuring)");
            totalExpense += rent.Amount;
            BudgetItem flight = new BudgetItem() { Name = "Flight", Amount = 100, Date = new DateTime(2024, 1, 5), Recurring = false };
            lbxExpense.Items.Add(flight.Date.Day.ToString() + " : " + flight.Name + " " + flight.Amount.ToString() + " - (One Off)");
            totalExpense += flight.Amount;
            BudgetItem netflix = new BudgetItem() { Name = "Netflix", Amount = 10, Date = new DateTime(2024, 1, 15), Recurring = true };
            lbxExpense.Items.Add(netflix.Date.Day.ToString() + " : " + netflix.Name + " " + netflix.Amount.ToString() + " - (Reccuring)");
            totalExpense += netflix.Amount;
            BudgetItem spotify = new BudgetItem() { Name = "Spotify", Amount = 8, Date = new DateTime(2024, 1, 20), Recurring = true };
            lbxExpense.Items.Add(spotify.Date.Day.ToString() + " : " + spotify.Name + " " + spotify.Amount.ToString() + " - (Reccuring)");
            totalExpense += spotify.Amount;

            // Updating total income and expense text
            tblkIncome.Text = totalIncome.ToString();
            tblkExpense.Text = totalExpense.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            string name;
            string amountString;
            decimal amount;
            DateTime date;
            bool recurring;

            // Setting Variables
            name = tbxName.Text;
            amountString = tbxAmount.Text;
            date = dtpckDate.DisplayDate;
            if(cbRecurring.IsChecked == true)
                recurring = true;
            else
                recurring = false;

            if(name != "" && decimal.TryParse(amountString, out amount) == true) // Checking the name isn't empty and that a valid amount is added
            {
                if (rbIncome.IsChecked == true)
                {
                    if (recurring)
                        lbxIncome.Items.Add(date.Day + " : " + name + " " + amount + " - (Reccuring)");
                    else
                        lbxIncome.Items.Add(date.Day + " : " + name + " " + amount + " - (One Off)");

                    lbxIncome.Items.Refresh();
                    totalIncome += amount;
                    tblkIncome.Text = totalIncome.ToString();
                }
                else
                {
                    if (recurring)
                        lbxExpense.Items.Add(date.Day + " : " + name + " " + amount + " - (Reccuring)");
                    else
                        lbxExpense.Items.Add(date.Day + " : " + name + " " + amount + " - (One Off)");

                    lbxExpense.Items.Refresh();
                    totalExpense += amount;
                    tblkExpense.Text = totalExpense.ToString();
                }
            }
        }

        private void rbIncome_Checked(object sender, RoutedEventArgs e)
        {
            // Unchecking expense radio button if income is checked
            if(rbIncome.IsChecked == true)
                rbExpense.IsChecked = false;
        }

        private void rbExpense_Checked(object sender, RoutedEventArgs e)
        {
            // Unchecking income radio button if expense is checked
            if (rbExpense.IsChecked == true)
                rbIncome.IsChecked = false;
        }
    }
}
