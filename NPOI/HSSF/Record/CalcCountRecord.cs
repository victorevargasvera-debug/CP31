using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B1 RID: 945
	public class CalcCountRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CalcCountRecord()
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00064581 File Offset: 0x00062781
		public CalcCountRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_iterations = in1.ReadShort();
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00064595 File Offset: 0x00062795
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0006459D File Offset: 0x0006279D
		public short Iterations
		{
			get
			{
				return this.field_1_iterations;
			}
			set
			{
				this.field_1_iterations = value;
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000645A8 File Offset: 0x000627A8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CALCCOUNT]\n");
			stringBuilder.Append("    .iterations     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Iterations)).Append("\n");
			stringBuilder.Append("[/CALCCOUNT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000645FD File Offset: 0x000627FD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Iterations);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000184AD File Offset: 0x000166AD
		public override short Sid
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0006460B File Offset: 0x0006280B
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.CalcCountRecord
			{
				field_1_iterations = this.field_1_iterations
			};
		}

		// Token: 0x04000CC7 RID: 3271
		public const short sid = 12;

		// Token: 0x04000CC8 RID: 3272
		private short field_1_iterations;
	}
}
