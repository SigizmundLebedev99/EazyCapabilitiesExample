using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using EazyCapabilitiesExample.Models.Jobs;
using EazyCapabilitiesExample.Models;
using EazyCapabilitiesExample.Models.AppData;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Data;

namespace EazyCapabilitiesExample.ViewModel
{
    class MainViewModel:DependencyObject
    {
        public MainViewModel()
        {
            EmployeeCollection = new ObservableCollection<Employee>(XmlWorker.GetEmployeesFromXml());
            AddEmployeeVM.AddEmployeeEvent += (emp) => EmployeeCollection.Add(emp);
            EmployeeView = CollectionViewSource.GetDefaultView(EmployeeCollection);
            EmployeeView.Filter = obj =>
            {
                Employee emp = obj as Employee;              
                return (emp.Firstname + emp.Lastname + emp.Patronymic).ToUpper().Contains(searchText.ToUpper());               
            };
        }

        public string[] Jobs { get; set; }

        public ICollectionView EmployeeView
        {
            get { return (ICollectionView)GetValue(EmployeeViewProperty); }
            set { SetValue(EmployeeViewProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeViewProperty =
            DependencyProperty.Register("EmployeeView", typeof(ICollectionView), typeof(MainViewModel), new PropertyMetadata(null));

        public ObservableCollection<Employee> EmployeeCollection
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeeCollectionProperty); }
            set { SetValue(EmployeeCollectionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeCollection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeCollectionProperty =
            DependencyProperty.Register("EmployeeCollection", typeof(ObservableCollection<Employee>), typeof(MainViewModel), new PropertyMetadata(null));

        public ICommand AddEmployee
        {
            get
            {
                return new DefaultCommand((o) => (new AddEmployeeWindow()).ShowDialog());
            }
        }

        public ICommand Remove
        {
            get
            {
                return new DefaultCommand(
                    (obj) => 
                    {
                        Employee emp = obj as Employee;
                        if(MessageBox.Show($"Вы действительно хотите удалить запись:\n {emp.Lastname} {emp.Firstname} {emp.Patronymic}", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            EmployeeCollection.Remove(emp as Employee);
                    }
                    );
            }
        }

        private string searchText { get; set; } = string.Empty;
        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                EmployeeView.Refresh();
            }
        }
    }
}
