using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility
{
	// Token: 0x0200004E RID: 78
	internal interface IRepository
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000486 RID: 1158
		// (remove) Token: 0x06000487 RID: 1159
		event global::System.ComponentModel.CollectionChangeEventHandler CollectionChanged;

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000488 RID: 1160
		global::System.Guid Id { get; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000489 RID: 1161
		bool IsDirty { get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600048A RID: 1162
		bool IsReadOnly { get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600048B RID: 1163
		string Name { get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600048C RID: 1164
		string Caption { get; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600048D RID: 1165
		string Description { get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600048E RID: 1166
		bool SupportsFragments { get; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600048F RID: 1167
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IRepositoryProduct> Products { get; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000490 RID: 1168
		global::Loupe.Extensibility.Data.ISessionSummaryCollection Sessions { get; }

		// Token: 0x06000491 RID: 1169
		global::System.Collections.Generic.IList<global::System.Guid> GetSessionFileIds(global::System.Guid sessionId);

		// Token: 0x06000492 RID: 1170
		global::Loupe.Extensibility.Data.ISession LoadSession(global::System.Guid sessionId);

		// Token: 0x06000493 RID: 1171
		global::System.IO.Stream LoadSessionStream(global::System.Guid sessionId);

		// Token: 0x06000494 RID: 1172
		global::System.IO.Stream LoadSessionFileStream(global::System.Guid sessionId, global::System.Guid fileId);

		// Token: 0x06000495 RID: 1173
		bool Remove(global::System.Guid sessionId);

		// Token: 0x06000496 RID: 1174
		bool Remove(global::System.Collections.Generic.IList<global::System.Guid> sessionIds);

		// Token: 0x06000497 RID: 1175
		bool SessionDataExists(global::System.Guid sessionId);

		// Token: 0x06000498 RID: 1176
		bool SessionDataExists(global::System.Guid sessionId, global::System.Guid fileId);

		// Token: 0x06000499 RID: 1177
		bool SessionExists(global::System.Guid sessionId);

		// Token: 0x0600049A RID: 1178
		bool SetSessionsNew(global::System.Collections.Generic.IList<global::System.Guid> sessionIds, bool isNew);

		// Token: 0x0600049B RID: 1179
		global::Loupe.Extensibility.Data.ISessionSummaryCollection Find(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match);
	}
}
