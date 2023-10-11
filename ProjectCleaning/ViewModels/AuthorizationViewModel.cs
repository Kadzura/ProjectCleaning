using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ProjectCleaning.Context;
using ProjectCleaning.Models;
using ProjectCleaning.Services;
using ProjectCleaning.Views;

namespace ProjectCleaning.ViewModels
{
    [NotMapped]
    internal class AuthorizationViewModel : AuthorizationClass
    {
        private RelayCommand authCommand;
        public RelayCommand AuthCommand
        {
            get
            {
                return authCommand ??
                  (authCommand = new RelayCommand(obj =>
                  {
                      CleaningContextDb dataContext = new CleaningContextDb();
                      var user = dataContext.Persons.Where(u => (u.Mail == Mail && u.Password == Password)).FirstOrDefault();
                      if (user != null)
                      {
                          WindowAdministrator window = new WindowAdministrator();
                          window.Show();
                      }
                      else
                      {
                          MessageBox.Show("Не верный логин или пароль");
                      }
                  }));
            }
        }

        private RelayCommand registCommand;
        public RelayCommand RegistCommand
        {
            get
            {
                return registCommand ??
                  (registCommand = new RelayCommand(obj =>
                  {
                          WindowRegistration window = new WindowRegistration();
                          window.Show();
                  }));
            }
        }
    }
}
