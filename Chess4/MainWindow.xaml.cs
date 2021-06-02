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
        public bool add = false;
        public bool move = false;
        public string pieceName;
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            add = true;
            btnAdd.Background = Brushes.Green;
        }

        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            if (add)
            {
                (sender as Button).Content = pieceName;
                add = false;
                btnAdd.Background = Brushes.Red;
            }
            else if(move)
            {
                (sender as Button).Content = pieceName;
                move = false;
            }
            else if((sender as Button).Content != null)
            {
                pieceName = Convert.ToString((sender as Button).Content);
                (sender as Button).Content = null;
                move = true;
            }
        }

        private void PieceName_Click(object sender, RoutedEventArgs e)
        {
            pieceName = Convert.ToString((sender as Button).Content);
        }

        private void Cell_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            (sender as Button).Content = null;
        }
    }
}
