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
            ReadyParams rp = se.ReadyParamType;
            var vlp = rp as ViewLoadedParams;
            var wm = rp.CurrentWorkspaceModel;

            foreach (NodeModel node in wm.Nodes)
            {
                if (node.IsSelected)
                {
                    node.IsFrozen = true;
                }
            }
        }

        private void ButtonClick_UnfreezeAll(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            dtSampleWindowViewModel se = fe.DataContext as dtSampleWindowViewModel;
            ReadyParams rp = se.ReadyParamType;
            var vlp = rp as ViewLoadedParams;
            var wm = rp.CurrentWorkspaceModel;

            foreach (NodeModel node in wm.Nodes)
            {
                node.IsFrozen = false;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
