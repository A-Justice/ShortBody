using ShortBody.Models;
using System;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        ClientPageViewModel viewModel;
        public static ClientPage clientPage;
        public ClientPage()
        {  
            InitializeComponent();           
            viewModel = new ClientPageViewModel();
            DataContext = viewModel;         
            clientPage = this;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainClientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allClientsSelectedId = ((Client)grid.SelectedItem)?.ClientId; } catch { }
            
        }

    

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            if(AddClientWindow.Visibility != Visibility.Visible)
            AddClientWindow.Resize();
        }

        private void AddClientWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddClientWindow.Visibility = Visibility.Collapsed;
        }

        private void cboSearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboSearchBox.SelectedIndex == 0)
            {
                txtSearchBox.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchBox.Visibility = Visibility.Visible;
        }
    }
}
