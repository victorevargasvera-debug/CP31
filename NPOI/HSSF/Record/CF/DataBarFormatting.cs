using System;
using System.Text;
using NPOI.HSSF.Record.Common;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C2 RID: 1218
	public class DataBarFormatting : global::System.ICloneable
	{
		// Token: 0x06002DBC RID: 11708 RVA: 0x000874E4 File Offset: 0x000856E4
		public DataBarFormatting()
		{
			this.options = 2;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000874F4 File Offset: 0x000856F4
		public DataBarFormatting(global::NPOI.Util.ILittleEndianInput in1)
		{
			in1.ReadShort();
			in1.ReadByte();
			this.options = (byte)in1.ReadByte();
			this.percentMin = (byte)in1.ReadByte();
			this.percentMax = (byte)in1.ReadByte();
			if (this.percentMin < 0 || this.percentMin > 100)
			{
				global::System.Console.WriteLine("Inconsistent Minimum Percentage found " + this.percentMin.ToString());
			}
			if (this.percentMax < 0 || this.percentMax > 100)
			{
				global::System.Console.WriteLine("Inconsistent Minimum Percentage found " + this.percentMin.ToString());
			}
			this.color = new global::NPOI.HSSF.Record.Common.ExtendedColor(in1);
			this.thresholdMin = new global::NPOI.HSSF.Record.CF.DataBarThreshold(in1);
			this.thresholdMax = new global::NPOI.HSSF.Record.CF.DataBarThreshold(in1);
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000875BA File Offset: 0x000857BA
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x000875C7 File Offset: 0x000857C7
		public bool IsIconOnly
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.DataBarFormatting.iconOnly);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.DataBarFormatting.iconOnly);
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x000875D5 File Offset: 0x000857D5
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x000875E2 File Offset: 0x000857E2
		public bool IsReversed
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.DataBarFormatting.reversed);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.DataBarFormatting.reversed);
			}
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000875F0 File Offset: 0x000857F0
		private bool GetOptionFlag(global::NPOI.Util.BitField field)
		{
			return field.GetValue((int)this.options) != 0;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00087603 File Offset: 0x00085803
		private void SetOptionFlag(bool option, global::NPOI.Util.BitField field)
		{
			this.options = field.SetByteBoolean(this.options, option);
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x00087618 File Offset: 0x00085818
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x00087620 File Offset: 0x00085820
		public byte PercentMin
		{
			get
			{
				return this.percentMin;
			}
			set
			{
				this.percentMin = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x00087629 File Offset: 0x00085829
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x00087631 File Offset: 0x00085831
		public byte PercentMax
		{
			get
			{
				return this.percentMax;
			}
			set
			{
				this.percentMax = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x0008763A File Offset: 0x0008583A
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x00087642 File Offset: 0x00085842
		public global::NPOI.HSSF.Record.Common.ExtendedColor Color
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x0008764B File Offset: 0x0008584B
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x00087653 File Offset: 0x00085853
		public global::NPOI.HSSF.Record.CF.DataBarThreshold ThresholdMin
		{
			get
			{
				return this.thresholdMin;
			}
			set
			{
				this.thresholdMin = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x0008765C File Offset: 0x0008585C
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x00087664 File Offset: 0x00085864
		public global::NPOI.HSSF.Record.CF.DataBarThreshold ThresholdMax
		{
			get
			{
				return this.thresholdMax;
			}
			set
			{
				this.thresholdMax = value;
			}
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00087670 File Offset: 0x00085870
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Data Bar Formatting]\n");
			stringBuilder.Append("          .icon_only= ").Append(this.IsIconOnly).Append("\n");
			stringBuilder.Append("          .reversed = ").Append(this.IsReversed).Append("\n");
			stringBuilder.Append(this.color);
			stringBuilder.Append(this.thresholdMin);
			stringBuilder.Append(this.thresholdMax);
			stringBuilder.Append("    [/Data Bar Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00087708 File Offset: 0x00085908
		public object Clone()
		{
			return new global::NPOI.HSSF.Record.CF.DataBarFormatting
			{
				options = this.options,
				percentMin = this.percentMin,
				percentMax = this.percentMax,
				color = (global::NPOI.HSSF.Record.Common.ExtendedColor)this.color.Clone(),
				thresholdMin = (global::NPOI.HSSF.Record.CF.DataBarThreshold)this.thresholdMin.Clone(),
				thresholdMax = (global::NPOI.HSSF.Record.CF.DataBarThreshold)this.thresholdMax.Clone()
			};
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00087780 File Offset: 0x00085980
		public int DataLength
		{
			get
			{
				return 6 + this.color.DataLength + this.thresholdMin.DataLength + this.thresholdMax.DataLength;
			}
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000877A8 File Offset: 0x000859A8
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(0);
			out1.WriteByte(0);
			out1.WriteByte((int)this.options);
			out1.WriteByte((int)this.percentMin);
			out1.WriteByte((int)this.percentMax);
			this.color.Serialize(out1);
			this.thresholdMin.Serialize(out1);
			this.thresholdMax.Serialize(out1);
		}

		// Token: 0x04001414 RID: 5140
		private byte options;

		// Token: 0x04001415 RID: 5141
		private byte percentMin;

		// Token: 0x04001416 RID: 5142
		private byte percentMax;

		// Token: 0x04001417 RID: 5143
		private global::NPOI.HSSF.Record.Common.ExtendedColor color;

		// Token: 0x04001418 RID: 5144
		private global::NPOI.HSSF.Record.CF.DataBarThreshold thresholdMin;

		// Token: 0x04001419 RID: 5145
		private global::NPOI.HSSF.Record.CF.DataBarThreshold thresholdMax;

		// Token: 0x0400141A RID: 5146
		private static global::NPOI.Util.BitField iconOnly = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400141B RID: 5147
		private static global::NPOI.Util.BitField reversed = global::NPOI.Util.BitFieldFactory.GetInstance(4);
	}
}
