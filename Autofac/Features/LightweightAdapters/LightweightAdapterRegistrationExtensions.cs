using System;
using System.Collections.Generic;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.LightweightAdapters
{
	// Token: 0x02000042 RID: 66
	internal static class LightweightAdapterRegistrationExtensions
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00007108 File Offset: 0x00005308
		public static global::Autofac.Builder.IRegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAdapter<TFrom, TTo>(global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, TFrom, TTo> adapter)
		{
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterAdapter<TFrom, TTo>(builder, adapter, new global::Autofac.Core.TypedService(typeof(TFrom)), new global::Autofac.Core.TypedService(typeof(TTo)));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000712F File Offset: 0x0000532F
		public static global::Autofac.Builder.IRegistrationBuilder<TService, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterDecorator<TService>(global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, TService, TService> decorator, object fromKey, object toKey)
		{
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterAdapter<TService, TService>(builder, decorator, global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.ServiceWithKey<TService>(fromKey), global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.ServiceWithKey<TService>(toKey));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00007144 File Offset: 0x00005344
		private static global::Autofac.Core.Service ServiceWithKey<TService>(object key)
		{
			if (key == null)
			{
				return new global::Autofac.Core.TypedService(typeof(TService));
			}
			return new global::Autofac.Core.KeyedService(key, typeof(TService));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000716C File Offset: 0x0000536C
		private static global::Autofac.Builder.IRegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAdapter<TFrom, TTo>(global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, TFrom, TTo> adapter, global::Autofac.Core.Service fromService, global::Autofac.Core.Service toService)
		{
			global::Autofac.Builder.RegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle>(toService, new global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData(fromService, (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p, object f) => adapter(c, p, (TFrom)((object)f))), new global::Autofac.Builder.DynamicRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				cr.AddRegistrationSource(new global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSource(rb.RegistrationData, rb.ActivatorData));
			});
			return rb;
		}
	}
}
