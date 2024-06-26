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

namespace HotelManagementSystem
{
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
        }

        private void SideBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavButton? selected = SideBar.SelectedItem as NavButton;
            if (selected != null && MainNavFrame != null) MainNavFrame.Navigate(selected.Navlink);
        }
    }
}
