using System;
using Autofac;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class VirtualCommunicationModule : global::Autofac.Module
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002D78 File Offset: 0x00000F78
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1150953788;
			short num2 = num;
			num = (short)1199974716;
			switch (num2 == num)
			{
			}
			num = (short)91553792;
			if (num != 0)
			{
			}
			num = (short)2088632320;
			short num3 = num;
			num = (short)600702977;
			if (num != 0)
			{
			}
			builder.RegisterModule<global::Motorola.Common.Communication.VirtualDeviceFactoryModule>();
			builder.RegisterModule<global::Motorola.Common.Communication.VirtualDeviceDetectorModule>();
		}
	}
}
