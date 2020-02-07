using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.myLabel.Content = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.myLabel.Content == null)
            {
                this.myLabel.Content = "Hello world";
            }
            else
            {
                this.myLabel.Content = null;
            }

        }
    }
}
