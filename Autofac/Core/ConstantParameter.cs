using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x0200005F RID: 95
	public abstract class ConstantParameter : global::Autofac.Core.Parameter
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000084FE File Offset: 0x000066FE
		public object Value { get; }

		// Token: 0x0600023D RID: 573 RVA: 0x00008506 File Offset: 0x00006706
		protected ConstantParameter(object value, global::System.Predicate<global::System.Reflection.ParameterInfo> predicate)
		{
			if (predicate == null)
			{
				throw new global::System.ArgumentNullException("predicate");
			}
			this.Value = value;
			this._predicate = predicate;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000852A File Offset: 0x0000672A
		public override bool CanSupplyValue(global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext context, out global::System.Func<object> valueProvider)
		{
			if (pi == null)
			{
				throw new global::System.ArgumentNullException("pi");
			}
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (this._predicate(pi))
			{
				valueProvider = (() => this.Value);
				return true;
			}
			valueProvider = null;
			return false;
		}

		// Token: 0x0400007F RID: 127
		private readonly global::System.Predicate<global::System.Reflection.ParameterInfo> _predicate;
	}
}
