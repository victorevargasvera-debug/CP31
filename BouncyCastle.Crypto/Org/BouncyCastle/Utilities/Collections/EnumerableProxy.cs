using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200006E RID: 110
	public sealed class EnumerableProxy : global::System.Collections.IEnumerable
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00015DB6 File Offset: 0x00013FB6
		public EnumerableProxy(global::System.Collections.IEnumerable inner)
		{
			if (inner == null)
			{
				throw new global::System.ArgumentNullException("inner");
			}
			this.inner = inner;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00015DD3 File Offset: 0x00013FD3
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.inner.GetEnumerator();
		}

		// Token: 0x0400029F RID: 671
		private readonly global::System.Collections.IEnumerable inner;
	}
}
