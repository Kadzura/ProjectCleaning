using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCleaning.Models
{
    [Table("tPosition")]
    internal class PositionClass : INotifyPropertyChanged
    {
        [Key]
        private long idPosition;
        private string title;
        private string description;
        private decimal pay;

        [Key]
        public long IdPosition
        {
            get { return idPosition; }
            set
            {
                idPosition = value;
                OnPropertyChanged("IdPosition");
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }  

        public decimal Pay
        {
            get { return pay; }
            set
            {
                pay = value;
                OnPropertyChanged("Pay");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
