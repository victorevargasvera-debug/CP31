using System;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000C7 RID: 199
	internal static class RegistrationOrderExtensions
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x0000D798 File Offset: 0x0000B998
		internal static long GetRegistrationOrder(this global::Autofac.Core.IComponentRegistration registration)
		{
			object obj;
			if (!registration.Metadata.TryGetValue("__RegistrationOrder", out obj))
			{
				return long.MaxValue;
			}
			return (long)obj;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		internal static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> InheritRegistrationOrderFrom<TLimit, TActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> registration, global::Autofac.Core.IComponentRegistration source) where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			long registrationOrder = source.GetRegistrationOrder();
			registration.RegistrationData.Metadata["__RegistrationOrder"] = registrationOrder;
			return registration;
		}
	}
}
