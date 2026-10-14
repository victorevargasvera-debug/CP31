using System;
using System.Reflection;

namespace Autofac.Features.AttributeFilters
{
	// Token: 0x02000055 RID: 85
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter)]
	public abstract class ParameterFilterAttribute : global::System.Attribute
	{
		// Token: 0x0600021B RID: 539
		public abstract object ResolveParameter(global::System.Reflection.ParameterInfo parameter, global::Autofac.IComponentContext context);
	}
}
