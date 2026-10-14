using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A9 RID: 1193
	public class DataFormatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x00083EC6 File Offset: 0x000820C6
		public DataFormatRecord()
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00083EDC File Offset: 0x000820DC
		public DataFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_pointNumber = in1.ReadShort();
			this.field_2_seriesIndex = in1.ReadShort();
			this.field_3_seriesNumber = in1.ReadShort();
			this.field_4_formatFlags = in1.ReadShort();
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00083F2C File Offset: 0x0008212C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DATAFORMAT]\n");
			stringBuilder.Append("    .pointNumber          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.PointNumber)).Append(" (").Append(this.PointNumber).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .seriesIndex          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.SeriesIndex)).Append(" (").Append(this.SeriesIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .seriesNumber         = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.SeriesNumber)).Append(" (").Append(this.SeriesNumber).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .formatFlags          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatFlags)).Append(" (").Append(this.FormatFlags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .useExcel4Colors          = ").Append(this.UseExcel4Colors).Append('\n');
			stringBuilder.Append("[/DATAFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000840BD File Offset: 0x000822BD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_pointNumber);
			out1.WriteShort((int)this.field_2_seriesIndex);
			out1.WriteShort((int)this.field_3_seriesNumber);
			out1.WriteShort((int)this.field_4_formatFlags);
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000840EF File Offset: 0x000822EF
		public override short Sid
		{
			get
			{
				return 4102;
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000840F6 File Offset: 0x000822F6
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.DataFormatRecord
			{
				field_1_pointNumber = this.field_1_pointNumber,
				field_2_seriesIndex = this.field_2_seriesIndex,
				field_3_seriesNumber = this.field_3_seriesNumber,
				field_4_formatFlags = this.field_4_formatFlags
			};
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x0008412D File Offset: 0x0008232D
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00084135 File Offset: 0x00082335
		public short PointNumber
		{
			get
			{
				return this.field_1_pointNumber;
			}
			set
			{
				this.field_1_pointNumber = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x0008413E File Offset: 0x0008233E
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00084146 File Offset: 0x00082346
		public short SeriesIndex
		{
			get
			{
				return this.field_2_seriesIndex;
			}
			set
			{
				this.field_2_seriesIndex = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x0008414F File Offset: 0x0008234F
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x00084157 File Offset: 0x00082357
		public short SeriesNumber
		{
			get
			{
				return this.field_3_seriesNumber;
			}
			set
			{
				this.field_3_seriesNumber = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00084160 File Offset: 0x00082360
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x00084168 File Offset: 0x00082368
		public short FormatFlags
		{
			get
			{
				return this.field_4_formatFlags;
			}
			set
			{
				this.field_4_formatFlags = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00084171 File Offset: 0x00082371
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x00084184 File Offset: 0x00082384
		public bool UseExcel4Colors
		{
			get
			{
				return this.useExcel4Colors.IsSet((int)this.field_4_formatFlags);
			}
			set
			{
				this.field_4_formatFlags = this.useExcel4Colors.SetShortBoolean(this.field_4_formatFlags, value);
			}
		}

		// Token: 0x04001361 RID: 4961
		public const short sid = 4102;

		// Token: 0x04001362 RID: 4962
		private short field_1_pointNumber;

		// Token: 0x04001363 RID: 4963
		private short field_2_seriesIndex;

		// Token: 0x04001364 RID: 4964
		private short field_3_seriesNumber;

		// Token: 0x04001365 RID: 4965
		private short field_4_formatFlags;

		// Token: 0x04001366 RID: 4966
		private global::NPOI.Util.BitField useExcel4Colors = global::NPOI.Util.BitFieldFactory.GetInstance(1);
	}
}
