namespace SpecialFeatures.Programming
{
    using SSLMangrComp;
    using SSLMangrComp.Packets;
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class ARSGetIPAddressWorker
    {
        private string a;
        private int b;
        private string c;
        private object d;
        private Thread e;
        private ushort f;
        private ushort g;
        private string h;
        private SubscriptionType i;
        private bool j;
        private string k;
        private string l;
        private string m;
        private byte[] n;
        private PresenceNotification o;
        private string p;
        private PNConnectionInfo q;
        private const string r = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";
        [CompilerGenerated]
        private ARSGetIPAddressCompleted s;

        public event ARSGetIPAddressCompleted GetIPAddressCompletedEvent;

        public ARSGetIPAddressWorker(string strARSIPAddr, ushort portNum1, ushort portNum2, string cipherSuite, SubscriptionType mode, bool conectionType, string Ca_Cert, string Client_Cert, string pssPhrase, int timeout, byte[] dh);
        private void a();
        internal void GetIPAddressAsync(string deviceID, object state);

        internal int SocketTimeout { get; set; }
    }
}

