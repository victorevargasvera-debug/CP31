using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000405 RID: 1029
	public class PrecisionRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002563 RID: 9571 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PrecisionRecord()
		{
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000707F6 File Offset: 0x0006E9F6
		public PrecisionRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_precision = in1.ReadShort();
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0007080A File Offset: 0x0006EA0A
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00070815 File Offset: 0x0006EA15
		public bool FullPrecision
		{
			get
			{
				return this.field_1_precision == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_precision = 1;
					return;
				}
				this.field_1_precision = 0;
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0007082C File Offset: 0x0006EA2C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PRECISION]\n");
			stringBuilder.Append("    .precision       = ").Append(this.FullPrecision).Append("\n");
			stringBuilder.Append("[/PRECISION]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0007087C File Offset: 0x0006EA7C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_precision);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x00018987 File Offset: 0x00016B87
		public override short Sid
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x04000FB9 RID: 4025
		public const short sid = 14;

		// Token: 0x04000FBA RID: 4026
		public short field_1_precision;
	}
}
