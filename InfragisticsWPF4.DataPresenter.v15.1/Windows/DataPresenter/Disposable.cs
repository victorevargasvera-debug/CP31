using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000222 RID: 546
	internal class Disposable
	{
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0008D274 File Offset: 0x0008B474
		public bool IsDisposed
		{
			get
			{
				return this._isDisposed;
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0008D27C File Offset: 0x0008B47C
		public void Dispose()
		{
			this._isDisposed = true;
		}

		// Token: 0x04000DB2 RID: 3506
		private bool _isDisposed;
	}
}
