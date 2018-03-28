using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EazyCapabilitiesExample.Models.Jobs;
using System.Windows.Input;
using EazyCapabilitiesExample.Models;
using Microsoft.Win32;

namespace EazyCapabilitiesExample.ViewModel
{
    class AddEmployeeVM : INotifyPropertyChanged
    {
        public static event Action<Employee> AddEmployeeEvent;
        

        private string _phone;
        private string image;
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string patronymic { get; set; }
        public string phone { get { return _phone; } set
            {
                if ((value.Length == 7 || value.Length == 11) && long.TryParse(value, out long i))
                {
                    _phone = value;
                }
            }
        }
        public DateTime birthday { get; set; }
        public string imagepath { get { return image; } set { image = value; OnPropertyChanged(); } }
        public int workage { get; set; }
        public string position { get; set; }

        public string[] Variants { get; set; }

        public AddEmployeeVM()
        {
            Variants = PersonsStage.GetStages().Select(s=> s.StageName).ToArray();
        }

        public ICommand Add
        {
            get
            {
                return new DefaultCommand(
                    (obj) => 
                    {
                        Employee emp = new Employee(position);
                        emp.Birthday = birthday;
                        emp.ImagePath = imagepath;
                        emp.Lastname = lastname;
                        emp.Firstname = firstname;
                        emp.Patronymic = patronymic;
                        emp.Phone = phone;
                        emp.WorkAge = workage;
                        AddEmployeeEvent?.Invoke(emp);
                        (obj as AddEmployeeWindow).Close();
                    },
                    (obj) =>
                    {
                        return !string.IsNullOrWhiteSpace(firstname) &&
                        !string.IsNullOrWhiteSpace(lastname) &&
                        !string.IsNullOrWhiteSpace(patronymic) &&
                        !string.IsNullOrWhiteSpace(phone) &&
                        !string.IsNullOrWhiteSpace(position) &&
                        !string.IsNullOrWhiteSpace(imagepath);
                    }
                    );
            }
        }
        public ICommand ChooseImage
        {
            get
            {
                return new DefaultCommand((o) =>
                {
                    OpenFileDialog opd = new OpenFileDialog();
                    opd.Filter = "Image Files .JPG|*.jpg";
                    if(opd.ShowDialog() == true)
                    {
                        imagepath = opd.FileName;
                    }
                }
                );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }  
}
