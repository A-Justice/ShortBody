﻿using ShortBody.Models;
using ShortBody.UViewModel;
using System;
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

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        UserPageViewModel viewModel;
        public static UsersPage usersPage;
        public UsersPage()
        {

            InitializeComponent();
            viewModel = new UserPageViewModel();
            DataContext = viewModel;
            usersPage = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainUserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
         try { viewModel.allUsersSelectedId = ((User)grid.SelectedItem)?.UserId; } catch { }

        }

        private void MainUserGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //var grid = sender as DataGrid;
            //viewModel.allUsersSelectedId = ((User)grid.SelectedItem).UserId;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            if (AddUserWindow.Visibility != Visibility.Visible)
                AddUserWindow.Resize();
        }

        private void AddUserWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddUserWindow.Visibility = Visibility.Collapsed;
        }

        private void ChangeUserImage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ResetUserImage();
        }

        private void cboSearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSearchBox.SelectedIndex == 0)
            {
                txtSearchBox.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchBox.Visibility = Visibility.Visible;
        }
    }
}
