using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000663 RID: 1635
	internal sealed class Pair<L, R>
	{
		// Token: 0x06004E37 RID: 20023 RVA: 0x001181C1 File Offset: 0x001163C1
		internal Pair(L left, R right)
		{
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x001181D7 File Offset: 0x001163D7
		internal global::System.Collections.Generic.KeyValuePair<L, R> GetKVP()
		{
			return new global::System.Collections.Generic.KeyValuePair<L, R>(this.Left, this.Right);
		}

		// Token: 0x04001C5E RID: 7262
		internal L Left;

		// Token: 0x04001C5F RID: 7263
		internal R Right;
	}
}
