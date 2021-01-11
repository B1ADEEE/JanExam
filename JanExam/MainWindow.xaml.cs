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
            Accounts e1 = new SavingAccount("Jane", "Jones" , 21 , "gfdg");                                              //making the people in the employee class
            SavingAccount e1v2 = new SavingAccount("John", "Smith", "PartTime", 4, 21);                               //making the people for that group
            Accounts e2 = new CurrentAccount("Joe", "Murphy", "FullTime", 54);
            CurrentAccount e2v2 = new CurrentAccount("Joe", "Murphy", "FullTime", 54);
            Accounts e3 = new SavingAccount("John", "Smith", "PartTime", 4, 21);
            PartTimeEmployee e3v2 = new SavingAccount("John", "Smith", "PartTime", 4, 21);
            Accounts e4 = new CurrentAccount("Jess", "Walsh", "FullTime", 83);
            FullTimeEmployee e4v2 = new CurrentAccount("Jess", "Walsh", "FullTime", 83);
            employee.Add(e1);                                                                                               //adding people to the list for the employee class
            PartTimePeople.Add(e1v2);                                                                                       //indivisually adding each perosn to ther erespective group at first to help filtering later on
            employee.Add(e2);
            FullTimePeople.Add(e2v2);
            employee.Add(e3);
            PartTimePeople.Add(e3v2);
            employee.Add(e4);
            FullTimePeople.Add(e4v2);
            ListBoxEmployeeBOX.ItemsSource = employee;                                                                      //filling the empty table with just emplyee at first
            employee.OrderBy(x => x.SurName).ToList();                                                                      //Sorts them alphabetically 
            FullTimePeople.OrderBy(x => x.SurName).ToList();
            PartTimePeople.OrderBy(x => x.SurName).ToList();
        }
    }
}
