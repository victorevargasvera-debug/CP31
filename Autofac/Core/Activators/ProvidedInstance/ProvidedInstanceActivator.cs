using System;
using System.Collections.Generic;
using System.Globalization;

namespace Autofac.Core.Activators.ProvidedInstance
{
	// Token: 0x020000B4 RID: 180
	public class ProvidedInstanceActivator : global::Autofac.Core.Activators.InstanceActivator, global::Autofac.Core.IInstanceActivator, global::System.IDisposable
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0000C700 File Offset: 0x0000A900
		public ProvidedInstanceActivator(object instance) : base(global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivator.GetType(instance))
		{
			this._instance = instance;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000C718 File Offset: 0x0000A918
		public object ActivateInstance(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (this._activated)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.InstanceAlreadyActivated, new object[]
				{
					this._instance.GetType()
				}));
			}
			this._activated = true;
			return this._instance;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000C77F File Offset: 0x0000A97F
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000C787 File Offset: 0x0000A987
		public bool DisposeInstance { get; set; }

		// Token: 0x06000422 RID: 1058 RVA: 0x0000C790 File Offset: 0x0000A990
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.DisposeInstance && this._instance is global::System.IDisposable && !this._activated)
			{
				((global::System.IDisposable)this._instance).Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
		private static global::System.Type GetType(object instance)
		{
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			return instance.GetType();
		}

		// Token: 0x0400011A RID: 282
		private readonly object _instance;

		// Token: 0x0400011B RID: 283
		private bool _activated;
	}
}
