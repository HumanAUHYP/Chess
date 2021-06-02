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

namespace Chess4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool addOrMove = false;
        public string pieceName;
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            addOrMove = true;
        }

        private void Cell_Click(object sender, RoutedEventArgs e)
        {
           (sender as Button).Content = pieceName;
        }

        private void PieceName_Click(object sender, RoutedEventArgs e)
        {
            pieceName = Convert.ToString((sender as Button).Content);
        }
    }
}
