using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C6 RID: 966
	public class DeltaRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x000670F7 File Offset: 0x000652F7
		public DeltaRecord(double maxChange)
		{
			this.field_1_max_change = maxChange;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00067106 File Offset: 0x00065306
		public DeltaRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_max_change = in1.ReadDouble();
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0006711A File Offset: 0x0006531A
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00067122 File Offset: 0x00065322
		public double MaxChange
		{
			get
			{
				return this.field_1_max_change;
			}
			set
			{
				this.field_1_max_change = value;
			}
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0006712C File Offset: 0x0006532C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DELTA]\n");
			stringBuilder.Append("    .maxChange      = ").Append(this.MaxChange).Append("\n");
			stringBuilder.Append("[/DELTA]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0006717C File Offset: 0x0006537C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.MaxChange);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public override short Sid
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x04000D4F RID: 3407
		public const short sid = 16;

		// Token: 0x04000D50 RID: 3408
		public const double DEFAULT_VALUE = 0.001;

		// Token: 0x04000D51 RID: 3409
		private double field_1_max_change;
	}
}
