﻿using System.Text;
using System.Windows;
using MVVM4.ViewModel;

namespace MVVM4
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();            
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = new MainViewModel(Dispatcher);
            DataContext = viewModel;
        }

        private void CreatNewOilRigButton(object sender, RoutedEventArgs e)
        {
            viewModel.InitializeOilRigsAsync();
        }
    }    
}