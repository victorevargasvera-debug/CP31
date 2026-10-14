using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000075 RID: 117
	public class PreparingEventArgs : global::System.EventArgs
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00008A68 File Offset: 0x00006C68
		public PreparingEventArgs(global::Autofac.IComponentContext context, global::Autofac.Core.IComponentRegistration component, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
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
			this.Context = context;
			this.Component = component;
			this._parameters = parameters;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00008ABA File Offset: 0x00006CBA
		public global::Autofac.IComponentContext Context { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00008AC2 File Offset: 0x00006CC2
		public global::Autofac.Core.IComponentRegistration Component { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00008ACA File Offset: 0x00006CCA
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00008AD2 File Offset: 0x00006CD2
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._parameters = value;
			}
		}

		// Token: 0x04000092 RID: 146
		private global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> _parameters;
	}
}
