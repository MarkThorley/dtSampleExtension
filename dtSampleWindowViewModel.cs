using System;
using Dynamo.Core;
using Dynamo.Extensions;

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

        public void Dispose()
        {
        }
    }
}
