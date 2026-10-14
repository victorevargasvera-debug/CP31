using System;
using Loupe.Extensibility.Client;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000052 RID: 82
	internal interface IRepositoryExtensionContext : global::Loupe.Extensibility.Client.IGlobalContext
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004A6 RID: 1190
		global::Loupe.Extensibility.Server.IServerRepository Repository { get; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060004A7 RID: 1191
		// (remove) Token: 0x060004A8 RID: 1192
		event global::Loupe.Extensibility.Server.SessionEventHandler SessionAdded;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060004A9 RID: 1193
		// (remove) Token: 0x060004AA RID: 1194
		event global::Loupe.Extensibility.Server.SessionEventHandler SessionDataAdded;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060004AB RID: 1195
		// (remove) Token: 0x060004AC RID: 1196
		event global::Loupe.Extensibility.Server.SessionEventHandler SessionDataRemoved;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060004AD RID: 1197
		// (remove) Token: 0x060004AE RID: 1198
		event global::Loupe.Extensibility.Server.LogEventEventHandler LogEventAdded;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060004AF RID: 1199
		// (remove) Token: 0x060004B0 RID: 1200
		event global::Loupe.Extensibility.Server.LogEventEventHandler LogEventChanged;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060004B1 RID: 1201
		// (remove) Token: 0x060004B2 RID: 1202
		event global::Loupe.Extensibility.Server.ApplicationEventEventHandler ApplicationEventAdded;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060004B3 RID: 1203
		// (remove) Token: 0x060004B4 RID: 1204
		event global::Loupe.Extensibility.Server.ApplicationEventEventHandler ApplicationEventChanged;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060004B5 RID: 1205
		// (remove) Token: 0x060004B6 RID: 1206
		event global::Loupe.Extensibility.Server.ApplicationEventEventHandler ApplicationEventReview;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060004B7 RID: 1207
		// (remove) Token: 0x060004B8 RID: 1208
		event global::Loupe.Extensibility.Server.IssueEventHandler IssueAdded;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060004B9 RID: 1209
		// (remove) Token: 0x060004BA RID: 1210
		event global::Loupe.Extensibility.Server.IssueEventHandler IssueActivated;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060004BB RID: 1211
		// (remove) Token: 0x060004BC RID: 1212
		event global::Loupe.Extensibility.Server.IssueEventHandler IssueChanged;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060004BD RID: 1213
		// (remove) Token: 0x060004BE RID: 1214
		event global::Loupe.Extensibility.Server.IssueEventHandler IssueClosed;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060004BF RID: 1215
		// (remove) Token: 0x060004C0 RID: 1216
		event global::Loupe.Extensibility.Server.UserEventHandler UserAdded;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060004C1 RID: 1217
		// (remove) Token: 0x060004C2 RID: 1218
		event global::Loupe.Extensibility.Server.UserEventHandler UserChanged;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060004C3 RID: 1219
		// (remove) Token: 0x060004C4 RID: 1220
		event global::Loupe.Extensibility.Server.UserEventHandler UserRemoved;

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004C5 RID: 1221
		global::Loupe.Extensibility.Client.IRepositoryConfiguration Configuration { get; }
	}
}
