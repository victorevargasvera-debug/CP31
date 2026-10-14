using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046F RID: 1135
	public class CatSerRangeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002A31 RID: 10801 RVA: 0x0007EB2B File Offset: 0x0007CD2B
		public CatSerRangeRecord()
		{
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0007EB58 File Offset: 0x0007CD58
		public CatSerRangeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_catCross = in1.ReadShort();
			this.field_2_catLabel = in1.ReadShort();
			this.field_3_catMark = in1.ReadShort();
			this.field_4_options = in1.ReadShort();
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0007EBC0 File Offset: 0x0007CDC0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CATSERRANGE]\n");
			stringBuilder.Append("    .catCross        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CrossPoint)).Append(" (").Append(this.CrossPoint).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catLabel       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LabelInterval)).Append(" (").Append(this.LabelInterval).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catMark    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MarkInterval)).Append(" (").Append(this.MarkInterval).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .fBetween        = ").Append(this.IsBetween).Append('\n');
			stringBuilder.Append("         .fMaxCross       = ").Append(this.IsMaxCross).Append('\n');
			stringBuilder.Append("         .fReverse        = ").Append(this.IsReverse).Append('\n');
			stringBuilder.Append("[/CATSERRANGE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0007ED8D File Offset: 0x0007CF8D
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_catCross);
			out1.WriteShort((int)this.field_2_catLabel);
			out1.WriteShort((int)this.field_3_catMark);
			out1.WriteShort((int)this.field_4_options);
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x0007EDBF File Offset: 0x0007CFBF
		public override short Sid
		{
			get
			{
				return 4128;
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0007EDC6 File Offset: 0x0007CFC6
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.CatSerRangeRecord
			{
				field_1_catCross = this.field_1_catCross,
				field_2_catLabel = this.field_2_catLabel,
				field_3_catMark = this.field_3_catMark,
				field_4_options = this.field_4_options
			};
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0007EDFD File Offset: 0x0007CFFD
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x0007EE05 File Offset: 0x0007D005
		public short CrossPoint
		{
			get
			{
				return this.field_1_catCross;
			}
			set
			{
				this.field_1_catCross = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x0007EE0E File Offset: 0x0007D00E
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x0007EE16 File Offset: 0x0007D016
		public short LabelInterval
		{
			get
			{
				return this.field_2_catLabel;
			}
			set
			{
				this.field_2_catLabel = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x0007EE1F File Offset: 0x0007D01F
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x0007EE27 File Offset: 0x0007D027
		public short MarkInterval
		{
			get
			{
				return this.field_3_catMark;
			}
			set
			{
				this.field_3_catMark = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x0007EE30 File Offset: 0x0007D030
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x0007EE38 File Offset: 0x0007D038
		public short Options
		{
			get
			{
				return this.field_4_options;
			}
			set
			{
				this.field_4_options = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x0007EE41 File Offset: 0x0007D041
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x0007EE54 File Offset: 0x0007D054
		public bool IsBetween
		{
			get
			{
				return this.fBetween.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = this.fBetween.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x0007EE6E File Offset: 0x0007D06E
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x0007EE81 File Offset: 0x0007D081
		public bool IsMaxCross
		{
			get
			{
				return this.fMaxCross.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = this.fMaxCross.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x0007EE9B File Offset: 0x0007D09B
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x0007EEAE File Offset: 0x0007D0AE
		public bool IsReverse
		{
			get
			{
				return this.fReverse.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = this.fReverse.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x04001240 RID: 4672
		public const short sid = 4128;

		// Token: 0x04001241 RID: 4673
		private short field_1_catCross;

		// Token: 0x04001242 RID: 4674
		private short field_2_catLabel;

		// Token: 0x04001243 RID: 4675
		private short field_3_catMark;

		// Token: 0x04001244 RID: 4676
		private short field_4_options;

		// Token: 0x04001245 RID: 4677
		private global::NPOI.Util.BitField fBetween = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001246 RID: 4678
		private global::NPOI.Util.BitField fMaxCross = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001247 RID: 4679
		private global::NPOI.Util.BitField fReverse = global::NPOI.Util.BitFieldFactory.GetInstance(4);
	}
}
