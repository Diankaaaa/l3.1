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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
        
            try {
            //Получение данных от пользователя
            double x = double.Parse(X.Text);
            double n = double.Parse(N.Text);

            double S = 0; //Сумма
            double P = 1; //Произведение

            //Цикл для вычсления суммы
            for (int k = 1; k <= n; k++)
            {
                if (k != 5)
                {
                    S += Math.Pow(-1, 3 * k + 1) / (k - 5) * Math.Pow(x, k);
                }
            }

            //Цикл для вычисления произведения
            for (int m = 1; m <= 1 + 7; m++) //По условию m <= k + 7, k = 1
            {
                if (m != 2) 
                {
                    P *= ((m * m) - 9) / m - 2;
                }

            }

            //Вывод результата
            Result.Text = (P * S).ToString();
            }
            
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
