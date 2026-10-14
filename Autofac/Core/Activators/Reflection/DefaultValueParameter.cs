using System;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A9 RID: 169
	public class DefaultValueParameter : global::Autofac.Core.Parameter
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x0000BD64 File Offset: 0x00009F64
		public override bool CanSupplyValue(global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext context, out global::System.Func<object> valueProvider)
		{
			if (pi == null)
			{
				throw new global::System.ArgumentNullException("pi");
			}
			bool tryToGetDefaultValue = true;
			bool flag;
			try
			{
				global::System.Type declaringType = pi.Member.DeclaringType;
				if (declaringType == null || declaringType.GetTypeInfo().Assembly.IsDynamic)
				{
					flag = (pi.DefaultValue != null && pi.HasDefaultValue);
				}
				else
				{
					flag = pi.HasDefaultValue;
				}
			}
			catch (global::System.FormatException obj) when (pi.ParameterType == typeof(global::System.DateTime))
			{
				flag = true;
				tryToGetDefaultValue = false;
			}
			if (flag)
			{
				valueProvider = delegate()
				{
					if (!tryToGetDefaultValue)
					{
						return default(global::System.DateTime);
					}
					object obj = pi.DefaultValue;
					if (obj == null && pi.ParameterType.GetTypeInfo().IsValueType)
					{
						obj = global::System.Activator.CreateInstance(pi.ParameterType);
					}
					return obj;
				};
				return true;
			}
			valueProvider = null;
			return false;
		}
	}
}
