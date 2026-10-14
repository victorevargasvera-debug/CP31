using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B3 RID: 1203
	public class PlotAreaRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D01 RID: 11521 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PlotAreaRecord()
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PlotAreaRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000857D1 File Offset: 0x000839D1
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PLOTAREA]\n");
			stringBuilder.Append("[/PLOTAREA]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000857F5 File Offset: 0x000839F5
		public override short Sid
		{
			get
			{
				return 4149;
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0004F7C9 File Offset: 0x0004D9C9
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.PlotAreaRecord();
		}

		// Token: 0x040013B8 RID: 5048
		public const short sid = 4149;
	}
}
