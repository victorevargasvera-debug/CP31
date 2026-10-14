using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000058 RID: 88
	public class ActivatingEventArgs<T> : global::System.EventArgs, global::Autofac.Core.IActivatingEventArgs<T>
	{
		// Token: 0x06000223 RID: 547 RVA: 0x000082D4 File Offset: 0x000064D4
		public ActivatingEventArgs(global::Autofac.IComponentContext context, global::Autofac.Core.IComponentRegistration component, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, T instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (component == null)
			{
				throw new global::System.ArgumentNullException("component");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			this.Context = context;
			this.Component = component;
			this.Parameters = parameters;
			this._instance = instance;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00008342 File Offset: 0x00006542
		public global::Autofac.IComponentContext Context { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000834A File Offset: 0x0000654A
		public global::Autofac.Core.IComponentRegistration Component { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00008352 File Offset: 0x00006552
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0000835A File Offset: 0x0000655A
		public T Instance
		{
			get
			{
				return this._instance;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._instance = value;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008376 File Offset: 0x00006576
		public void ReplaceInstance(object instance)
		{
			this.Instance = (T)((object)instance);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00008384 File Offset: 0x00006584
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }

		// Token: 0x04000075 RID: 117
		private T _instance;
	}
}
