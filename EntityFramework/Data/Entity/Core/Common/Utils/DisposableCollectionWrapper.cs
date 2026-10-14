using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F5 RID: 1525
	internal class DisposableCollectionWrapper<T> : global::System.IDisposable, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable where T : global::System.IDisposable
	{
		// Token: 0x06004AAF RID: 19119 RVA: 0x00107D94 File Offset: 0x00105F94
		internal DisposableCollectionWrapper(global::System.Collections.Generic.IEnumerable<T> enumerable)
		{
			this._enumerable = enumerable;
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00107DA4 File Offset: 0x00105FA4
		public void Dispose()
		{
			global::System.GC.SuppressFinalize(this);
			if (this._enumerable != null)
			{
				foreach (T t in this._enumerable)
				{
					if (t != null)
					{
						t.Dispose();
					}
				}
			}
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00107E10 File Offset: 0x00106010
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this._enumerable.GetEnumerator();
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00107E1D File Offset: 0x0010601D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._enumerable.GetEnumerator();
		}

		// Token: 0x04001A45 RID: 6725
		private readonly global::System.Collections.Generic.IEnumerable<T> _enumerable;
	}
}
