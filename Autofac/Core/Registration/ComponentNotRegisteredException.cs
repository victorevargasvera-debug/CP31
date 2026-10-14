using System;
using System.Globalization;

namespace Autofac.Core.Registration
{
	// Token: 0x0200008B RID: 139
	public class ComponentNotRegisteredException : global::Autofac.Core.DependencyResolutionException
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00009AC6 File Offset: 0x00007CC6
		public ComponentNotRegisteredException(global::Autofac.Core.Service service) : base(global::Autofac.Core.Registration.ComponentNotRegisteredException.FormatMessage(service))
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public ComponentNotRegisteredException(global::Autofac.Core.Service service, global::System.Exception innerException) : base(global::Autofac.Core.Registration.ComponentNotRegisteredException.FormatMessage(service), innerException)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00009AE3 File Offset: 0x00007CE3
		private static string FormatMessage(global::Autofac.Core.Service service)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.Message, new object[]
			{
				service
			});
		}
	}
}
