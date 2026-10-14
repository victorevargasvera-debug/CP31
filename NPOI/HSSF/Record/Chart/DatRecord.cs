using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AB RID: 1195
	public class DatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C7A RID: 11386 RVA: 0x000842A8 File Offset: 0x000824A8
		public DatRecord()
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000842E0 File Offset: 0x000824E0
		public DatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_options = in1.ReadShort();
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00084330 File Offset: 0x00082530
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DAT]\n");
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .horizontalBorder         = ").Append(this.IsHorizontalBorder()).Append('\n');
			stringBuilder.Append("         .verticalBorder           = ").Append(this.IsVerticalBorder()).Append('\n');
			stringBuilder.Append("         .border                   = ").Append(this.IsBorder()).Append('\n');
			stringBuilder.Append("         .showSeriesKey            = ").Append(this.IsShowSeriesKey()).Append('\n');
			stringBuilder.Append("[/DAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x00084428 File Offset: 0x00082628
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_options);
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x00084436 File Offset: 0x00082636
		public override short Sid
		{
			get
			{
				return 4195;
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0008443D File Offset: 0x0008263D
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.DatRecord
			{
				field_1_options = this.field_1_options
			};
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x00084450 File Offset: 0x00082650
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00084458 File Offset: 0x00082658
		public short Options
		{
			get
			{
				return this.field_1_options;
			}
			set
			{
				this.field_1_options = value;
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x00084461 File Offset: 0x00082661
		public void SetHorizontalBorder(bool value)
		{
			this.field_1_options = this.horizontalBorder.SetShortBoolean(this.field_1_options, value);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0008447B File Offset: 0x0008267B
		public bool IsHorizontalBorder()
		{
			return this.horizontalBorder.IsSet((int)this.field_1_options);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0008448E File Offset: 0x0008268E
		public void SetVerticalBorder(bool value)
		{
			this.field_1_options = this.verticalBorder.SetShortBoolean(this.field_1_options, value);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000844A8 File Offset: 0x000826A8
		public bool IsVerticalBorder()
		{
			return this.verticalBorder.IsSet((int)this.field_1_options);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000844BB File Offset: 0x000826BB
		public void SetBorder(bool value)
		{
			this.field_1_options = this.border.SetShortBoolean(this.field_1_options, value);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000844D5 File Offset: 0x000826D5
		public bool IsBorder()
		{
			return this.border.IsSet((int)this.field_1_options);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000844E8 File Offset: 0x000826E8
		public void SetShowSeriesKey(bool value)
		{
			this.field_1_options = this.showSeriesKey.SetShortBoolean(this.field_1_options, value);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00084502 File Offset: 0x00082702
		public bool IsShowSeriesKey()
		{
			return this.showSeriesKey.IsSet((int)this.field_1_options);
		}

		// Token: 0x0400136B RID: 4971
		public const short sid = 4195;

		// Token: 0x0400136C RID: 4972
		private short field_1_options;

		// Token: 0x0400136D RID: 4973
		private global::NPOI.Util.BitField horizontalBorder = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400136E RID: 4974
		private global::NPOI.Util.BitField verticalBorder = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x0400136F RID: 4975
		private global::NPOI.Util.BitField border = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001370 RID: 4976
		private global::NPOI.Util.BitField showSeriesKey = global::NPOI.Util.BitFieldFactory.GetInstance(8);
	}
}
