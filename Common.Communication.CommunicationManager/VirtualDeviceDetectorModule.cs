using System;
using Autofac;
using Common.Communication.Simulator;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class VirtualDeviceDetectorModule : global::Autofac.Module
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002CA4 File Offset: 0x00000EA4
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)67091258;
			short num2 = num;
			num = (short)532527930;
			switch (num2 == num)
			{
			}
			num = (short)1118633984;
			if (num != 0)
			{
			}
			num = (short)1230045184;
			short num3 = num;
			num = (short)171245569;
			if (num != 0)
			{
			}
			builder.RegisterInstance(global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance()).As<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector>().SingleInstance();
		}
	}
}
