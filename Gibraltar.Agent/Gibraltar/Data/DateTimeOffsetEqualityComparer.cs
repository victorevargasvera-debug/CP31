using System;
using System.Collections.Generic;

namespace Gibraltar.Data
{
	// Token: 0x020000E6 RID: 230
	internal class DateTimeOffsetEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::System.DateTimeOffset>
	{
		// Token: 0x06000979 RID: 2425 RVA: 0x00016C88 File Offset: 0x00014E88
		public bool Equals(global::System.DateTimeOffset x, global::System.DateTimeOffset y)
		{
			return x.EqualsExact(y);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00016C94 File Offset: 0x00014E94
		public int GetHashCode(global::System.DateTimeOffset obj)
		{
			return obj.GetHashCode();
		}
	}
}
