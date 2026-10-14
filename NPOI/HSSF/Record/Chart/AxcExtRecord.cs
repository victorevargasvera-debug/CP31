using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000466 RID: 1126
	public class AxcExtRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060029A3 RID: 10659 RVA: 0x0007D4E4 File Offset: 0x0007B6E4
		public AxcExtRecord()
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0007D560 File Offset: 0x0007B760
		public AxcExtRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_catMin = in1.ReadShort();
			this.field_2_catMax = in1.ReadShort();
			this.field_3_catMajor = in1.ReadShort();
			this.field_4_duMajor = in1.ReadShort();
			this.field_5_catMinor = in1.ReadShort();
			this.field_6_duMinor = in1.ReadShort();
			this.field_7_duBase = in1.ReadShort();
			this.field_8_catCrossDate = in1.ReadShort();
			this.field_9_options = in1.ReadShort();
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0007D648 File Offset: 0x0007B848
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXCEXT]\n");
			stringBuilder.Append("    .catMin      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinimumDate)).Append(" (").Append(this.MinimumDate).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catMax      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MaximumDate)).Append(" (").Append(this.MaximumDate).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catMajor       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MajorInterval)).Append(" (").Append(this.MajorInterval).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .duMajor            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex((short)this.MajorUnit)).Append(" (").Append(this.MajorUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catMinor       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinorInterval)).Append(" (").Append(this.MinorInterval).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .duMinor            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex((short)this.MinorUnit)).Append(" (").Append(this.MinorUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .duBase             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex((short)this.BaseUnit)).Append(" (").Append(this.BaseUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .catCrossDate        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CrossDate)).Append(" (").Append(this.CrossDate).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .fAutoMin           = ").Append(this.IsAutoMin).Append('\n');
			stringBuilder.Append("         .fAutoMax           = ").Append(this.IsAutoMax).Append('\n');
			stringBuilder.Append("         .fAutoMajor         = ").Append(this.IsAutoMajor).Append('\n');
			stringBuilder.Append("         .fAutoMinor         = ").Append(this.IsAutoMinor).Append('\n');
			stringBuilder.Append("         .fDateAxis          = ").Append(this.IsDateAxis).Append('\n');
			stringBuilder.Append("         .fAutoBase          = ").Append(this.IsAutoBase).Append('\n');
			stringBuilder.Append("         .fAutoCross         = ").Append(this.IsAutoCross).Append('\n');
			stringBuilder.Append("         .fAutoDate          = ").Append(this.IsAutoDate).Append('\n');
			stringBuilder.Append("[/AXCEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0007DA54 File Offset: 0x0007BC54
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_catMin);
			out1.WriteShort((int)this.field_2_catMax);
			out1.WriteShort((int)this.field_3_catMajor);
			out1.WriteShort((int)this.field_4_duMajor);
			out1.WriteShort((int)this.field_5_catMinor);
			out1.WriteShort((int)this.field_6_duMinor);
			out1.WriteShort((int)this.field_7_duBase);
			out1.WriteShort((int)this.field_8_catCrossDate);
			out1.WriteShort((int)this.field_9_options);
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0007DACD File Offset: 0x0007BCCD
		public override short Sid
		{
			get
			{
				return 4194;
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxcExtRecord
			{
				field_1_catMin = this.field_1_catMin,
				field_2_catMax = this.field_2_catMax,
				field_3_catMajor = this.field_3_catMajor,
				field_4_duMajor = this.field_4_duMajor,
				field_5_catMinor = this.field_5_catMinor,
				field_6_duMinor = this.field_6_duMinor,
				field_7_duBase = this.field_7_duBase,
				field_8_catCrossDate = this.field_8_catCrossDate,
				field_9_options = this.field_9_options
			};
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x0007DB52 File Offset: 0x0007BD52
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0007DB5A File Offset: 0x0007BD5A
		public short MinimumDate
		{
			get
			{
				return this.field_1_catMin;
			}
			set
			{
				this.field_1_catMin = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0007DB63 File Offset: 0x0007BD63
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0007DB6B File Offset: 0x0007BD6B
		public short MaximumDate
		{
			get
			{
				return this.field_2_catMax;
			}
			set
			{
				this.field_2_catMax = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0007DB74 File Offset: 0x0007BD74
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x0007DB7C File Offset: 0x0007BD7C
		public short MajorInterval
		{
			get
			{
				return this.field_3_catMajor;
			}
			set
			{
				this.field_3_catMajor = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x0007DB85 File Offset: 0x0007BD85
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x0007DB8D File Offset: 0x0007BD8D
		public global::NPOI.HSSF.Record.Chart.DateUnit MajorUnit
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.DateUnit)this.field_4_duMajor;
			}
			set
			{
				this.field_4_duMajor = (short)value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x0007DB97 File Offset: 0x0007BD97
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x0007DB9F File Offset: 0x0007BD9F
		public short MinorInterval
		{
			get
			{
				return this.field_5_catMinor;
			}
			set
			{
				this.field_5_catMinor = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x0007DBA8 File Offset: 0x0007BDA8
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x0007DBB0 File Offset: 0x0007BDB0
		public global::NPOI.HSSF.Record.Chart.DateUnit MinorUnit
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.DateUnit)this.field_6_duMinor;
			}
			set
			{
				this.field_6_duMinor = (short)value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x0007DBBA File Offset: 0x0007BDBA
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x0007DBC2 File Offset: 0x0007BDC2
		public global::NPOI.HSSF.Record.Chart.DateUnit BaseUnit
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.DateUnit)this.field_7_duBase;
			}
			set
			{
				this.field_7_duBase = (short)value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x0007DBCC File Offset: 0x0007BDCC
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0007DBD4 File Offset: 0x0007BDD4
		public short CrossDate
		{
			get
			{
				return this.field_8_catCrossDate;
			}
			set
			{
				this.field_8_catCrossDate = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x0007DBDD File Offset: 0x0007BDDD
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x0007DBE5 File Offset: 0x0007BDE5
		public short Options
		{
			get
			{
				return this.field_9_options;
			}
			set
			{
				this.field_9_options = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0007DBEE File Offset: 0x0007BDEE
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x0007DC01 File Offset: 0x0007BE01
		public bool IsAutoMin
		{
			get
			{
				return this.fAutoMin.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoMin.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x0007DC1B File Offset: 0x0007BE1B
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x0007DC2E File Offset: 0x0007BE2E
		public bool IsAutoMax
		{
			get
			{
				return this.fAutoMax.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoMax.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0007DC48 File Offset: 0x0007BE48
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x0007DC5B File Offset: 0x0007BE5B
		public bool IsAutoMajor
		{
			get
			{
				return this.fAutoMajor.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoMajor.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0007DC75 File Offset: 0x0007BE75
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0007DC88 File Offset: 0x0007BE88
		public bool IsAutoMinor
		{
			get
			{
				return this.fAutoMinor.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoMinor.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0007DCA2 File Offset: 0x0007BEA2
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0007DCB5 File Offset: 0x0007BEB5
		public bool IsDateAxis
		{
			get
			{
				return this.fDateAxis.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fDateAxis.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x0007DCCF File Offset: 0x0007BECF
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x0007DCE2 File Offset: 0x0007BEE2
		public bool IsAutoBase
		{
			get
			{
				return this.fAutoBase.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoBase.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x0007DCFC File Offset: 0x0007BEFC
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x0007DD0F File Offset: 0x0007BF0F
		public bool IsAutoCross
		{
			get
			{
				return this.fAutoCross.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoCross.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x0007DD29 File Offset: 0x0007BF29
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x0007DD3C File Offset: 0x0007BF3C
		public bool IsAutoDate
		{
			get
			{
				return this.fAutoDate.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = this.fAutoDate.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x04001203 RID: 4611
		public const short sid = 4194;

		// Token: 0x04001204 RID: 4612
		private short field_1_catMin;

		// Token: 0x04001205 RID: 4613
		private short field_2_catMax;

		// Token: 0x04001206 RID: 4614
		private short field_3_catMajor;

		// Token: 0x04001207 RID: 4615
		private short field_4_duMajor;

		// Token: 0x04001208 RID: 4616
		private short field_5_catMinor;

		// Token: 0x04001209 RID: 4617
		private short field_6_duMinor;

		// Token: 0x0400120A RID: 4618
		private short field_7_duBase;

		// Token: 0x0400120B RID: 4619
		private short field_8_catCrossDate;

		// Token: 0x0400120C RID: 4620
		private short field_9_options;

		// Token: 0x0400120D RID: 4621
		private global::NPOI.Util.BitField fAutoMin = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400120E RID: 4622
		private global::NPOI.Util.BitField fAutoMax = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x0400120F RID: 4623
		private global::NPOI.Util.BitField fAutoMajor = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001210 RID: 4624
		private global::NPOI.Util.BitField fAutoMinor = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001211 RID: 4625
		private global::NPOI.Util.BitField fDateAxis = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001212 RID: 4626
		private global::NPOI.Util.BitField fAutoBase = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04001213 RID: 4627
		private global::NPOI.Util.BitField fAutoCross = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04001214 RID: 4628
		private global::NPOI.Util.BitField fAutoDate = global::NPOI.Util.BitFieldFactory.GetInstance(128);
	}
}
