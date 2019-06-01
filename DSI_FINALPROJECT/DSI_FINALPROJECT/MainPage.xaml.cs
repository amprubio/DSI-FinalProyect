using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSi_FinalProyect
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            // Create a Frame to act navigation context and navigate to the first page
            var rootFrame = new Frame();
            rootFrame.Navigate(typeof(MainPage));
            // Place the frame in the current Window and ensure that it is active
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
            this.InitializeComponent();
        }
        //Cierra el juego
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

            CoreApplication.Exit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Map));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Settings));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(Settings));
        }   

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Acceso al tutorial (no funcional)
            this.Frame.Navigate(typeof(GameWindows));
        }


        private void Language_Click(object sender, RoutedEventArgs e)
        {
            if (Language_Grid.Visibility == Visibility.Collapsed)
            {
                Language_Grid.Visibility = Visibility.Visible;

            }
        }

        private void ENG_Click(object sender, RoutedEventArgs e)
        {

            Language_UK.Visibility = Visibility.Visible;
            Language_DEU.Visibility = Visibility.Collapsed;
            Language_SP.Visibility = Visibility.Collapsed;
            
            Language_Grid.Visibility = Visibility.Collapsed;

        }

        private void ESP_Click(object sender, RoutedEventArgs e)
        {
            Language_SP.Visibility = Visibility.Visible;
            Language_UK.Visibility = Visibility.Collapsed;
            Language_DEU.Visibility = Visibility.Collapsed;
            Language_Grid.Visibility = Visibility.Collapsed;

        }

        private void ALE_Click(object sender, RoutedEventArgs e)
        {
            Language_DEU.Visibility = Visibility.Visible;
            Language_SP.Visibility = Visibility.Collapsed;
            Language_UK.Visibility = Visibility.Collapsed;

            Language_Grid.Visibility = Visibility.Collapsed;
        }
    }
}
