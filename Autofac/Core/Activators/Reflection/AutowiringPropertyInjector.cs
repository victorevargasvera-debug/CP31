using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Util;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A5 RID: 165
	internal class AutowiringPropertyInjector
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0000B678 File Offset: 0x00009878
		public static void InjectProperties(global::Autofac.IComponentContext context, object instance, global::Autofac.Core.IPropertySelector propertySelector, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			if (propertySelector == null)
			{
				throw new global::System.ArgumentNullException("propertySelector");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			global::System.Type type = instance.GetType();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in from pi in type.GetRuntimeProperties()
			where pi.CanWrite
			select pi)
			{
				global::System.Type propertyType = propertyInfo.PropertyType;
				if ((!propertyType.GetTypeInfo().IsValueType || propertyType.GetTypeInfo().IsEnum) && (!propertyType.IsArray || !propertyType.GetElementType().GetTypeInfo().IsValueType) && (!propertyType.IsGenericEnumerableInterfaceType() || !propertyType.GetTypeInfo().GenericTypeArguments[0].GetTypeInfo().IsValueType) && propertyInfo.GetIndexParameters().Length == 0 && propertySelector.InjectProperty(propertyInfo, instance))
				{
					global::System.Reflection.ParameterInfo setParameter = propertyInfo.SetMethod.GetParameters().First<global::System.Reflection.ParameterInfo>();
					global::System.Func<object> valueProvider = null;
					if (parameters.FirstOrDefault((global::Autofac.Core.Parameter p) => p.CanSupplyValue(setParameter, context, out valueProvider)) != null)
					{
						propertyInfo.SetValue(instance, valueProvider(), null);
					}
					else
					{
						global::Autofac.Core.TypedService service = new global::Autofac.Core.TypedService(propertyType);
						global::Autofac.NamedParameter namedParameter = new global::Autofac.NamedParameter("Autofac.AutowiringPropertyInjector.InstanceType", type);
						object value;
						if (context.TryResolveService(service, new global::Autofac.Core.Parameter[]
						{
							namedParameter
						}, out value))
						{
							propertyInfo.SetValue(instance, value, null);
						}
					}
				}
			}
		}

		// Token: 0x040000FF RID: 255
		public const string InstanceTypeNamedParameter = "Autofac.AutowiringPropertyInjector.InstanceType";
	}
}
