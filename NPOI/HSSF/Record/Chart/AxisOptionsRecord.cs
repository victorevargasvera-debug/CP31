using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046A RID: 1130
	public class AxisOptionsRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060029DF RID: 10719 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxisOptionsRecord()
		{
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x0007DF10 File Offset: 0x0007C110
		public AxisOptionsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_minimumCategory = in1.ReadShort();
			this.field_2_maximumCategory = in1.ReadShort();
			this.field_3_majorUnitValue = in1.ReadShort();
			this.field_4_majorUnit = in1.ReadShort();
			this.field_5_minorUnitValue = in1.ReadShort();
			this.field_6_minorUnit = in1.ReadShort();
			this.field_7_baseUnit = in1.ReadShort();
			this.field_8_crossingPoint = in1.ReadShort();
			this.field_9_options = in1.ReadShort();
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0007DF90 File Offset: 0x0007C190
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXCEXT]\n");
			stringBuilder.Append("    .minimumCategory      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinimumCategory)).Append(" (").Append(this.MinimumCategory).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .maximumCategory      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MaximumCategory)).Append(" (").Append(this.MaximumCategory).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .majorUnitValue       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MajorUnitValue)).Append(" (").Append(this.MajorUnitValue).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .majorUnit            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MajorUnit)).Append(" (").Append(this.MajorUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .minorUnitValue       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinorUnitValue)).Append(" (").Append(this.MinorUnitValue).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .minorUnit            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinorUnit)).Append(" (").Append(this.MinorUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .baseUnit             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BaseUnit)).Append(" (").Append(this.BaseUnit).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .crossingPoint        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CrossingPoint)).Append(" (").Append(this.CrossingPoint).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .defaultMinimum           = ").Append(this.IsDefaultMinimum).Append('\n');
			stringBuilder.Append("         .defaultMaximum           = ").Append(this.IsDefaultMaximum).Append('\n');
			stringBuilder.Append("         .defaultMajor             = ").Append(this.IsDefaultMajor).Append('\n');
			stringBuilder.Append("         .defaultMinorUnit         = ").Append(this.IsDefaultMinorUnit).Append('\n');
			stringBuilder.Append("         .IsDate                   = ").Append(this.IsIsDate).Append('\n');
			stringBuilder.Append("         .defaultBase              = ").Append(this.IsDefaultBase).Append('\n');
			stringBuilder.Append("         .defaultCross             = ").Append(this.IsDefaultCross).Append('\n');
			stringBuilder.Append("         .defaultDateSettings      = ").Append(this.IsDefaultDateSettings).Append('\n');
			stringBuilder.Append("[/AXCEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x0007E388 File Offset: 0x0007C588
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_minimumCategory);
			out1.WriteShort((int)this.field_2_maximumCategory);
			out1.WriteShort((int)this.field_3_majorUnitValue);
			out1.WriteShort((int)this.field_4_majorUnit);
			out1.WriteShort((int)this.field_5_minorUnitValue);
			out1.WriteShort((int)this.field_6_minorUnit);
			out1.WriteShort((int)this.field_7_baseUnit);
			out1.WriteShort((int)this.field_8_crossingPoint);
			out1.WriteShort((int)this.field_9_options);
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0007E401 File Offset: 0x0007C601
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.sid;
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0007E408 File Offset: 0x0007C608
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisOptionsRecord
			{
				field_1_minimumCategory = this.field_1_minimumCategory,
				field_2_maximumCategory = this.field_2_maximumCategory,
				field_3_majorUnitValue = this.field_3_majorUnitValue,
				field_4_majorUnit = this.field_4_majorUnit,
				field_5_minorUnitValue = this.field_5_minorUnitValue,
				field_6_minorUnit = this.field_6_minorUnit,
				field_7_baseUnit = this.field_7_baseUnit,
				field_8_crossingPoint = this.field_8_crossingPoint,
				field_9_options = this.field_9_options
			};
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x0007E486 File Offset: 0x0007C686
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x0007E48E File Offset: 0x0007C68E
		public short MinimumCategory
		{
			get
			{
				return this.field_1_minimumCategory;
			}
			set
			{
				this.field_1_minimumCategory = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x0007E497 File Offset: 0x0007C697
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0007E49F File Offset: 0x0007C69F
		public short MaximumCategory
		{
			get
			{
				return this.field_2_maximumCategory;
			}
			set
			{
				this.field_2_maximumCategory = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x0007E4B0 File Offset: 0x0007C6B0
		public short MajorUnitValue
		{
			get
			{
				return this.field_3_majorUnitValue;
			}
			set
			{
				this.field_3_majorUnitValue = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x0007E4B9 File Offset: 0x0007C6B9
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x0007E4C1 File Offset: 0x0007C6C1
		public short MajorUnit
		{
			get
			{
				return this.field_4_majorUnit;
			}
			set
			{
				this.field_4_majorUnit = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x0007E4CA File Offset: 0x0007C6CA
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x0007E4D2 File Offset: 0x0007C6D2
		public short MinorUnitValue
		{
			get
			{
				return this.field_5_minorUnitValue;
			}
			set
			{
				this.field_5_minorUnitValue = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0007E4DB File Offset: 0x0007C6DB
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x0007E4E3 File Offset: 0x0007C6E3
		public short MinorUnit
		{
			get
			{
				return this.field_6_minorUnit;
			}
			set
			{
				this.field_6_minorUnit = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x0007E4EC File Offset: 0x0007C6EC
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x0007E4F4 File Offset: 0x0007C6F4
		public short BaseUnit
		{
			get
			{
				return this.field_7_baseUnit;
			}
			set
			{
				this.field_7_baseUnit = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x0007E4FD File Offset: 0x0007C6FD
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x0007E505 File Offset: 0x0007C705
		public short CrossingPoint
		{
			get
			{
				return this.field_8_crossingPoint;
			}
			set
			{
				this.field_8_crossingPoint = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x0007E50E File Offset: 0x0007C70E
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x0007E516 File Offset: 0x0007C716
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

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x0007E51F File Offset: 0x0007C71F
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x0007E531 File Offset: 0x0007C731
		public bool IsDefaultMinimum
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMinimum.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMinimum.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x0007E54A File Offset: 0x0007C74A
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x0007E55C File Offset: 0x0007C75C
		public bool IsDefaultMaximum
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMaximum.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMaximum.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x0007E575 File Offset: 0x0007C775
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x0007E587 File Offset: 0x0007C787
		public bool IsDefaultMajor
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMajor.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMajor.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x0007E5A0 File Offset: 0x0007C7A0
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x0007E5B2 File Offset: 0x0007C7B2
		public bool IsDefaultMinorUnit
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMinorUnit.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultMinorUnit.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void SetIsDate(bool value)
		{
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x0007E5CB File Offset: 0x0007C7CB
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x0007E5DD File Offset: 0x0007C7DD
		public bool IsIsDate
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.isDate.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.isDate.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0007E5F6 File Offset: 0x0007C7F6
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0007E608 File Offset: 0x0007C808
		public bool IsDefaultBase
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultBase.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultBase.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0007E621 File Offset: 0x0007C821
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0007E633 File Offset: 0x0007C833
		public bool IsDefaultCross
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultCross.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultCross.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0007E64C File Offset: 0x0007C84C
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0007E65E File Offset: 0x0007C85E
		public bool IsDefaultDateSettings
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultDateSettings.IsSet((int)this.field_9_options);
			}
			set
			{
				this.field_9_options = global::NPOI.HSSF.Record.Chart.AxisOptionsRecord.defaultDateSettings.SetShortBoolean(this.field_9_options, value);
			}
		}

		// Token: 0x04001222 RID: 4642
		public static short sid = 4194;

		// Token: 0x04001223 RID: 4643
		private static global::NPOI.Util.BitField defaultMinimum = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001224 RID: 4644
		private static global::NPOI.Util.BitField defaultMaximum = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001225 RID: 4645
		private static global::NPOI.Util.BitField defaultMajor = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001226 RID: 4646
		private static global::NPOI.Util.BitField defaultMinorUnit = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001227 RID: 4647
		private static global::NPOI.Util.BitField isDate = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001228 RID: 4648
		private static global::NPOI.Util.BitField defaultBase = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04001229 RID: 4649
		private static global::NPOI.Util.BitField defaultCross = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x0400122A RID: 4650
		private static global::NPOI.Util.BitField defaultDateSettings = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x0400122B RID: 4651
		private short field_1_minimumCategory;

		// Token: 0x0400122C RID: 4652
		private short field_2_maximumCategory;

		// Token: 0x0400122D RID: 4653
		private short field_3_majorUnitValue;

		// Token: 0x0400122E RID: 4654
		private short field_4_majorUnit;

		// Token: 0x0400122F RID: 4655
		private short field_5_minorUnitValue;

		// Token: 0x04001230 RID: 4656
		private short field_6_minorUnit;

		// Token: 0x04001231 RID: 4657
		private short field_7_baseUnit;

		// Token: 0x04001232 RID: 4658
		private short field_8_crossingPoint;

		// Token: 0x04001233 RID: 4659
		private short field_9_options;
	}
}
