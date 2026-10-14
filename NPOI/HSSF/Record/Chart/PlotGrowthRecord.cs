using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B4 RID: 1204
	public class PlotGrowthRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D08 RID: 11528 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PlotGrowthRecord()
		{
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000857FC File Offset: 0x000839FC
		public PlotGrowthRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_horizontalScale = in1.ReadInt();
			this.field_2_verticalScale = in1.ReadInt();
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0008581C File Offset: 0x00083A1C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PLOTGROWTH]\n");
			stringBuilder.Append("    .horizontalScale      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.HorizontalScale)).Append(" (").Append(this.HorizontalScale).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .verticalScale        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.VerticalScale)).Append(" (").Append(this.VerticalScale).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/PLOTGROWTH]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000858ED File Offset: 0x00083AED
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_horizontalScale);
			out1.WriteInt(this.field_2_verticalScale);
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x00085907 File Offset: 0x00083B07
		public override short Sid
		{
			get
			{
				return 4196;
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0008590E File Offset: 0x00083B0E
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.PlotGrowthRecord
			{
				field_1_horizontalScale = this.field_1_horizontalScale,
				field_2_verticalScale = this.field_2_verticalScale
			};
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x0008592D File Offset: 0x00083B2D
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x00085935 File Offset: 0x00083B35
		public int HorizontalScale
		{
			get
			{
				return this.field_1_horizontalScale;
			}
			set
			{
				this.field_1_horizontalScale = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x0008593E File Offset: 0x00083B3E
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x00085946 File Offset: 0x00083B46
		public int VerticalScale
		{
			get
			{
				return this.field_2_verticalScale;
			}
			set
			{
				this.field_2_verticalScale = value;
			}
		}

		// Token: 0x040013B9 RID: 5049
		public const short sid = 4196;

		// Token: 0x040013BA RID: 5050
		private int field_1_horizontalScale;

		// Token: 0x040013BB RID: 5051
		private int field_2_verticalScale;
	}
}
