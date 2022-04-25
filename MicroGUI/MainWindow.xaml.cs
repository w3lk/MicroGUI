using MicroGUI.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MicroGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVm mainViewModel;
        public MainWindow()
        {
            mainViewModel = new MainWindowVm();

            InitializeComponent();

            this.DataContext = mainViewModel;

        }

       

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string parsed = JsonConvert.SerializeObject(mainViewModel.ValueObjects);
            Console.WriteLine(parsed);
        }
    }
}