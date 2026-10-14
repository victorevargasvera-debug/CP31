using System;
using System.Collections.Generic;

namespace NPOI.Util
{
	// Token: 0x02000283 RID: 643
	public class ReferenceEqualityComparer : global::System.Collections.Generic.EqualityComparer<object>
	{
		// Token: 0x06001150 RID: 4432 RVA: 0x000344D0 File Offset: 0x000326D0
		public override bool Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000344D6 File Offset: 0x000326D6
		public override int GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}
	}
}
