using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000057 RID: 87
	public class ActivatedEventArgs<T> : global::System.EventArgs, global::Autofac.Core.IActivatedEventArgs<T>
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00008244 File Offset: 0x00006444
		public ActivatedEventArgs(global::Autofac.IComponentContext context, global::Autofac.Core.IComponentRegistration component, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, T instance)
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
			this.Instance = instance;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000082B2 File Offset: 0x000064B2
		public global::Autofac.IComponentContext Context { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000082BA File Offset: 0x000064BA
		public global::Autofac.Core.IComponentRegistration Component { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000082C2 File Offset: 0x000064C2
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000082CA File Offset: 0x000064CA
		public T Instance { get; }
	}
}
