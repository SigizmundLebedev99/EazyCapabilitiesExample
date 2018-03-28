using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EazyCapabilitiesExample.Models.Jobs;

namespace EazyCapabilitiesExample.Models
{
    class Employee : INotifyPropertyChanged
    {
        private string phone;
        private string imagepath;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get { return phone; } set
            {
                if ((value.Length == 7 || value.Length == 11) && long.TryParse(value, out long i))
                {
                    phone = value;
                }
            }
        }
        public DateTime Birthday { get; set; }
        public string ImagePath { get { return imagepath; } set { imagepath = value; OnPropertyChanged(); } }
        public int WorkAge { get; set; }//Стаж
        public PersonsStage Position { get; set; }//Должность

        public Employee(string stage)
        {
            Position = PersonsStage.GetStage(stage, this);
        }
    }
}
