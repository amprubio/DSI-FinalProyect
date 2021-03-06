﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSi_FinalProyect
{

    public sealed partial class Settings : Page
    {
        
        private bool ModoZurdo;
        public Settings()
        {
            ModoZurdo = false;
            Player p = new Player();
            p.Inicio();
            this.InitializeComponent();

            NameText.Text = "Name: " + p.Profile;
            EnemiesInfo.Text= "Enemigos muertos: "+p.GetEnemiesKilled().ToString();
            EXP_Text.Text = "EXP: " + p.GetEXP();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

            CoreApplication.Exit();
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (GridButton_1.Visibility == Visibility.Visible)
            {
                GridButton_1.Visibility = Visibility.Collapsed;
            }
            if (GridButton_2.Visibility == Visibility.Visible)
            {
                GridButton_2.Visibility = Visibility.Collapsed;
            }
            GridButton_0.Visibility = Visibility.Visible;

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (GridButton_0.Visibility == Visibility.Visible)
            {
                GridButton_0.Visibility = Visibility.Collapsed;
            }
            if (GridButton_2.Visibility == Visibility.Visible)
            {
                GridButton_2.Visibility = Visibility.Collapsed;
            }
            GridButton_1.Visibility = Visibility.Visible;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (GridButton_0.Visibility == Visibility.Visible)
            {
                GridButton_0.Visibility = Visibility.Collapsed;
            }
            if (GridButton_1.Visibility == Visibility.Visible)
            {
                GridButton_1.Visibility = Visibility.Collapsed;
            }
            GridButton_2.Visibility = Visibility.Visible;

        }
        public bool GetModeZurdo()
        {
            return ModoZurdo;
        }
        private void AppBarToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ModoZurdo)
            {
                ModoZurdo = false;
            }
            else
            {
                ModoZurdo = true;
            }
        }
    }
}
