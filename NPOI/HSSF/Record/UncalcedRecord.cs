using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000436 RID: 1078
	public class UncalcedRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027D3 RID: 10195 RVA: 0x00077FCC File Offset: 0x000761CC
		public UncalcedRecord()
		{
			this._reserved = 0;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00077FDB File Offset: 0x000761DB
		public UncalcedRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._reserved = in1.ReadShort();
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x00077FEF File Offset: 0x000761EF
		public override short Sid
		{
			get
			{
				return 94;
			}
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00077FF3 File Offset: 0x000761F3
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[UNCALCED]\n");
			stringBuilder.Append("[/UNCALCED]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00078017 File Offset: 0x00076217
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this._reserved);
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x00017F5F File Offset: 0x0001615F
		public static int StaticRecordSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x040010E5 RID: 4325
		public const short sid = 94;

		// Token: 0x040010E6 RID: 4326
		private short _reserved;
	}
}
