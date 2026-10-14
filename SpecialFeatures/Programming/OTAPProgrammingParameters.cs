using System;

namespace SpecialFeatures.Programming
{
	// Token: 0x0200008A RID: 138
	public class OTAPProgrammingParameters
	{
		// Token: 0x06000A7F RID: 2687 RVA: 0x000025CE File Offset: 0x000007CE
		private OTAPProgrammingParameters()
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002C46 File Offset: 0x00000E46
		internal OTAPProgrammingParameters(string ARSServerIPAddress, string RadioIPFromServer, string EnteredRadioID, string EnteredRadioIPAddress, string ArsServerTimeout, bool? UseARSServer, string SessionInactiveTimer)
		{
			this._ArsServerIPAddress = ARSServerIPAddress;
			this._RadioIPAddressFromServer = RadioIPFromServer;
			this._EnteredRadioIPAddress = EnteredRadioIPAddress;
			this._ArsServerTimeout = ArsServerTimeout;
			this._UseARSServer = UseARSServer;
			this._EnteredRadioID = EnteredRadioID;
			this._SessionInactiveTimer = SessionInactiveTimer;
		}

		// Token: 0x0400043A RID: 1082
		internal string _ArsServerIPAddress;

		// Token: 0x0400043B RID: 1083
		internal string _RadioIPAddressFromServer;

		// Token: 0x0400043C RID: 1084
		internal string _EnteredRadioIPAddress;

		// Token: 0x0400043D RID: 1085
		internal string _ArsServerTimeout;

		// Token: 0x0400043E RID: 1086
		internal bool? _UseARSServer;

		// Token: 0x0400043F RID: 1087
		internal string _EnteredRadioID;

		// Token: 0x04000440 RID: 1088
		internal string _SessionInactiveTimer;
	}
}
