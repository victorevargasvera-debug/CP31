using System;
using Autofac;
using Common.Communication.Simulator;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class VirtualDeviceFactoryModule : global::Autofac.Module
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002BD4 File Offset: 0x00000DD4
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)184516371;
			short num2 = num;
			num = (short)1605402387;
			switch (num2 == num)
			{
			}
			num = (short)2031943680;
			if (num != 0)
			{
			}
			num = (short)815529984;
			short num3 = num;
			num = (short)940310529;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Common.Communication.Simulator.VirtualDeviceFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
		}
	}
}
