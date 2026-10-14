using System;
using System.Linq;
using System.Reflection;
using Autofac.Builder;

namespace Autofac.Features.AttributeFilters
{
	// Token: 0x02000056 RID: 86
	public static class RegistrationExtensions
	{
		// Token: 0x0600021D RID: 541 RVA: 0x000081E4 File Offset: 0x000063E4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TRegistrationStyle> WithAttributeFiltering<TLimit, TReflectionActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TRegistrationStyle> builder) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			return builder.WithParameter((global::System.Reflection.ParameterInfo p, global::Autofac.IComponentContext c) => p.GetCustomAttributes(true).Any<global::Autofac.Features.AttributeFilters.ParameterFilterAttribute>(), (global::System.Reflection.ParameterInfo p, global::Autofac.IComponentContext c) => p.GetCustomAttributes(true).First<global::Autofac.Features.AttributeFilters.ParameterFilterAttribute>().ResolveParameter(p, c));
		}
	}
}
