using System;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000019 RID: 25
	internal sealed class AutomaticPerformanceMeasurer : global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer, global::System.IDisposable
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x0000FC18 File Offset: 0x0000DE18
		public AutomaticPerformanceMeasurer(string loggerName, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch watch, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager performanceMeasurerManager, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parent = null) : base(loggerName, operationInfo, watch, performanceMeasurerManager, parent)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000FC34 File Offset: 0x0000DE34
		public void Dispose()
		{
			short num = (short)1323027626;
			short num2 = num;
			num = (short)917818538;
			switch (num2 == num)
			{
			}
			num = (short)1668022273;
			if (num != 0)
			{
			}
			num = (short)857210880;
			if (num != 0)
			{
			}
			num = (short)2060910592;
			short num3 = num;
			base.Stop();
		}
	}
}
