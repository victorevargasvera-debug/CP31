using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AE RID: 1198
	public class FrameRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002CA4 RID: 11428 RVA: 0x00084843 File Offset: 0x00082A43
		public FrameRecord()
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00084863 File Offset: 0x00082A63
		public FrameRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_borderType = in1.ReadShort();
			this.field_2_options = in1.ReadShort();
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0008489C File Offset: 0x00082A9C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FRAME]\n");
			stringBuilder.Append("    .borderType           = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BorderType)).Append(" (").Append(this.BorderType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .autoSize                 = ").Append(this.IsAutoSize).Append('\n');
			stringBuilder.Append("         .autoPosition             = ").Append(this.IsAutoPosition).Append('\n');
			stringBuilder.Append("[/FRAME]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000849A9 File Offset: 0x00082BA9
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_borderType);
			out1.WriteShort((int)this.field_2_options);
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000849C3 File Offset: 0x00082BC3
		public override short Sid
		{
			get
			{
				return 4146;
			}
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000849CA File Offset: 0x00082BCA
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.FrameRecord
			{
				field_1_borderType = this.field_1_borderType,
				field_2_options = this.field_2_options
			};
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000849E9 File Offset: 0x00082BE9
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x000849F1 File Offset: 0x00082BF1
		public short BorderType
		{
			get
			{
				return this.field_1_borderType;
			}
			set
			{
				this.field_1_borderType = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000849FA File Offset: 0x00082BFA
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x00084A02 File Offset: 0x00082C02
		public short Options
		{
			get
			{
				return this.field_2_options;
			}
			set
			{
				this.field_2_options = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x00084A0B File Offset: 0x00082C0B
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x00084A1E File Offset: 0x00082C1E
		public bool IsAutoSize
		{
			get
			{
				return this.autoSize.IsSet((int)this.field_2_options);
			}
			set
			{
				this.field_2_options = this.autoSize.SetShortBoolean(this.field_2_options, value);
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x00084A38 File Offset: 0x00082C38
		// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x00084A4B File Offset: 0x00082C4B
		public bool IsAutoPosition
		{
			get
			{
				return this.autoPosition.IsSet((int)this.field_2_options);
			}
			set
			{
				this.field_2_options = this.autoPosition.SetShortBoolean(this.field_2_options, value);
			}
		}

		// Token: 0x04001379 RID: 4985
		public const short sid = 4146;

		// Token: 0x0400137A RID: 4986
		private short field_1_borderType;

		// Token: 0x0400137B RID: 4987
		public const short BORDER_TYPE_REGULAR = 0;

		// Token: 0x0400137C RID: 4988
		public const short BORDER_TYPE_SHADOW = 1;

		// Token: 0x0400137D RID: 4989
		private short field_2_options;

		// Token: 0x0400137E RID: 4990
		private global::NPOI.Util.BitField autoSize = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400137F RID: 4991
		private global::NPOI.Util.BitField autoPosition = global::NPOI.Util.BitFieldFactory.GetInstance(2);
	}
}
