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
using System.IO;
using Newtonsoft.Json;

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamWriter writer = new StreamWriter("5.txt");
            writer.WriteLine("fdfd");
            writer.Close();

            StreamReader reader = new StreamReader("2.csv");
            while (!reader.EndOfStream)
            {
                string[] input = reader.ReadLine().Split(new char[] { ';' });
                for(int i = 0; i < input.Length; i += 2)
                {
                    Database.Insert(input[i], input[i + 1]);
                }
            }
            reader.Close();
        }
    }
}