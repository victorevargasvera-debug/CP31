using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200018F RID: 399
	public abstract class ClassComparer<T> : global::System.Collections.Generic.IComparer<T> where T : class
	{
		// Token: 0x06000D5A RID: 3418
		protected abstract int CompareOverride(T x, T y);

		// Token: 0x06000D5B RID: 3419 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
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
