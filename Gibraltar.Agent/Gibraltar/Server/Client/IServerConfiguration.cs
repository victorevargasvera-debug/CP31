using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x020000D2 RID: 210
	internal interface IServerConfiguration
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060008AE RID: 2222
		// (set) Token: 0x060008AF RID: 2223
		bool Enabled { get; set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060008B0 RID: 2224
		// (set) Token: 0x060008B1 RID: 2225
		bool AutoSendSessions { get; set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060008B2 RID: 2226
		// (set) Token: 0x060008B3 RID: 2227
		bool AutoSendOnError { get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060008B4 RID: 2228
		// (set) Token: 0x060008B5 RID: 2229
		bool SendAllApplications { get; set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060008B6 RID: 2230
		// (set) Token: 0x060008B7 RID: 2231
		bool PurgeSentSessions { get; set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060008B8 RID: 2232
		// (set) Token: 0x060008B9 RID: 2233
		string CustomerName { get; set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060008BA RID: 2234
		// (set) Token: 0x060008BB RID: 2235
		bool UseGibraltarService { get; set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060008BC RID: 2236
		// (set) Token: 0x060008BD RID: 2237
		bool UseSsl { get; set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060008BE RID: 2238
		// (set) Token: 0x060008BF RID: 2239
		string Server { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060008C0 RID: 2240
		// (set) Token: 0x060008C1 RID: 2241
		int Port { get; set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060008C2 RID: 2242
		// (set) Token: 0x060008C3 RID: 2243
		string ApplicationBaseDirectory { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060008C4 RID: 2244
		// (set) Token: 0x060008C5 RID: 2245
		string Repository { get; set; }
	}
}
