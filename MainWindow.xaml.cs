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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Specialized;

namespace Prakt11
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

        private void Aba(object sender,RoutedEventArgs e)
        {
            Regex regex = new Regex(@"ab{4,}a");
            string s = ABA.Text;
            MatchCollection mathec = regex.Matches(s);
            object[] mas = new object[mathec.Count];
            mathec.CopyTo(mas, 0);
            listBox.ItemsSource = mas;
        }

        private void A1B(object sender,RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\ba\D?b\b");
            string s = AbA.Text;
            MatchCollection mathes = regex.Matches(s);
            object[] mas = new object[mathes.Count];
            mathes.CopyTo(mas, 0);
            listBox.ItemsSource = mas;
        }

        private void Support(object sender,RoutedEventArgs e)
        {
            string s = "https://t.me/Username1_1";
            System.Diagnostics.Process.Start(s);
        }

        private void Quit(object sender,RoutedEventArgs e)
        {
            this.Close();
        }

        private void Spravka(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("Калитин С.А. ИСП-31\nДана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение," +
            "которое найдет строки вида aba,в которых 'b' встречается более 4-х раз (включительно).\n" +
            "Дана строка 'avb a1b a2b a3b a4b a5b abb acb'. Напишите регулярное выражение," +
            "которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не число.");
        }
        
        private void Clear(object sender,RoutedEventArgs e)
        {
            ABA.Clear();
            AbA.Clear();
            listBox.ItemsSource = null;
        }
    }
}
