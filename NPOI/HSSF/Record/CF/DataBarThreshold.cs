using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C3 RID: 1219
	public class DataBarThreshold : global::NPOI.HSSF.Record.CF.Threshold, global::System.ICloneable
	{
		// Token: 0x06002DD3 RID: 11731 RVA: 0x00087823 File Offset: 0x00085A23
		public DataBarThreshold()
		{
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0008782B File Offset: 0x00085A2B
		public DataBarThreshold(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00087834 File Offset: 0x00085A34
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.DataBarThreshold dataBarThreshold = new global::NPOI.HSSF.Record.CF.DataBarThreshold();
			base.CopyTo(dataBarThreshold);
			return dataBarThreshold;
		}
	}
}
