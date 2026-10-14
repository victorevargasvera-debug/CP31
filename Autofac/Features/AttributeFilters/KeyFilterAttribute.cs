using System;
using System.Reflection;

namespace Autofac.Features.AttributeFilters
{
	// Token: 0x02000053 RID: 83
	public sealed class KeyFilterAttribute : global::Autofac.Features.AttributeFilters.ParameterFilterAttribute
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00007F84 File Offset: 0x00006184
		public KeyFilterAttribute(object key)
		{
			this.Key = key;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00007F93 File Offset: 0x00006193
		public object Key { get; }

		// Token: 0x06000211 RID: 529 RVA: 0x00007F9C File Offset: 0x0000619C
		public override object ResolveParameter(global::System.Reflection.ParameterInfo parameter, global::Autofac.IComponentContext context)
		{
			if (parameter == null)
			{
				throw new global::System.ArgumentNullException("parameter");
			}
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			object result;
			context.TryResolveKeyed(this.Key, parameter.ParameterType, out result);
			return result;
		}
	}
}
