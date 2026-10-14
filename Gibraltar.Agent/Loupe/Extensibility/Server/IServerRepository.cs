using System;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000053 RID: 83
	internal interface IServerRepository : global::Loupe.Extensibility.IRepository
	{
		// Token: 0x060004C6 RID: 1222
		global::Loupe.Extensibility.Data.IIssue GetIssue(string name);

		// Token: 0x060004C7 RID: 1223
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IIssue> GetIssue(global::Loupe.Extensibility.Data.IIssueLinkType linkType, string value);

		// Token: 0x060004C8 RID: 1224
		global::Loupe.Extensibility.Data.IIssueLinkType AddIssueLinkType(string name, string caption, string description, string urlTemplate);

		// Token: 0x060004C9 RID: 1225
		void RemoveIssueLinkType(string name, bool removeExistingLinks);

		// Token: 0x060004CA RID: 1226
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IIssueLinkType> GetIssueLinkTypes();

		// Token: 0x060004CB RID: 1227
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IUserProfile> GetUserProfiles();
	}
}
