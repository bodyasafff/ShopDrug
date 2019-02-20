using ShopDrug.Data;
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

namespace ShopDrug
{
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();

                SelectCountry();
        }
        public void SelectCountry()
        {
           
            using (var ctx = new Model1())
            {
                //ctx.Adressess.Add();
                 var producers = ctx.Producers.ToList().Select(a => a.Adresses.Countries).Distinct().ToList();
                lb.ItemsSource = producers;
            }
        }
        public void SelectUserMaxSum()
        {
            using (var ctx = new Model1())
            {
                
                
            }
        }
    }
}
