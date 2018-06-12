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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        // constructor
        public ExpenseReportPage()
        {
            InitializeComponent();
        }

        // custom Constructor - receives the name selected from the ExpenseItHome page
		// : this() - constructor chaining
		//  runs the specified constructor (to initialize) and then the current constructor
		//
		//  we could remove the constructor chaining by adding the InitializeComponent() to this constructor
        public ExpenseReportPage(object data): this()
        {
            // bind to expense report data
            this.DataContext = data;
        }
    }
}
