using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200016D RID: 365
	public abstract class ClassComparer<T> : global::System.Collections.Generic.IComparer<T> where T : class
	{
		// Token: 0x06000C45 RID: 3141
		protected abstract int CompareOverride(T x, T y);

		// Token: 0x06000C46 RID: 3142 RVA: 0x00027D68 File Offset: 0x00025F68
		public int Compare(T x, T y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			return this.CompareOverride(x, y);
		}
	}
}
