using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x020000A7 RID: 167
	internal class DisposableList<T> : global::System.IDisposable where T : global::System.IDisposable
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public global::System.Collections.Generic.List<T> List
		{
			get
			{
				return this.m_Items;
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (T t in this.m_Items)
				{
					try
					{
						t.Dispose();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x04000130 RID: 304
		private global::System.Collections.Generic.List<T> m_Items = new global::System.Collections.Generic.List<T>();
	}
}
