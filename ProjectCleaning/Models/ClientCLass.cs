using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCleaning.Models
{
    internal class ClientCLass : HumanClass
    {
        private string address;
        private string phone;

        public string Address 
        { 
            get { return address; } 
            set 
            {  
                address = value;
                OnPropertyChanged("Address");
            } 
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
    }
}
