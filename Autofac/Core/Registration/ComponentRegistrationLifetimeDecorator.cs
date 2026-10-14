using System;
using System.Collections.Generic;
using Autofac.Util;

namespace Autofac.Core.Registration
{
	// Token: 0x0200008F RID: 143
	internal class ComponentRegistrationLifetimeDecorator : global::Autofac.Util.Disposable, global::Autofac.Core.IComponentRegistration, global::System.IDisposable
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00009EF4 File Offset: 0x000080F4
		public ComponentRegistrationLifetimeDecorator(global::Autofac.Core.IComponentRegistration inner, global::Autofac.Core.IComponentLifetime lifetime)
		{
			if (inner == null)
			{
				throw new global::System.ArgumentNullException("inner");
			}
			this._inner = inner;
			if (lifetime == null)
			{
				throw new global::System.ArgumentNullException("lifetime");
			}
			this.Lifetime = lifetime;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00009F28 File Offset: 0x00008128
		public global::System.Guid Id
		{
			get
			{
				return this._inner.Id;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00009F35 File Offset: 0x00008135
		public global::Autofac.Core.IInstanceActivator Activator
		{
			get
			{
				return this._inner.Activator;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00009F42 File Offset: 0x00008142
		public global::Autofac.Core.IComponentLifetime Lifetime { get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00009F4A File Offset: 0x0000814A
		public global::Autofac.Core.InstanceSharing Sharing
		{
			get
			{
				return this._inner.Sharing;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00009F57 File Offset: 0x00008157
		public global::Autofac.Core.InstanceOwnership Ownership
		{
			get
			{
				return this._inner.Ownership;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00009F64 File Offset: 0x00008164
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> Services
		{
			get
			{
				return this._inner.Services;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00009F71 File Offset: 0x00008171
		public global::System.Collections.Generic.IDictionary<string, object> Metadata
		{
			get
			{
				return this._inner.Metadata;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00009F80 File Offset: 0x00008180
		public global::Autofac.Core.IComponentRegistration Target
		{
			get
			{
				if (!this._inner.IsAdapting())
				{
					return this;
				}
				return this._inner.Target;
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000345 RID: 837 RVA: 0x00009FA9 File Offset: 0x000081A9
		// (remove) Token: 0x06000346 RID: 838 RVA: 0x00009FB7 File Offset: 0x000081B7
		public event global::System.EventHandler<global::Autofac.Core.PreparingEventArgs> Preparing
		{
			add
			{
				this._inner.Preparing += value;
			}
			remove
			{
				this._inner.Preparing -= value;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00009FC5 File Offset: 0x000081C5
		public void RaisePreparing(global::Autofac.IComponentContext context, ref global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			this._inner.RaisePreparing(context, ref parameters);
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000348 RID: 840 RVA: 0x00009FD4 File Offset: 0x000081D4
		// (remove) Token: 0x06000349 RID: 841 RVA: 0x00009FE2 File Offset: 0x000081E2
		public event global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>> Activating
		{
			add
			{
				this._inner.Activating += value;
			}
			remove
			{
				this._inner.Activating -= value;
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00009FF0 File Offset: 0x000081F0
		public void RaiseActivating(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, ref object instance)
		{
			this._inner.RaiseActivating(context, parameters, ref instance);
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600034B RID: 843 RVA: 0x0000A000 File Offset: 0x00008200
		// (remove) Token: 0x0600034C RID: 844 RVA: 0x0000A00E File Offset: 0x0000820E
		public event global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>> Activated
		{
			add
			{
				this._inner.Activated += value;
			}
			remove
			{
				this._inner.Activated -= value;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000A01C File Offset: 0x0000821C
		public void RaiseActivated(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, object instance)
		{
			this._inner.RaiseActivated(context, parameters, instance);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000A02C File Offset: 0x0000822C
		protected override void Dispose(bool disposing)
		{
			this._inner.Dispose();
		}

		// Token: 0x040000CE RID: 206
		private readonly global::Autofac.Core.IComponentRegistration _inner;
	}
}
