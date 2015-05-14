using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorkersLibrary;

namespace WorkerEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Workers = new ObservableCollection<Worker>();
            Workers.Add(new Manager("Svetlana", 27, 8746513, 15));
            Workers.Add(new Driver("Ivan", 25, 8465, "Audi", 256));
            Workers.Add(new Manager("Elena", 24, 8746, 10));
            Workers.Add(new Driver("Vasya", 29, 475613, "BMW", 231));
            Workers.Add(new Manager("Tatiana", 21, 846513, 20));

            DataContext = this;
        }

        private void workersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker = (sender as ListBox).SelectedItem as Worker;
            if (worker != null)
            {
                detailsPanel.DataContext = worker;
                if (worker is Driver)
                {
                    managerInfo.Visibility = System.Windows.Visibility.Collapsed;
                    driverInfo.Visibility = System.Windows.Visibility.Visible;
                }
                if (worker is Manager)
                {
                    managerInfo.Visibility = System.Windows.Visibility.Visible;
                    driverInfo.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Worker delWorker = workersList.SelectedItem as Worker;
            if (delWorker != null)
            {
                Workers.Remove(delWorker);
                workersList.SelectedIndex = 0;
            }
        }
    }
}
