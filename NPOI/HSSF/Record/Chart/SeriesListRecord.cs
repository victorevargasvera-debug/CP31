using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BA RID: 1210
	public class SeriesListRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D4F RID: 11599 RVA: 0x00086117 File Offset: 0x00084317
		public SeriesListRecord(short[] seriesNumbers)
		{
			this.field_1_seriesNumbers = ((seriesNumbers == null) ? null : ((short[])seriesNumbers.Clone()));
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00086138 File Offset: 0x00084338
		public SeriesListRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int num = in1.ReadUShort();
			short[] array = new short[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = in1.ReadShort();
			}
			this.field_1_seriesNumbers = array;
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00086178 File Offset: 0x00084378
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SERIESLIST]\n");
			stringBuilder.Append("    .seriesNumbers        = ").Append(" (").Append(this.SeriesNumbers).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SERIESLIST]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000861E0 File Offset: 0x000843E0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int num = this.field_1_seriesNumbers.Length;
			out1.WriteShort(num);
			for (int i = 0; i < num; i++)
			{
				out1.WriteShort((int)this.field_1_seriesNumbers[i]);
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x00086217 File Offset: 0x00084417
		protected override int DataSize
		{
			get
			{
				return this.field_1_seriesNumbers.Length * 2 + 2;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00086225 File Offset: 0x00084425
		public override short Sid
		{
			get
			{
				return 4118;
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x0008622C File Offset: 0x0008442C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesListRecord(this.field_1_seriesNumbers);
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x00086239 File Offset: 0x00084439
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00086241 File Offset: 0x00084441
		public short[] SeriesNumbers
		{
			get
			{
				return this.field_1_seriesNumbers;
			}
			set
			{
				this.field_1_seriesNumbers = value;
			}
		}

		// Token: 0x040013D5 RID: 5077
		public const short sid = 4118;

		// Token: 0x040013D6 RID: 5078
		private short[] field_1_seriesNumbers;
	}
}
