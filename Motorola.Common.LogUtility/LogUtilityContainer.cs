using System;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000016 RID: 22
	internal static class LogUtilityContainer
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000F628 File Offset: 0x0000D828
		static LogUtilityContainer()
		{
			short num = (short)1855668253;
			short num2 = num;
			num = (short)1772306461;
			switch (num2 == num)
			{
			}
			num = (short)2022375424;
			if (num != 0)
			{
			}
			num = (short)7012353;
			if (num != 0)
			{
			}
			num = (short)1325662208;
			short num3 = num;
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder();
			containerBuilder.RegisterModule(new global::Motorola.Common.LogUtility.LogUtilityModule());
			global::Motorola.Common.LogUtility.LogUtilityContainer.a = containerBuilder.Build(global::Autofac.Builder.ContainerBuildOptions.None);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		public static global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer ResolvePerformanceMeasurer(string loggerName, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parent = null)
		{
			int a_ = 18;
			short num = (short)1617364051;
			short num2 = num;
			num = (short)990839891;
			switch (num2 == num)
			{
			}
			num = (short)150536193;
			if (num != 0)
			{
			}
			num = (short)1252065280;
			if (num != 0)
			{
			}
			num = (short)32047104;
			short num3 = num;
			return global::Motorola.Common.LogUtility.LogUtilityContainer.a.Resolve(new global::Autofac.Core.Parameter[]
			{
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("੥ݧ൩୫୭ɯ㱱ᕳ᭵ᵷ", a_), loggerName),
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("॥ᡧཀྵṫ཭ѯ᭱᭳ᡵㅷᑹ᩻ᅽ", a_), operationInfo),
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᙥ१ᡩ५mѯ", a_), parent)
			});
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		internal static global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer ResolveAutomaticPerformanceMeasurer(string loggerName, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parent)
		{
			int a_ = 2;
			short num = (short)923476610;
			short num2 = num;
			num = (short)588849794;
			switch (num2 == num)
			{
			}
			num = (short)1339424768;
			if (num != 0)
			{
			}
			num = (short)219807745;
			if (num != 0)
			{
			}
			num = (short)1268645888;
			short num3 = num;
			return global::Motorola.Common.LogUtility.LogUtilityContainer.a.Resolve(new global::Autofac.Core.Parameter[]
			{
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㩕㝗㵙㭛㭝቟ⱡգ୥൧", a_), loggerName),
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㥕⡗㽙⹛㽝ᑟୡୣࡥⅧѩ੫ŭ", a_), operationInfo),
				new global::Autofac.NamedParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("♕㥗⡙㥛そᑟ", a_), parent)
			});
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000F900 File Offset: 0x0000DB00
		public static global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager ResolvePerformanceMeasurerManager()
		{
			short num = (short)1617322884;
			short num2 = num;
			num = (short)886989700;
			switch (num2 == num)
			{
			}
			num = (short)1944453121;
			if (num != 0)
			{
			}
			num = (short)1557200896;
			if (num != 0)
			{
			}
			num = (short)147456000;
			short num3 = num;
			return global::Motorola.Common.LogUtility.LogUtilityContainer.a.Resolve<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager>();
		}

		// Token: 0x04000062 RID: 98
		private static readonly global::Autofac.IContainer a;
	}
}
