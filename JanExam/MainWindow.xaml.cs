/*
 * 
 *      -- Link to Github: https://github.com/B1ADEEE/JanExam
 * 
 * 
 */
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
using System.Collections.ObjectModel;

namespace JanExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Accounts> accounts = new ObservableCollection<Accounts>();
        ObservableCollection<CurrentAccount> Currentaccountppl = new ObservableCollection<CurrentAccount>();
        ObservableCollection<SavingAccount> Savingaccountppl = new ObservableCollection<SavingAccount>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            Accounts e1 = new SavingAccount("jeff", "bosoz" , 21 , "21/12/2021");                                               //making the people in the Accounts class
            SavingAccount e1v2 = new SavingAccount("jeff", "bosoz", 21, "21/12/2021");                                          //making the people for that group
            Accounts e2 = new CurrentAccount("elon", "Musk", 543, "11/06/2020");
            CurrentAccount e2v2 = new CurrentAccount("elon", "Musk", 543, "11/06/2020");
            Accounts e3 = new SavingAccount("jimmy", "netron", 9645 , "19/04/2020");
            SavingAccount e3v2 = new SavingAccount("jimmy", "netron", 9645, "19/04/2020");
            Accounts e4 = new CurrentAccount("bart", "simpson", 654, "02/02/2020");
            CurrentAccount e4v2 = new CurrentAccount("bart", "simpson", 654, "02/02/2020");
            accounts.Add(e1);                                                                                                   //adding people to the list for the Accounts class
            Savingaccountppl.Add(e1v2);                                                                                         //indivisually adding each perosn to ther erespective group at first to help filtering later on
            accounts.Add(e2);
            Currentaccountppl.Add(e2v2);
            accounts.Add(e3);
            Savingaccountppl.Add(e3v2);
            accounts.Add(e4);
            Currentaccountppl.Add(e4v2);
            ListboxAccount.ItemsSource = accounts;                                                                              //filling the empty table with just accounts at first
        }

        private void SavingCHECK_Checked(object sender, RoutedEventArgs e)
        {
            AccountTypeTBX.Text = "Savings Account";
            if (SavingCHECK.IsChecked == true)                                                                                  //if the fulltime check box is checked list only saving accounts
            {
                ListboxAccount.ItemsSource = Savingaccountppl;
            }
        }

        private void CurrentCHECK_Checked(object sender, RoutedEventArgs e)
        {
            AccountTypeTBX.Text = "Current Account";
            if (CurrentCHECK.IsChecked == true)                                                                                 //if the fulltime check box is checked list only current accounts
            {
                ListboxAccount.ItemsSource = Currentaccountppl;
            }
        }

        private void ListboxAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                Accounts SelectedAccount = ListboxAccount.SelectedItem as Accounts;                                             //getting the selected Account
                CurrentAccount SelectedCurrent = ListboxAccount.SelectedItem as CurrentAccount;
                SavingAccount SelectedSaving = ListboxAccount.SelectedItem as SavingAccount;
                if (SelectedAccount != null)                                                                                    // as long as there is an account that is selected
                {
                    FirstnameTBX.Text = SelectedAccount.FirstName;                                                              //prints the data of that account in the corilated boxs
                    LastnameTBX.Text = SelectedAccount.LastName;
                    BalanceTBX.Text = SelectedAccount.Balance.ToString();
                    InterestDateTBX.Text = SelectedAccount.InterestDate;
                }
        }

    }
}
