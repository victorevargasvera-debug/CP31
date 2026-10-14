using System;
using Autofac;
using Autofac.Builder;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class AstroDeviceDetectorsModule : global::Autofac.Module
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000028E0 File Offset: 0x00000AE0
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)979566593;
			if (num != 0)
			{
			}
			num = (short)754491157;
			short num2 = num;
			num = (short)1280155413;
			switch (num2 == num)
			{
			}
			num = (short)1307705344;
			short num3 = num;
			num = (short)69271552;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector>().As<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector>().IfNotRegistered(typeof(global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector)).SingleInstance();
		}
	}
}
