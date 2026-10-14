namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using System;

    public class FileProxyFactory
    {
        protected ProxyParameter _proxyParameter;
        private static FileProxyFactory a;

        static FileProxyFactory();
        public FileProxyFactory();
        protected virtual IDeviceProxy CreateDevice(ProxyParameter parameter);
        internal IDeviceProxy GetDevice(object arg, RadioOperation radioOperation);
        public virtual bool SetupVirtualProxy(string deviceFile, AstroDeviceInfo deviceInfo);

        public static FileProxyFactory Instance { get; }
    }
}

