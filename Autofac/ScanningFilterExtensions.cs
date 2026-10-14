using System;
using System.Reflection;
using Autofac.Builder;
using Autofac.Features.Scanning;

namespace Autofac
{
	// Token: 0x02000015 RID: 21
	public static class ScanningFilterExtensions
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000042CB File Offset: 0x000024CB
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> PublicOnly<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return from t in registration
			where t.GetTypeInfo().IsPublic || t.GetTypeInfo().IsNestedPublic
			select t;
		}
	}
}
