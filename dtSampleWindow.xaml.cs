using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dynamo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dynamo.Extensions;
using Dynamo.ViewModels;
using Dynamo.Graph.Nodes;
using Dynamo.Wpf.Extensions;
using Dynamo.Graph;
using System.Drawing;
using Dynamo.Graph.Annotations;
using Dynamo.Graph.Workspaces;
using Dynamo.Graph.Notes;
using System.Diagnostics;
using Dynamo.Models;
using Dynamo.Graph.Nodes.ZeroTouch;
using Dynamo.Engine;
using System.IO;
using Dynamo.Search;
using System.Reflection;

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
