using System;
using System.Data.Entity.Resources;
using System.Threading;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200012D RID: 301
	internal class ThrowingMonitor
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x00034FC6 File Offset: 0x000331C6
		public void Enter()
		{
			if (global::System.Threading.Interlocked.CompareExchange(ref this._isInCriticalSection, 1, 0) != 0)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ConcurrentMethodInvocation);
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00034FE2 File Offset: 0x000331E2
		public void Exit()
		{
			global::System.Threading.Interlocked.Exchange(ref this._isInCriticalSection, 0);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00034FF1 File Offset: 0x000331F1
		public void EnsureNotEntered()
		{
			global::System.Threading.Thread.MemoryBarrier();
			if (this._isInCriticalSection != 0)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ConcurrentMethodInvocation);
			}
		}

		// Token: 0x040009B5 RID: 2485
		private int _isInCriticalSection;
	}
}
