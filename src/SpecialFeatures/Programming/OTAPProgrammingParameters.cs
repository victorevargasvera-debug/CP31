namespace SpecialFeatures.Programming
{
    using System;

    public class OTAPProgrammingParameters
    {
        internal string _ArsServerIPAddress;
        internal string _RadioIPAddressFromServer;
        internal string _EnteredRadioIPAddress;
        internal string _ArsServerTimeout;
        internal bool? _UseARSServer;
        internal string _EnteredRadioID;
        internal string _SessionInactiveTimer;

        private OTAPProgrammingParameters();
        internal OTAPProgrammingParameters(string ARSServerIPAddress, string RadioIPFromServer, string EnteredRadioID, string EnteredRadioIPAddress, string ArsServerTimeout, bool? UseARSServer, string SessionInactiveTimer);
    }
}

