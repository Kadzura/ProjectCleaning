using ProjectCleaning.ViewModels;
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
using System.Windows.Shapes;

namespace ProjectCleaning.Views
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthorization.xaml
    /// </summary>
    public partial class WindowAuthorization : Window
    {
        private AuthorizationViewModel authorizationViewModel;
        public WindowAuthorization()
        {
            InitializeComponent();

            authorizationViewModel = new AuthorizationViewModel();
            this.DataContext = authorizationViewModel;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
