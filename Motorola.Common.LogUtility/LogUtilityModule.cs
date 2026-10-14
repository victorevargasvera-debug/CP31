using System;
using Autofac;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000017 RID: 23
	internal class LogUtilityModule : global::Autofac.Module
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1698639899;
			short num2 = num;
			num = (short)1036005403;
			switch (num2 == num)
			{
			}
			num = (short)1510408192;
			if (num != 0)
			{
			}
			num = (short)1647312897;
			if (num != 0)
			{
			}
			num = (short)839647232;
			short num3 = num;
			builder.RegisterType<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>().As<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>().ExternallyOwned();
			builder.RegisterType<global::Motorola.Common.LogUtility.PerformanceMeasurement.AutomaticPerformanceMeasurer>().As<global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer>().ExternallyOwned();
			builder.RegisterType<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch>().As<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch>().ExternallyOwned();
			builder.RegisterType<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurerManager>().As<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMonitor>().As<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMonitor>().SingleInstance();
		}
	}
}
