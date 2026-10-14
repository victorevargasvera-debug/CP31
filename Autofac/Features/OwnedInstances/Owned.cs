using System;
using System.Threading;
using Autofac.Util;

namespace Autofac.Features.OwnedInstances
{
	// Token: 0x0200002D RID: 45
	public class Owned<T> : global::Autofac.Util.Disposable
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00005BF7 File Offset: 0x00003DF7
		public Owned(T value, global::System.IDisposable lifetime)
		{
			if (lifetime == null)
			{
				throw new global::System.ArgumentNullException("lifetime");
			}
			this.Value = value;
			this._lifetime = lifetime;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00005C1B File Offset: 0x00003E1B
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00005C23 File Offset: 0x00003E23
		public T Value { get; set; }

		// Token: 0x06000164 RID: 356 RVA: 0x00005C2C File Offset: 0x00003E2C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				global::System.IDisposable disposable = global::System.Threading.Interlocked.Exchange<global::System.IDisposable>(ref this._lifetime, null);
				if (disposable != null)
				{
					this.Value = default(T);
					disposable.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000034 RID: 52
		private global::System.IDisposable _lifetime;
	}
}
