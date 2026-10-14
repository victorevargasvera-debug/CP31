namespace SpecialFeatures.Comms
{
    using System;
    using System.Net;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DataProfIP
    {
        private string a;
        private IPAddress b;
        private IPAddress c;
        private IPAddress d;
        private IPAddress e;
        private IPAddress f;
        public string DataProfName { get; set; }
        public IPAddress SubIP { get; set; }
        public IPAddress PeerIP { get; set; }
        public IPAddress BTSubIP { get; set; }
        public IPAddress BTPeerIP { get; set; }
        public IPAddress SubAirInterfaceIP { get; set; }
    }
}

