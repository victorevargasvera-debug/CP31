using System;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000BA RID: 186
	public class DeferredCallback
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0000C947 File Offset: 0x0000AB47
		public DeferredCallback(global::System.Action<global::Autofac.Core.IComponentRegistry> callback)
		{
			if (callback == null)
			{
				throw new global::System.ArgumentNullException("callback");
			}
			this.Id = global::System.Guid.NewGuid();
			this.Callback = callback;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000C96F File Offset: 0x0000AB6F
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0000C977 File Offset: 0x0000AB77
		public global::System.Action<global::Autofac.Core.IComponentRegistry> Callback
		{
			get
			{
				return this._callback;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._callback = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000C98E File Offset: 0x0000AB8E
		public global::System.Guid Id { get; }

		// Token: 0x04000126 RID: 294
		private global::System.Action<global::Autofac.Core.IComponentRegistry> _callback;
	}
}
