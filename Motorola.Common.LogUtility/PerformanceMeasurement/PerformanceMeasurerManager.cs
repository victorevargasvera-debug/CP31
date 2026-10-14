using System;
using System.Collections.Concurrent;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200002E RID: 46
	internal class PerformanceMeasurerManager : global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00015F24 File Offset: 0x00014124
		public int Count
		{
			get
			{
				short num = (short)149337869;
				short num2 = num;
				num = (short)1211807501;
				switch (num2 == num)
				{
				}
				num = (short)915537921;
				if (num != 0)
				{
				}
				num = (short)1738670080;
				if (num != 0)
				{
				}
				num = (short)1524695040;
				short num3 = num;
				return this.a.Count;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00015FDC File Offset: 0x000141DC
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer Get(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo)
		{
			short num = (short)921836457;
			short num2 = num;
			num = (short)1990728617;
			switch (num2 == num)
			{
			}
			num = (short)1707212800;
			if (num != 0)
			{
			}
			num = (short)1104150529;
			if (num != 0)
			{
			}
			num = (short)400228352;
			short num3 = num;
			global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer result;
			this.a.TryGetValue(operationInfo, out result);
			return result;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00016094 File Offset: 0x00014294
		public void Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer)
		{
			short num = (short)1083179009;
			if (num != 0)
			{
			}
			num = (short)454024698;
			short num2 = num;
			num = (short)2120015354;
			switch (num2 == num)
			{
			}
			num = (short)884211712;
			if (num != 0)
			{
			}
			num = (short)1868234752;
			short num3 = num;
			this.a.TryAdd(operationInfo, measurer);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00016148 File Offset: 0x00014348
		public void Remove(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo)
		{
			short num = (short)2074411009;
			if (num != 0)
			{
			}
			num = (short)851225371;
			short num2 = num;
			num = (short)1232775963;
			switch (num2 == num)
			{
			}
			num = (short)1572732928;
			if (num != 0)
			{
			}
			num = (short)1385234432;
			short num3 = num;
			global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer performanceMeasurer;
			this.a.TryRemove(operationInfo, out performanceMeasurer);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00016200 File Offset: 0x00014400
		public void Clear()
		{
			short num = (short)1284844941;
			short num2 = num;
			num = (short)574696845;
			switch (num2 == num)
			{
			}
			num = (short)575995905;
			if (num != 0)
			{
			}
			num = (short)2073493504;
			if (num != 0)
			{
			}
			num = (short)667746304;
			short num3 = num;
			this.a.Clear();
		}

		// Token: 0x040000CE RID: 206
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer> a = new global::System.Collections.Concurrent.ConcurrentDictionary<global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>();
	}
}
