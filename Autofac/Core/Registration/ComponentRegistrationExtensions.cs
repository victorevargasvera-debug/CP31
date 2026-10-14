using System;

namespace Autofac.Core.Registration
{
	// Token: 0x0200008E RID: 142
	internal static class ComponentRegistrationExtensions
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00009EE6 File Offset: 0x000080E6
		public static bool IsAdapting(this global::Autofac.Core.IComponentRegistration componentRegistration)
		{
			return componentRegistration.Target != componentRegistration;
		}
	}
}
