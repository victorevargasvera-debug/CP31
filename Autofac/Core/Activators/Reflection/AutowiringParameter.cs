using System;
using System.Linq;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A4 RID: 164
	public class AutowiringParameter : global::Autofac.Core.Parameter
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x0000B5FC File Offset: 0x000097FC
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
			global::Autofac.Core.IComponentRegistration registration;
			if (context.ComponentRegistry.TryGetRegistration(new global::Autofac.Core.TypedService(pi.ParameterType), out registration))
			{
				valueProvider = (() => context.ResolveComponent(registration, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>()));
				return true;
			}
			valueProvider = null;
			return false;
		}
	}
}
