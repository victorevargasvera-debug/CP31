using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x02000074 RID: 116
	public abstract class Parameter
	{
		// Token: 0x060002A0 RID: 672
		public abstract bool CanSupplyValue(global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext context, out global::System.Func<object> valueProvider);
	}
}
