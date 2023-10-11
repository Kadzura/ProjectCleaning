using ProjectCleaning.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCleaning.Models
{
    [Table("tPerson")]
    internal class PersonClass : HumanClass
    {
        [Key]
        private long idPerson;
        private long idPosition;

        [Key]
        public long IdPerson
        {
            get { return idPerson; }
            set
            {
                idPerson = value;
                OnPropertyChanged("IdPerson");
            }
        }

        public long IdPosition
        {
            get { return idPosition; }
            set
            {
                idPosition = value;
                OnPropertyChanged("IdPosition");
            }
        }
    }
}
