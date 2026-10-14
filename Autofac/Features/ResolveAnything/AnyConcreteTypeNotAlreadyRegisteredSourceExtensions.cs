using System;
using Autofac.Builder;

namespace Autofac.Features.ResolveAnything
{
	// Token: 0x0200002B RID: 43
	public static class AnyConcreteTypeNotAlreadyRegisteredSourceExtensions
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00005B81 File Offset: 0x00003D81
		public static global::Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSource WithRegistrationsAs(this global::Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSource source, global::System.Action<global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>> configurationAction)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			source.RegistrationConfiguration = configurationAction;
			return source;
		}
	}
}
