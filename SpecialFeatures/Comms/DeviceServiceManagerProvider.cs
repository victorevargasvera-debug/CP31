using System;
using Autofac;
using Autofac.Builder;
using Autofac.Features.ResolveAnything;
using Motorola.Common.Communication;
using Motorola.Common.Communication.Service;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000163 RID: 355
	public class DeviceServiceManagerProvider
	{
		// Token: 0x060011F5 RID: 4597 RVA: 0x0018705C File Offset: 0x0018525C
		private static global::Motorola.Common.Communication.Service.DeviceServiceManager a()
		{
			short num = (short)1743531532;
			short num2 = num;
			num = (short)30289420;
			switch (num2 == num)
			{
			}
			num = (short)1209270273;
			if (num != 0)
			{
			}
			num = (short)1782185984;
			if (num != 0)
			{
			}
			num = (short)135462912;
			short num3 = num;
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder();
			containerBuilder.RegisterModule<global::Motorola.Common.Communication.Service.CommunicationServiceModule>();
			containerBuilder.RegisterModule<global::Motorola.Common.Communication.AstroCommunicationModule>();
			containerBuilder.RegisterSource(new global::Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSource());
			return containerBuilder.Build(global::Autofac.Builder.ContainerBuildOptions.None).Resolve<global::Motorola.Common.Communication.Service.DeviceServiceManager>();
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00187130 File Offset: 0x00185330
		public static global::Motorola.Common.Communication.Service.DeviceServiceManager Instance
		{
			get
			{
				short num = (short)1657287912;
				short num2 = num;
				num = (short)673854696;
				switch (num2 == num)
				{
				}
				num = (short)1771634689;
				if (num != 0)
				{
				}
				num = (short)666238976;
				if (num != 0)
				{
				}
				num = (short)1807155200;
				short num3 = num;
				return global::SpecialFeatures.Comms.DeviceServiceManagerProvider.a.Value;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x001871E8 File Offset: 0x001853E8
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceServiceManagerProvider()
		{
			short num = (short)1291124737;
			if (num != 0)
			{
			}
			num = (short)902540223;
			short num2 = num;
			num = (short)851880895;
			switch (num2 == num)
			{
			}
			num = (short)324272128;
			if (num != 0)
			{
			}
			num = (short)1481834496;
			short num3 = num;
			global::SpecialFeatures.Comms.DeviceServiceManagerProvider.a = new global::System.Lazy<global::Motorola.Common.Communication.Service.DeviceServiceManager>(new global::System.Func<global::Motorola.Common.Communication.Service.DeviceServiceManager>(global::SpecialFeatures.Comms.DeviceServiceManagerProvider.a));
		}

		// Token: 0x040009CA RID: 2506
		private static readonly global::System.Lazy<global::Motorola.Common.Communication.Service.DeviceServiceManager> a;
	}
}
