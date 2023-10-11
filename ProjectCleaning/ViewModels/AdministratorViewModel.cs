using ProjectCleaning.Context;
using ProjectCleaning.Models;
using ProjectCleaning.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ProjectCleaning.ViewModels
{
    [NotMapped]
    internal class AdministratorViewModel : PersonClass
    {
        public ObservableCollection<PositionClass> Positions { get; set; }

        public AdministratorViewModel()
        {
            Positions = new ObservableCollection<PositionClass>(CleaningContextDb.GetComponent().Positions);
        }
    }
}
