using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043F RID: 1087
	public class WindowTwoRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x000790A8 File Offset: 0x000772A8
		public WindowTwoRecord()
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00079164 File Offset: 0x00077364
		public WindowTwoRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int remaining = in1.Remaining;
			this.field_1_options = in1.ReadShort();
			this.field_2_top_row = in1.ReadShort();
			this.field_3_left_col = in1.ReadShort();
			this.field_4_header_color = in1.ReadInt();
			if (remaining > 10)
			{
				this.field_5_page_break_zoom = in1.ReadShort();
				this.field_6_normal_zoom = in1.ReadShort();
			}
			if (remaining > 14)
			{
				this.field_7_reserved = in1.ReadInt();
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x00079281 File Offset: 0x00077481
		// (set) Token: 0x06002837 RID: 10295 RVA: 0x00079289 File Offset: 0x00077489
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

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x00079292 File Offset: 0x00077492
		// (set) Token: 0x06002839 RID: 10297 RVA: 0x000792A5 File Offset: 0x000774A5
		public bool DisplayFormulas
		{
			get
			{
				return this.displayFormulas.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.displayFormulas.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000792BF File Offset: 0x000774BF
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x000792D2 File Offset: 0x000774D2
		public bool DisplayGridlines
		{
			get
			{
				return this.displayGridlines.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.displayGridlines.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x000792EC File Offset: 0x000774EC
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x000792FF File Offset: 0x000774FF
		public bool DisplayRowColHeadings
		{
			get
			{
				return this.displayRowColHeadings.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.displayRowColHeadings.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x00079319 File Offset: 0x00077519
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x0007932C File Offset: 0x0007752C
		public bool FreezePanes
		{
			get
			{
				return this.freezePanes.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.freezePanes.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x00079346 File Offset: 0x00077546
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x00079359 File Offset: 0x00077559
		public bool DisplayZeros
		{
			get
			{
				return this.displayZeros.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.displayZeros.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x00079373 File Offset: 0x00077573
		// (set) Token: 0x06002843 RID: 10307 RVA: 0x00079386 File Offset: 0x00077586
		public bool DefaultHeader
		{
			get
			{
				return this.defaultHeader.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.defaultHeader.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000793A0 File Offset: 0x000775A0
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x000793B3 File Offset: 0x000775B3
		public bool Arabic
		{
			get
			{
				return this.arabic.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.arabic.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000793CD File Offset: 0x000775CD
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x000793E0 File Offset: 0x000775E0
		public bool DisplayGuts
		{
			get
			{
				return this.displayGuts.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.displayGuts.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000793FA File Offset: 0x000775FA
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0007940D File Offset: 0x0007760D
		public bool FreezePanesNoSplit
		{
			get
			{
				return this.freezePanesNoSplit.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.freezePanesNoSplit.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x00079427 File Offset: 0x00077627
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0007943A File Offset: 0x0007763A
		public bool IsSelected
		{
			get
			{
				return this.selected.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.selected.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x00079454 File Offset: 0x00077654
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x00079467 File Offset: 0x00077667
		public bool IsActive
		{
			get
			{
				return this.active.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.active.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x00079481 File Offset: 0x00077681
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x00079494 File Offset: 0x00077694
		public bool SavedInPageBreakPreview
		{
			get
			{
				return this.savedInPageBreakPreview.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = this.savedInPageBreakPreview.SetShortBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000794AE File Offset: 0x000776AE
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x000794B6 File Offset: 0x000776B6
		public short TopRow
		{
			get
			{
				return this.field_2_top_row;
			}
			set
			{
				this.field_2_top_row = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000794BF File Offset: 0x000776BF
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x000794C7 File Offset: 0x000776C7
		public short LeftCol
		{
			get
			{
				return this.field_3_left_col;
			}
			set
			{
				this.field_3_left_col = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000794D0 File Offset: 0x000776D0
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x000794D8 File Offset: 0x000776D8
		public int HeaderColor
		{
			get
			{
				return this.field_4_header_color;
			}
			set
			{
				this.field_4_header_color = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x000794E1 File Offset: 0x000776E1
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x000794E9 File Offset: 0x000776E9
		public short PageBreakZoom
		{
			get
			{
				return this.field_5_page_break_zoom;
			}
			set
			{
				this.field_5_page_break_zoom = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000794F2 File Offset: 0x000776F2
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x000794FA File Offset: 0x000776FA
		public short NormalZoom
		{
			get
			{
				return this.field_6_normal_zoom;
			}
			set
			{
				this.field_6_normal_zoom = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x00079503 File Offset: 0x00077703
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x0007950B File Offset: 0x0007770B
		public int Reserved
		{
			get
			{
				return this.field_7_reserved;
			}
			set
			{
				this.field_7_reserved = value;
			}
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00079514 File Offset: 0x00077714
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WINDOW2]\n");
			stringBuilder.Append("    .options        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Options)).Append("\n");
			stringBuilder.Append("       .dispformulas= ").Append(this.DisplayFormulas).Append("\n");
			stringBuilder.Append("       .dispgridlins= ").Append(this.DisplayGridlines).Append("\n");
			stringBuilder.Append("       .disprcheadin= ").Append(this.DisplayRowColHeadings).Append("\n");
			stringBuilder.Append("       .freezepanes = ").Append(this.FreezePanes).Append("\n");
			stringBuilder.Append("       .Displayzeros= ").Append(this.DisplayZeros).Append("\n");
			stringBuilder.Append("       .defaultheadr= ").Append(this.DefaultHeader).Append("\n");
			stringBuilder.Append("       .arabic      = ").Append(this.Arabic).Append("\n");
			stringBuilder.Append("       .Displayguts = ").Append(this.DisplayGuts).Append("\n");
			stringBuilder.Append("       .frzpnsnosplt= ").Append(this.FreezePanesNoSplit).Append("\n");
			stringBuilder.Append("       .selected    = ").Append(this.IsSelected).Append("\n");
			stringBuilder.Append("       .active       = ").Append(this.IsActive).Append("\n");
			stringBuilder.Append("       .svdinpgbrkpv= ").Append(this.SavedInPageBreakPreview).Append("\n");
			stringBuilder.Append("    .toprow         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.TopRow)).Append("\n");
			stringBuilder.Append("    .leftcol        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LeftCol)).Append("\n");
			stringBuilder.Append("    .headercolor    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.HeaderColor)).Append("\n");
			stringBuilder.Append("    .pagebreakzoom  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.PageBreakZoom)).Append("\n");
			stringBuilder.Append("    .normalzoom     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.NormalZoom)).Append("\n");
			stringBuilder.Append("    .reserved       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Reserved)).Append("\n");
			stringBuilder.Append("[/WINDOW2]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000797DC File Offset: 0x000779DC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Options);
			out1.WriteShort((int)this.TopRow);
			out1.WriteShort((int)this.LeftCol);
			out1.WriteInt(this.HeaderColor);
			out1.WriteShort((int)this.PageBreakZoom);
			out1.WriteShort((int)this.NormalZoom);
			out1.WriteInt(this.Reserved);
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0007983D File Offset: 0x00077A3D
		public override short Sid
		{
			get
			{
				return 574;
			}
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00079844 File Offset: 0x00077A44
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.WindowTwoRecord
			{
				field_1_options = this.field_1_options,
				field_2_top_row = this.field_2_top_row,
				field_3_left_col = this.field_3_left_col,
				field_4_header_color = this.field_4_header_color,
				field_5_page_break_zoom = this.field_5_page_break_zoom,
				field_6_normal_zoom = this.field_6_normal_zoom,
				field_7_reserved = this.field_7_reserved
			};
		}

		// Token: 0x04001112 RID: 4370
		public const short sid = 574;

		// Token: 0x04001113 RID: 4371
		private global::NPOI.Util.BitField displayFormulas = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001114 RID: 4372
		private global::NPOI.Util.BitField displayGridlines = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001115 RID: 4373
		private global::NPOI.Util.BitField displayRowColHeadings = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001116 RID: 4374
		private global::NPOI.Util.BitField freezePanes = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001117 RID: 4375
		private global::NPOI.Util.BitField displayZeros = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001118 RID: 4376
		private global::NPOI.Util.BitField defaultHeader = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04001119 RID: 4377
		private global::NPOI.Util.BitField arabic = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x0400111A RID: 4378
		private global::NPOI.Util.BitField displayGuts = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x0400111B RID: 4379
		private global::NPOI.Util.BitField freezePanesNoSplit = global::NPOI.Util.BitFieldFactory.GetInstance(256);

		// Token: 0x0400111C RID: 4380
		private global::NPOI.Util.BitField selected = global::NPOI.Util.BitFieldFactory.GetInstance(512);

		// Token: 0x0400111D RID: 4381
		private global::NPOI.Util.BitField active = global::NPOI.Util.BitFieldFactory.GetInstance(1024);

		// Token: 0x0400111E RID: 4382
		private global::NPOI.Util.BitField savedInPageBreakPreview = global::NPOI.Util.BitFieldFactory.GetInstance(2048);

		// Token: 0x0400111F RID: 4383
		private short field_1_options;

		// Token: 0x04001120 RID: 4384
		private short field_2_top_row;

		// Token: 0x04001121 RID: 4385
		private short field_3_left_col;

		// Token: 0x04001122 RID: 4386
		private int field_4_header_color;

		// Token: 0x04001123 RID: 4387
		private short field_5_page_break_zoom;

		// Token: 0x04001124 RID: 4388
		private short field_6_normal_zoom;

		// Token: 0x04001125 RID: 4389
		private int field_7_reserved;
	}
}
