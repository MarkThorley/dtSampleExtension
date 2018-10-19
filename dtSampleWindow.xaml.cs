using System.Windows;
using System.Windows.Navigation;
using Dynamo.Extensions;
using Dynamo.Graph.Nodes;
using Dynamo.Wpf.Extensions;
using System.Diagnostics;

namespace dtSampleExtension
{
    /// <summary>
    /// Interaction logic for dtSampleWindow.xaml
    /// </summary>
    public partial class dtSampleWindow : Window
    {
        public dtSampleWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick_FreezeSelected(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            dtSampleWindowViewModel se = fe.DataContext as dtSampleWindowViewModel;
            se.FreezeSelected(se);
        }

        private void ButtonClick_UnFreezeSelected(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            dtSampleWindowViewModel se = fe.DataContext as dtSampleWindowViewModel;
            se.UnFreezeSelected(se);
        }

        private void ButtonClick_FreezeAll(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            dtSampleWindowViewModel se = fe.DataContext as dtSampleWindowViewModel;
            se.FreezeAll(se);
        }

        private void ButtonClick_UnFreezeAll(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            dtSampleWindowViewModel se = fe.DataContext as dtSampleWindowViewModel;
            se.UnFreezeAll(se);
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
