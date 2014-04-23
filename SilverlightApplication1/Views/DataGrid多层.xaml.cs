using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightApplication1.Views
{
    /// <summary>
    /// DataGrid嵌套 参考http://social.microsoft.com/Forums/pt-BR/silverlightzhchs/thread/1ff41150-6af1-4984-ad6d-70757d4e1ebe
    /// </summary>
    public partial class DataGrid多层 : Page
    {
        public DataGrid多层()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Employee> lst = new List<Employee>();

            List<TailNo> a1List = new List<TailNo>();
            a1List.Add(new TailNo("a123")); a1List.Add(new TailNo("a124"));
            lst.Add(new Employee("a1", "A2", 2000, new DateTime(2009, 5, 20), true, a1List));

            List<TailNo> b1List = new List<TailNo>();
            b1List.Add(new TailNo("b123")); b1List.Add(new TailNo("b122")); b1List.Add(new TailNo("b1234"));
            lst.Add(new Employee("b1", "B2", 2000, new DateTime(2002, 5, 20), true, b1List));

            //lst.Add(new Employee("c1", "C2", 2000, new DateTime(2004, 5, 20), false));
            //lst.Add(new Employee("d1", "D2", 2000, new DateTime(2006, 5, 20), true));
            //lst.Add(new Employee("e1", "E2", 2000, new DateTime(2007, 5, 20), false));
            //lst.Add(new Employee("f1", "f2", 2000, new DateTime(2008, 5, 20), true));

            grdDisplay.ItemsSource = lst;
        }

    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public Boolean IsVested { get; set; }
        public List<TailNo> ListTailNo { get; set; }

        public Employee(string firstName, string lastName, decimal salary, DateTime startDate, Boolean isVested, List<TailNo> listTailNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            StartDate = startDate;
            IsVested = isVested;
            ListTailNo = listTailNo;
        }

        public Employee(string firstName,string lastName,decimal salary,DateTime startDate,Boolean isVested)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            StartDate = startDate;
            IsVested = isVested;
        }


    }

    public class TailNo
    {
        public string TailName { get; set; }
        public TailNo(string tailName)
        {
            TailName = tailName;
        }
    }
}
