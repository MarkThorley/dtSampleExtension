using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamo.Wpf.Extensions;
using System.Windows;
using System.Windows.Controls;
using Dynamo.ViewModels;

namespace dtSampleExtension
{
    public class dtSampleExtension : IViewExtension
    {
        private MenuItem biltMenuItem;
        private MenuItem extensionMenuItem;

        public void Dispose()
        {
        }

        public void Startup(ViewStartupParams p)
        {
        }

        public void Loaded(ViewLoadedParams p)
        {
            biltMenuItem = new MenuItem { Header = "BILT EUR 2018" };
            var VM = p.DynamoWindow.DataContext as DynamoViewModel;

            extensionMenuItem = new MenuItem { Header = "designtech Sample Extension" };
            extensionMenuItem.Click += (sender, args) =>
            {
                var viewModel = new dtSampleWindowViewModel(p);
                var window = new dtSampleWindow
                {
                    // Set the data context for the main grid in the window.
                    MainGrid = { DataContext = viewModel },

                    // Set the owner of the window to the Dynamo window.
                    Owner = p.DynamoWindow
                };
                window.Left = window.Owner.Left + 400;
                window.Top = window.Owner.Top + 200;
                window.Show();
            };
            biltMenuItem.Items.Add(extensionMenuItem);
            p.dynamoMenu.Items.Add(biltMenuItem);
        }

        public void Shutdown()
        {
        }

        public string UniqueId
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        public string Name
        {
            get
            {
                return "BILT EUR 2018";
            }
        }

    }
}

