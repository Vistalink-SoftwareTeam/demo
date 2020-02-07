using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IList<messageSourceBase> messageSources = new List<messageSourceBase>();

        /// <summary>
        /// Main entry point of the WpfApp1
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.myLabel.Content = null;

            //Register your message sources here
            messageSources.Add(new messageSourceDemo());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.myLabel.Content == null)
            {
                this.myLabel.Content = "Hello world";
                foreach (messageSourceBase msgSrc in messageSources)
                {
                    this.myLabel.Content += "\n";
                    this.myLabel.Content += msgSrc.GetMessage();
                }
            }
            else
            {
                this.myLabel.Content = null;
            }

        }
    }
}
