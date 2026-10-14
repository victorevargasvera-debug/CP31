using System;
using Autofac;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class AstroDeviceFactoriesModule : global::Autofac.Module
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000029C0 File Offset: 0x00000BC0
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)15524314;
			short num2 = num;
			num = (short)1661395418;
			switch (num2 == num)
			{
			}
			num = (short)1655767040;
			if (num != 0)
			{
			}
			num = (short)265158656;
			short num3 = num;
			num = (short)1930035201;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroRadioFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroWiFiRadioFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpWiFiRadioFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
		}
	}
}
