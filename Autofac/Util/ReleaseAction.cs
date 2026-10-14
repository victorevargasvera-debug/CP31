using System;

namespace Autofac.Util
{
	// Token: 0x02000021 RID: 33
	internal class ReleaseAction<TLimit> : global::Autofac.Util.Disposable
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00004CFD File Offset: 0x00002EFD
		public ReleaseAction(global::System.Action<TLimit> action, global::System.Func<TLimit> factory)
		{
			if (action == null)
			{
				throw new global::System.ArgumentNullException("action");
			}
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			this._action = action;
			this._factory = factory;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004D2F File Offset: 0x00002F2F
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._action(this._factory());
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000026 RID: 38
		private readonly global::System.Action<TLimit> _action;

		// Token: 0x04000027 RID: 39
		private readonly global::System.Func<TLimit> _factory;
	}
}
