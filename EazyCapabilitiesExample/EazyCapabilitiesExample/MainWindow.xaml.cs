﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EazyCapabilitiesExample.Models.AppData;
using EazyCapabilitiesExample.Models;
using EazyCapabilitiesExample.Models.Jobs;
using EazyCapabilitiesExample.ViewModel;

namespace EazyCapabilitiesExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();             
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
                Window wnd = sender as Window;
                if (wnd != null)
                {
                    MainViewModel vm = wnd.DataContext as MainViewModel;
                    XmlWorker.SaveEmployesInfo(vm.EmployeeCollection);
                    MessageBox.Show("Данные сохранены");
                }
                      
        }
    }
}
