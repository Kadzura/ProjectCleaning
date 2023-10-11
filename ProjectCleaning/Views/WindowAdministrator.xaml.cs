using ProjectCleaning.Services;
using ProjectCleaning.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace ProjectCleaning.Views
{
    /// <summary>
    /// Логика взаимодействия для WindowAdministrator.xaml
    /// </summary>
    public partial class WindowAdministrator : Window
    {
        private AdministratorViewModel administratorViewModel;
        public WindowAdministrator()
        {
            InitializeComponent();

            administratorViewModel = new AdministratorViewModel();
            this.DataContext = administratorViewModel;

            //DgPosition.ItemsSource = DbCleaning_Entities.GetComponent().tPosition.ToList();
        }

        #region Navigation
        private void BtPosition_Click(object sender, RoutedEventArgs e)
        {
            TcAdmin.SelectedIndex = 0;
        }

        private void BtPerson_Click(object sender, RoutedEventArgs e)
        {
            TcAdmin.SelectedIndex = 1;
        }

        private void BtPackage_Click(object sender, RoutedEventArgs e)
        {
            TcAdmin.SelectedIndex = 2;
        }

        private void BtService_Click(object sender, RoutedEventArgs e)
        {
            TcAdmin.SelectedIndex = 3;
        }
        #endregion

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
