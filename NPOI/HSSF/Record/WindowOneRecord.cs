using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043D RID: 1085
	public class WindowOneRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x0005FE49 File Offset: 0x0005E049
		public WindowOneRecord()
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00078AF0 File Offset: 0x00076CF0
		public WindowOneRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_h_hold = in1.ReadShort();
			this.field_2_v_hold = in1.ReadShort();
			this.field_3_width = in1.ReadShort();
			this.field_4_height = in1.ReadShort();
			this.field_5_options = in1.ReadShort();
			this.field_6_active_sheet = (int)in1.ReadShort();
			this.field_7_first_visible_tab = (int)in1.ReadShort();
			this.field_8_num_selected_tabs = in1.ReadShort();
			this.field_9_tab_width_ratio = in1.ReadShort();
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00078B6F File Offset: 0x00076D6F
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x00078B77 File Offset: 0x00076D77
		public short HorizontalHold
		{
			get
			{
				return this.field_1_h_hold;
			}
			set
			{
				this.field_1_h_hold = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x00078B80 File Offset: 0x00076D80
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x00078B88 File Offset: 0x00076D88
		public short VerticalHold
		{
			get
			{
				return this.field_2_v_hold;
			}
			set
			{
				this.field_2_v_hold = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x00078B91 File Offset: 0x00076D91
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00078B99 File Offset: 0x00076D99
		public short Width
		{
			get
			{
				return this.field_3_width;
			}
			set
			{
				this.field_3_width = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00078BA2 File Offset: 0x00076DA2
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00078BAA File Offset: 0x00076DAA
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x00078BB3 File Offset: 0x00076DB3
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x00078BBB File Offset: 0x00076DBB
		public short Options
		{
			get
			{
				return this.field_5_options;
			}
			set
			{
				this.field_5_options = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x00078BC4 File Offset: 0x00076DC4
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x00078BD6 File Offset: 0x00076DD6
		public bool Hidden
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowOneRecord.hidden.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = global::NPOI.HSSF.Record.WindowOneRecord.hidden.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00078BEF File Offset: 0x00076DEF
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00078C01 File Offset: 0x00076E01
		public bool Iconic
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowOneRecord.iconic.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = global::NPOI.HSSF.Record.WindowOneRecord.iconic.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00078C1A File Offset: 0x00076E1A
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00078C2C File Offset: 0x00076E2C
		public bool DisplayHorizontalScrollbar
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowOneRecord.hscroll.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = global::NPOI.HSSF.Record.WindowOneRecord.hscroll.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x00078C45 File Offset: 0x00076E45
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00078C57 File Offset: 0x00076E57
		public bool DisplayVerticalScrollbar
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowOneRecord.vscroll.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = global::NPOI.HSSF.Record.WindowOneRecord.vscroll.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x00078C70 File Offset: 0x00076E70
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00078C82 File Offset: 0x00076E82
		public bool DisplayTabs
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowOneRecord.tabs.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = global::NPOI.HSSF.Record.WindowOneRecord.tabs.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x00078C9B File Offset: 0x00076E9B
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00078CA3 File Offset: 0x00076EA3
		public int ActiveSheetIndex
		{
			get
			{
				return this.field_6_active_sheet;
			}
			set
			{
				this.field_6_active_sheet = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x00078CAC File Offset: 0x00076EAC
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x00078CB4 File Offset: 0x00076EB4
		public int FirstVisibleTab
		{
			get
			{
				return this.field_7_first_visible_tab;
			}
			set
			{
				this.field_7_first_visible_tab = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x00078CBD File Offset: 0x00076EBD
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x00078CC5 File Offset: 0x00076EC5
		public short NumSelectedTabs
		{
			get
			{
				return this.field_8_num_selected_tabs;
			}
			set
			{
				this.field_8_num_selected_tabs = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x00078CCE File Offset: 0x00076ECE
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x00078CD6 File Offset: 0x00076ED6
		public short TabWidthRatio
		{
			get
			{
				return this.field_9_tab_width_ratio;
			}
			set
			{
				this.field_9_tab_width_ratio = value;
			}
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00078CE0 File Offset: 0x00076EE0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WINDOW1]\n");
			stringBuilder.Append("    .h_hold          = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.HorizontalHold)).Append("\n");
			stringBuilder.Append("    .v_hold          = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.VerticalHold)).Append("\n");
			stringBuilder.Append("    .width           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Width)).Append("\n");
			stringBuilder.Append("    .height          = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Height)).Append("\n");
			stringBuilder.Append("    .options         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Options)).Append("\n");
			stringBuilder.Append("        .hidden      = ").Append(this.Hidden).Append("\n");
			stringBuilder.Append("        .iconic      = ").Append(this.Iconic).Append("\n");
			stringBuilder.Append("        .hscroll     = ").Append(this.DisplayHorizontalScrollbar).Append("\n");
			stringBuilder.Append("        .vscroll     = ").Append(this.DisplayVerticalScrollbar).Append("\n");
			stringBuilder.Append("        .tabs        = ").Append(this.DisplayTabs).Append("\n");
			stringBuilder.Append("    .activeSheet     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ActiveSheetIndex)).Append("\n");
			stringBuilder.Append("    .firstVisibleTab    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstVisibleTab)).Append("\n");
			stringBuilder.Append("    .numselectedtabs = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.NumSelectedTabs)).Append("\n");
			stringBuilder.Append("    .tabwidthratio   = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.TabWidthRatio)).Append("\n");
			stringBuilder.Append("[/WINDOW1]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00078F0C File Offset: 0x0007710C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.HorizontalHold);
			out1.WriteShort((int)this.VerticalHold);
			out1.WriteShort((int)this.Width);
			out1.WriteShort((int)this.Height);
			out1.WriteShort((int)this.Options);
			out1.WriteShort(this.ActiveSheetIndex);
			out1.WriteShort(this.FirstVisibleTab);
			out1.WriteShort((int)this.NumSelectedTabs);
			out1.WriteShort((int)this.TabWidthRatio);
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x00078F85 File Offset: 0x00077185
		public override short Sid
		{
			get
			{
				return 61;
			}
		}

		// Token: 0x040010FF RID: 4351
		public const short sid = 61;

		// Token: 0x04001100 RID: 4352
		private short field_1_h_hold;

		// Token: 0x04001101 RID: 4353
		private short field_2_v_hold;

		// Token: 0x04001102 RID: 4354
		private short field_3_width;

		// Token: 0x04001103 RID: 4355
		private short field_4_height;

		// Token: 0x04001104 RID: 4356
		private short field_5_options;

		// Token: 0x04001105 RID: 4357
		private static global::NPOI.Util.BitField hidden = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001106 RID: 4358
		private static global::NPOI.Util.BitField iconic = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001107 RID: 4359
		private static global::NPOI.Util.BitField reserved = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001108 RID: 4360
		private static global::NPOI.Util.BitField hscroll = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001109 RID: 4361
		private static global::NPOI.Util.BitField vscroll = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x0400110A RID: 4362
		private static global::NPOI.Util.BitField tabs = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x0400110B RID: 4363
		private int field_6_active_sheet;

		// Token: 0x0400110C RID: 4364
		private int field_7_first_visible_tab;

		// Token: 0x0400110D RID: 4365
		private short field_8_num_selected_tabs;

		// Token: 0x0400110E RID: 4366
		private short field_9_tab_width_ratio;
	}
}
