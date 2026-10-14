using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000070 RID: 112
	public interface ISet : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000465 RID: 1125
		void Add(object o);

		// Token: 0x06000466 RID: 1126
		void AddAll(global::System.Collections.IEnumerable e);

		// Token: 0x06000467 RID: 1127
		void Clear();

		// Token: 0x06000468 RID: 1128
		bool Contains(object o);

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000469 RID: 1129
		bool IsEmpty { get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600046A RID: 1130
		bool IsFixedSize { get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600046B RID: 1131
		bool IsReadOnly { get; }

		// Token: 0x0600046C RID: 1132
		void Remove(object o);

		// Token: 0x0600046D RID: 1133
		void RemoveAll(global::System.Collections.IEnumerable e);
	}
}
