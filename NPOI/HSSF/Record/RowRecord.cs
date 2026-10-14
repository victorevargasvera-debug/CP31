using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000418 RID: 1048
	public class RowRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.IComparable
	{
		// Token: 0x06002646 RID: 9798 RVA: 0x00073490 File Offset: 0x00071690
		public RowRecord(int rowNumber)
		{
			if (rowNumber < 0)
			{
				throw new global::System.ArgumentException("Invalid row number (" + rowNumber.ToString() + ")");
			}
			this.field_1_row_number = rowNumber;
			this.field_4_height = 255;
			this.field_5_optimize = 0;
			this.field_6_reserved = 0;
			this.field_7_option_flags = 256;
			this.field_8_option_flags = 15;
			this.SetEmpty();
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000734FC File Offset: 0x000716FC
		public RowRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row_number = in1.ReadUShort();
			if (this.field_1_row_number < 0)
			{
				throw new global::System.ArgumentException("Invalid row number " + this.field_1_row_number.ToString() + " found in InputStream");
			}
			this.field_2_first_col = (int)in1.ReadShort();
			this.field_3_last_col = (int)in1.ReadShort();
			this.field_4_height = in1.ReadShort();
			this.field_5_optimize = in1.ReadShort();
			this.field_6_reserved = in1.ReadShort();
			this.field_7_option_flags = (int)in1.ReadShort();
			this.field_8_option_flags = (int)in1.ReadShort();
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00073598 File Offset: 0x00071798
		public void SetEmpty()
		{
			this.field_2_first_col = 0;
			this.field_3_last_col = 0;
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000735A8 File Offset: 0x000717A8
		public bool IsEmpty
		{
			get
			{
				return (this.field_2_first_col | this.field_3_last_col) == 0;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000735BA File Offset: 0x000717BA
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x000735C2 File Offset: 0x000717C2
		public int RowNumber
		{
			get
			{
				return this.field_1_row_number;
			}
			set
			{
				this.field_1_row_number = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000735CB File Offset: 0x000717CB
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x000735D3 File Offset: 0x000717D3
		public int FirstCol
		{
			get
			{
				return this.field_2_first_col;
			}
			set
			{
				this.field_2_first_col = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000735DC File Offset: 0x000717DC
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x000735E4 File Offset: 0x000717E4
		public int LastCol
		{
			get
			{
				return this.field_3_last_col;
			}
			set
			{
				this.field_3_last_col = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000735ED File Offset: 0x000717ED
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x000735F5 File Offset: 0x000717F5
		public short Height
		{
			get
			{
				return this.field_4_height;
			}
			set
			{
				this.field_4_height = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x000735FE File Offset: 0x000717FE
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00073606 File Offset: 0x00071806
		public short Optimize
		{
			get
			{
				return this.field_5_optimize;
			}
			set
			{
				this.field_5_optimize = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0007360F File Offset: 0x0007180F
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00073618 File Offset: 0x00071818
		public short OptionFlags
		{
			get
			{
				return (short)this.field_7_option_flags;
			}
			set
			{
				this.field_7_option_flags = (int)(value | 256);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x00073627 File Offset: 0x00071827
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x0007363A File Offset: 0x0007183A
		public short OutlineLevel
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.RowRecord.outlineLevel.GetValue(this.field_7_option_flags);
			}
			set
			{
				this.field_7_option_flags = global::NPOI.HSSF.Record.RowRecord.outlineLevel.SetValue(this.field_7_option_flags, (int)value);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00073653 File Offset: 0x00071853
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00073665 File Offset: 0x00071865
		public bool Colapsed
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.colapsed.IsSet(this.field_7_option_flags);
			}
			set
			{
				this.field_7_option_flags = global::NPOI.HSSF.Record.RowRecord.colapsed.SetBoolean(this.field_7_option_flags, value);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x0007367E File Offset: 0x0007187E
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00073690 File Offset: 0x00071890
		public bool ZeroHeight
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.zeroHeight.IsSet(this.field_7_option_flags);
			}
			set
			{
				this.field_7_option_flags = global::NPOI.HSSF.Record.RowRecord.zeroHeight.SetBoolean(this.field_7_option_flags, value);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000736A9 File Offset: 0x000718A9
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x000736BB File Offset: 0x000718BB
		public bool BadFontHeight
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.badFontHeight.IsSet(this.field_7_option_flags);
			}
			set
			{
				this.field_7_option_flags = global::NPOI.HSSF.Record.RowRecord.badFontHeight.SetBoolean(this.field_7_option_flags, value);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000736D4 File Offset: 0x000718D4
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x000736E6 File Offset: 0x000718E6
		public bool Formatted
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.formatted.IsSet(this.field_7_option_flags);
			}
			set
			{
				this.field_7_option_flags = global::NPOI.HSSF.Record.RowRecord.formatted.SetBoolean(this.field_7_option_flags, value);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x000736FF File Offset: 0x000718FF
		public short OptionFlags2
		{
			get
			{
				return (short)this.field_8_option_flags;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00073708 File Offset: 0x00071908
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x0007371B File Offset: 0x0007191B
		public short XFIndex
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.xfIndex.GetShortValue((short)this.field_8_option_flags);
			}
			set
			{
				this.field_8_option_flags = global::NPOI.HSSF.Record.RowRecord.xfIndex.SetValue(this.field_8_option_flags, (int)value);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x00073734 File Offset: 0x00071934
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x00073746 File Offset: 0x00071946
		public bool TopBorder
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.topBorder.IsSet(this.field_8_option_flags);
			}
			set
			{
				this.field_8_option_flags = global::NPOI.HSSF.Record.RowRecord.topBorder.SetBoolean(this.field_8_option_flags, value);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x0007375F File Offset: 0x0007195F
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x00073771 File Offset: 0x00071971
		public bool BottomBorder
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.bottomBorder.IsSet(this.field_8_option_flags);
			}
			set
			{
				this.field_8_option_flags = global::NPOI.HSSF.Record.RowRecord.bottomBorder.SetBoolean(this.field_8_option_flags, value);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x0007378A File Offset: 0x0007198A
		// (set) Token: 0x06002668 RID: 9832 RVA: 0x0007379C File Offset: 0x0007199C
		public bool PhoeneticGuide
		{
			get
			{
				return global::NPOI.HSSF.Record.RowRecord.phoeneticGuide.IsSet(this.field_8_option_flags);
			}
			set
			{
				this.field_8_option_flags = global::NPOI.HSSF.Record.RowRecord.phoeneticGuide.SetBoolean(this.field_8_option_flags, value);
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000737B8 File Offset: 0x000719B8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ROW]\n");
			stringBuilder.Append("    .rownumber      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RowNumber)).Append("\n");
			stringBuilder.Append("    .firstcol       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstCol)).Append("\n");
			stringBuilder.Append("    .lastcol        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastCol)).Append("\n");
			stringBuilder.Append("    .height         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Height)).Append("\n");
			stringBuilder.Append("    .optimize       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Optimize)).Append("\n");
			stringBuilder.Append("    .reserved       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_6_reserved)).Append("\n");
			stringBuilder.Append("    .optionflags    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.OptionFlags)).Append("\n");
			stringBuilder.Append("        .outlinelvl = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.OutlineLevel)).Append("\n");
			stringBuilder.Append("        .colapsed   = ").Append(this.Colapsed).Append("\n");
			stringBuilder.Append("        .zeroheight = ").Append(this.ZeroHeight).Append("\n");
			stringBuilder.Append("        .badfontheig= ").Append(this.BadFontHeight).Append("\n");
			stringBuilder.Append("        .formatted  = ").Append(this.Formatted).Append("\n");
			stringBuilder.Append("    .optionsflags2  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.OptionFlags2)).Append("\n");
			stringBuilder.Append("        .xFindex       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.XFIndex)).Append("\n");
			stringBuilder.Append("        .topBorder     = ").Append(this.TopBorder).Append("\n");
			stringBuilder.Append("        .bottomBorder  = ").Append(this.BottomBorder).Append("\n");
			stringBuilder.Append("        .phoeneticGuide= ").Append(this.PhoeneticGuide).Append("\n");
			stringBuilder.Append("[/ROW]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00073A4C File Offset: 0x00071C4C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.RowNumber);
			out1.WriteShort((this.FirstCol == -1) ? 0 : this.FirstCol);
			out1.WriteShort((this.LastCol == -1) ? 0 : this.LastCol);
			out1.WriteShort((int)this.Height);
			out1.WriteShort((int)this.Optimize);
			out1.WriteShort((int)this.field_6_reserved);
			out1.WriteShort((int)this.OptionFlags);
			out1.WriteShort((int)this.OptionFlags2);
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		protected override int DataSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public override int RecordSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x00073AD1 File Offset: 0x00071CD1
		public override short Sid
		{
			get
			{
				return 520;
			}
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00073AD8 File Offset: 0x00071CD8
		public int CompareTo(object obj)
		{
			global::NPOI.HSSF.Record.RowRecord rowRecord = (global::NPOI.HSSF.Record.RowRecord)obj;
			if (this.RowNumber == rowRecord.RowNumber)
			{
				return 0;
			}
			if (this.RowNumber < rowRecord.RowNumber)
			{
				return -1;
			}
			if (this.RowNumber > rowRecord.RowNumber)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00073B20 File Offset: 0x00071D20
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.Record.RowRecord))
			{
				return false;
			}
			global::NPOI.HSSF.Record.RowRecord rowRecord = (global::NPOI.HSSF.Record.RowRecord)obj;
			return this.RowNumber == rowRecord.RowNumber;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00073B4F File Offset: 0x00071D4F
		public override int GetHashCode()
		{
			return this.RowNumber;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00073B58 File Offset: 0x00071D58
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.RowRecord(this.field_1_row_number)
			{
				field_2_first_col = this.field_2_first_col,
				field_3_last_col = this.field_3_last_col,
				field_4_height = this.field_4_height,
				field_5_optimize = this.field_5_optimize,
				field_6_reserved = this.field_6_reserved,
				field_7_option_flags = this.field_7_option_flags,
				field_8_option_flags = this.field_8_option_flags
			};
		}

		// Token: 0x04001007 RID: 4103
		public const short sid = 520;

		// Token: 0x04001008 RID: 4104
		public const int ENCODED_SIZE = 20;

		// Token: 0x04001009 RID: 4105
		private const int OPTION_BITS_ALWAYS_SET = 256;

		// Token: 0x0400100A RID: 4106
		[global::System.Obsolete]
		public const int MAX_ROW_NUMBER = 65535;

		// Token: 0x0400100B RID: 4107
		private int field_1_row_number;

		// Token: 0x0400100C RID: 4108
		private int field_2_first_col;

		// Token: 0x0400100D RID: 4109
		private int field_3_last_col;

		// Token: 0x0400100E RID: 4110
		private short field_4_height;

		// Token: 0x0400100F RID: 4111
		private short field_5_optimize;

		// Token: 0x04001010 RID: 4112
		private short field_6_reserved;

		// Token: 0x04001011 RID: 4113
		private int field_7_option_flags;

		// Token: 0x04001012 RID: 4114
		private static global::NPOI.Util.BitField outlineLevel = global::NPOI.Util.BitFieldFactory.GetInstance(7);

		// Token: 0x04001013 RID: 4115
		private static global::NPOI.Util.BitField colapsed = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001014 RID: 4116
		private static global::NPOI.Util.BitField zeroHeight = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04001015 RID: 4117
		private static global::NPOI.Util.BitField badFontHeight = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04001016 RID: 4118
		private static global::NPOI.Util.BitField formatted = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04001017 RID: 4119
		private int field_8_option_flags;

		// Token: 0x04001018 RID: 4120
		private static global::NPOI.Util.BitField xfIndex = global::NPOI.Util.BitFieldFactory.GetInstance(4095);

		// Token: 0x04001019 RID: 4121
		private static global::NPOI.Util.BitField topBorder = global::NPOI.Util.BitFieldFactory.GetInstance(4096);

		// Token: 0x0400101A RID: 4122
		private static global::NPOI.Util.BitField bottomBorder = global::NPOI.Util.BitFieldFactory.GetInstance(8192);

		// Token: 0x0400101B RID: 4123
		private static global::NPOI.Util.BitField phoeneticGuide = global::NPOI.Util.BitFieldFactory.GetInstance(16384);
	}
}
