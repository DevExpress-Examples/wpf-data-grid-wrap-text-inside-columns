using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Xpf.Grid;
using System.Windows.Threading;
using DevExpress.Xpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;
using System.Windows.Markup;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        BindingList<ContactItem> coll;
        public Window1() {
            InitializeComponent();
            coll = new BindingList<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = "One Two Three Four Five Six Seven Eight Nine Ten Eleven Twelve";
            f1.Salary = 13;
            f1.SalaryLimitation = 30;
            f1.IsFired=false;
            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "One";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;
            
            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "One";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "Two";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "Two";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "Two";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);

            f1 = new ContactItem();
            f1.Name = "One";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "Two";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "One";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);

            f1 = new ContactItem();
            f1.Name = "Two";
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);

     
            grid.ItemsSource = coll;


        }

        

    }

}
