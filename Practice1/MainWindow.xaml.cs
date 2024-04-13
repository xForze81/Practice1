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
using Practice1.VoencomDataSetTableAdapters;
using Practice1.Model1TableAdapters;
namespace Practice1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    private VoencomEntities Pr1 = new VoencomEntities();
    public partial class MainWindow : Window
    {
        SpisokprizivnokovTableAdapter Prizivnik = new SpisokprizivnokovTableAdapter();
        public MainWindow() 
        {
            InitializeComponent();
            SpisokprizivnokovDataGrid.ItemsSource = Prizivnik.Prizivnik.Tolist();
        }
    }
}
