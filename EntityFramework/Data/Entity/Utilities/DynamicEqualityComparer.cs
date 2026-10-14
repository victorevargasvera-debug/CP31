using System;
using System.Collections.Generic;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007B RID: 123
	internal sealed class DynamicEqualityComparer<T> : global::System.Collections.Generic.IEqualityComparer<T> where T : class
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x0000EC80 File Offset: 0x0000CE80
		public DynamicEqualityComparer(global::System.Func<T, T, bool> func)
		{
			this._func = func;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000EC8F File Offset: 0x0000CE8F
		public bool Equals(T x, T y)
		{
			return this._func(x, y);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000EC9E File Offset: 0x0000CE9E
		public int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x04000112 RID: 274
		private readonly global::System.Func<T, T, bool> _func;
	}
}
