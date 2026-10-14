namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Service;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.ServiceModel;

    [CallbackBehavior(UseSynchronizationContext=false)]
    public class DeviceServiceHandler : IOperationServiceEvent
    {
        [CompilerGenerated]
        private ProgressChangedEventHandler a;

        public event ProgressChangedEventHandler ProgressEventHandler;

        public DeviceServiceHandler();
        internal void OnClientStatusCheck();
        public void OnProgress(int percent, ProgressStatus processStatus);
    }
}

