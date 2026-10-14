using System;
using Autofac.Util;

namespace Autofac.Core.Activators
{
	// Token: 0x020000A3 RID: 163
	public abstract class InstanceActivator : global::Autofac.Util.Disposable
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0000B5A7 File Offset: 0x000097A7
		protected InstanceActivator(global::System.Type limitType)
		{
			if (limitType == null)
			{
				throw new global::System.ArgumentNullException("limitType");
			}
			this.LimitType = limitType;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000B5CA File Offset: 0x000097CA
		public global::System.Type LimitType { get; }

		// Token: 0x060003D5 RID: 981 RVA: 0x0000B5D2 File Offset: 0x000097D2
		public override string ToString()
		{
			return this.LimitType.Name + " (" + base.GetType().Name + ")";
		}
	}
}
