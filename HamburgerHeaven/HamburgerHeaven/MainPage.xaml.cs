﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerHeaven
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Finance));
        }

        private void HamburgerButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationSplitView.IsPaneOpen = !NavigationSplitView.IsPaneOpen;
        }

        private void ListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(NavigationListView.SelectedItem == FinanceListItem)
            {
                navigateToFinance();

            } else if(NavigationListView.SelectedItem == FoodListItem)
            {
                navigateToFood();
            }
        }

        private void navigateToFinance()
        {
            Title.Text = "Finance";
            BackButton.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(typeof(Finance));
            if(NavigationListView.SelectedItem != FinanceListItem)
            NavigationListView.SelectedItem = FinanceListItem;
        }

        private void navigateToFood()
        {
            Title.Text = "Food";
            BackButton.Visibility = Visibility.Visible;
            MainFrame.Navigate(typeof(Food));
            if(NavigationListView.SelectedItem != FoodListItem)
            NavigationListView.SelectedItem = FoodListItem;
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            navigateToFinance();
        }
    }
}
