using System;
using System.Threading;

namespace Autofac.Util
{
	// Token: 0x0200001A RID: 26
	public class Disposable : global::System.IDisposable
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000045DC File Offset: 0x000027DC
		public void Dispose()
		{
			if (global::System.Threading.Interlocked.Exchange(ref this._isDisposed, 1) == 1)
			{
				return;
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000045FB File Offset: 0x000027FB
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000045FD File Offset: 0x000027FD
		protected bool IsDisposed
		{
			get
			{
				global::System.Threading.Interlocked.MemoryBarrier();
				return this._isDisposed == 1;
			}
		}

		// Token: 0x0400001C RID: 28
		private const int DisposedFlag = 1;

		// Token: 0x0400001D RID: 29
		private int _isDisposed;
	}
}
