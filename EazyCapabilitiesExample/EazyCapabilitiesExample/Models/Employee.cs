using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EazyCapabilitiesExample.Models.Jobs;

namespace EazyCapabilitiesExample.Models
{
    class Employee
    {
        private string phone;
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
        public string ImagePath { get; set; }
        public int WorkAge { get; set; }//Стаж
        public PersonsStage Position { get; set; }//Должность

        public Employee(string stage)
        {
            Position = PersonsStage.GetStage(stage, this);
        }
    }
}
