using System.Configuration;
using System.Windows;

namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Interaction logic for Dialogue.xaml
    /// </summary>
    public partial class Dialogue : Window
    {
        public Dialogue(string msg)
        {
            InitializeComponent();
            textblock.Text = msg;
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
