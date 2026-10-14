using System;
using System.Globalization;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000030 RID: 48
	public class OpenGenericDecoratorActivatorData : global::Autofac.Builder.ReflectionActivatorData
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public OpenGenericDecoratorActivatorData(global::System.Type implementer, global::Autofac.Core.IServiceWithType fromService) : base(implementer)
		{
			if (fromService == null)
			{
				throw new global::System.ArgumentNullException("fromService");
			}
			if (!fromService.ServiceType.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.DecoratedServiceIsNotOpenGeneric, new object[]
				{
					fromService
				}));
			}
			this.FromService = fromService;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00005DFA File Offset: 0x00003FFA
		public global::Autofac.Core.IServiceWithType FromService { get; }
	}
}
