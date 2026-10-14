namespace SpecialFeatures.POP25BatchProgrammer
{
    using SpecialFeatures.Programming;
    using SSLMangrComp;
    using SSLMangrComp.Packets;
    using System;

    public class ARSGetPOP25BatchIPAddress
    {
        private string a;
        private int b;
        private string c;
        private OTAPPrescenceResult d;
        private ushort e;
        private ushort f;
        private string g;
        private SubscriptionType h;
        private bool i;
        private string j;
        private string k;
        private string l;
        private byte[] m;
        private PresenceNotification n;
        private string o;
        private PNConnectionInfo p;
        private const string q = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

        internal ARSGetPOP25BatchIPAddress(string strARSIPAddr, ushort portNum1, ushort portNum2, string cipherSuite, SubscriptionType mode, int deviceID, bool conectionType, string Ca_Cert, string Client_Cert, string pssPhrase, byte[] dhk);
        internal void GetIPAddressFromARS();

        internal OTAPPrescenceResult ARSResult { get; }
    }
}

