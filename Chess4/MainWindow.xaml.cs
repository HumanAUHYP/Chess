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
            while(true)
            {
                if (addOrMove)
                {
                    pieceName = tbPieceName.Text;
                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            addOrMove = true;
        }

        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            if (addOrMove)
            {
                (sender as Button).Content = tbPieceName.Text;
            }
            else
            {
                (sender as Button).Content = tbPieceName.Text;
            }
            
        }
    }
}
