using System;
using Dynamo.Core;
using Dynamo.Extensions;
using Dynamo.Graph.Nodes;
using Dynamo.Graph.Workspaces;
using Dynamo.Wpf.Extensions;

namespace dtSampleExtension
{
    public class dtSampleWindowViewModel : NotificationObject, IDisposable
    {

        private ReadyParams readyParams;

        public ReadyParams ReadyParamType
        {
            get
            {
                readyParams = getReadyParams();
                return readyParams;
            }
        }

        public ReadyParams getReadyParams()
        {
            return readyParams;
        }

        public dtSampleWindowViewModel(ReadyParams p)
        {
            readyParams = p;
        }

        #region Functions
        public void FreezeSelected(dtSampleWindowViewModel se)
        {
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

        public void UnFreezeSelected(dtSampleWindowViewModel se)
        {
            ReadyParams rp = se.ReadyParamType;
            var vlp = rp as ViewLoadedParams;
            var wm = rp.CurrentWorkspaceModel;

            foreach (NodeModel node in wm.Nodes)
            {
                if (node.IsSelected)
                {
                    node.IsFrozen = false;
                }
            }
        }

        public void FreezeAll(dtSampleWindowViewModel se)
        {
            ReadyParams rp = se.ReadyParamType;
            var vlp = rp as ViewLoadedParams;
            var wm = rp.CurrentWorkspaceModel;

            foreach (NodeModel node in wm.Nodes)
            {
                node.IsFrozen = true;
            }
        }

        public void UnFreezeAll(dtSampleWindowViewModel se)
        {
            ReadyParams rp = se.ReadyParamType;
            var vlp = rp as ViewLoadedParams;
            var wm = rp.CurrentWorkspaceModel;

            foreach (NodeModel node in wm.Nodes)
            {
                node.IsFrozen = false;
            }
        }
        #endregion

        public void Dispose()
        {
        }
    }
}
