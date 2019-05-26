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

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

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
         //Acceso directo a info del perfil 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            if (ENG.Visibility==Visibility.Visible)
            {
                ENG.Visibility = Visibility.Collapsed;
                ESP.Visibility = Visibility.Visible;
           
            }
           else if (ESP.Visibility == Visibility.Visible)
            {
                ENG.Visibility = Visibility.Visible;
                ESP.Visibility = Visibility.Collapsed;

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Acceso al tutorial
        }
    }
}
