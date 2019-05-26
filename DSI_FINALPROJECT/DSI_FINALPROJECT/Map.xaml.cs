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
    public sealed partial class Map : Page
    {
        public Map()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DRAW_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            //Aqui iria la funcionalidad de dibujar que no es de mi ocupacion realmente
        }

        private void ERASE_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            //Aqui iria la funcionalidad de  borrar que no es de mi ocupacion realmente
        }

        private void AppBarButton_Click_1()
        {

        }
    }
}
