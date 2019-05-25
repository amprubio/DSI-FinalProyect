using System;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSi_FinalProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    
    public sealed partial class GameWindows : Page
    {
        const int MAXBALAS =99;
        private int numbalas;
        public GameWindows()
        {
            numbalas = MAXBALAS;
            nBalas.Text = numbalas.ToString();

            this.InitializeComponent();
        }
        private void Shoot_Button_Click(object sender, RoutedEventArgs e)
        {
            if (numbalas > 0)
            {
                numbalas--;
                nBalas.Text = numbalas.ToString();
            }
        }

        private void BotonResume_Click(object sender, RoutedEventArgs e)
        {
            if (PauseGrid.Visibility == Visibility.Visible)
            {
                PauseGrid.Visibility = Visibility.Collapsed;
            }
        }

        private void BotonOptions_Click(object sender, RoutedEventArgs e)
        {
            if (PauseGrid.Visibility == Visibility.Visible)
            {
                PauseGrid.Visibility = Visibility.Collapsed;
            }
        }

        private void BotonExit_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            rootFrame.Navigate(typeof(MainPage));
        }

        private void BotonOptions_Click_1(object sender, RoutedEventArgs e)
        {

            var rootFrame = new Frame();
            rootFrame.Navigate(typeof(Settings));
        }
    }
}
