using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000408 RID: 1032
	public class PrintSetupRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600257D RID: 9597 RVA: 0x000709DC File Offset: 0x0006EBDC
		public PrintSetupRecord()
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00070A78 File Offset: 0x0006EC78
		public PrintSetupRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_paper_size = in1.ReadShort();
			this.field_2_scale = in1.ReadShort();
			this.field_3_page_start = in1.ReadShort();
			this.field_4_fit_width = in1.ReadShort();
			this.field_5_fit_height = in1.ReadShort();
			this.field_6_options = in1.ReadShort();
			this.field_7_hresolution = in1.ReadShort();
			this.field_8_vresolution = in1.ReadShort();
			this.field_9_headermargin = in1.ReadDouble();
			this.field_10_footermargin = in1.ReadDouble();
			this.field_11_copies = in1.ReadShort();
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x00070B96 File Offset: 0x0006ED96
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00070B9E File Offset: 0x0006ED9E
		public short PaperSize
		{
			get
			{
				return this.field_1_paper_size;
			}
			set
			{
				this.field_1_paper_size = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x00070BA7 File Offset: 0x0006EDA7
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x00070BAF File Offset: 0x0006EDAF
		public short Scale
		{
			get
			{
				return this.field_2_scale;
			}
			set
			{
				this.field_2_scale = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x00070BC0 File Offset: 0x0006EDC0
		public short PageStart
		{
			get
			{
				return this.field_3_page_start;
			}
			set
			{
				this.field_3_page_start = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00070BC9 File Offset: 0x0006EDC9
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00070BD1 File Offset: 0x0006EDD1
		public short FitWidth
		{
			get
			{
				return this.field_4_fit_width;
			}
			set
			{
				this.field_4_fit_width = value;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x00070BDA File Offset: 0x0006EDDA
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00070BE2 File Offset: 0x0006EDE2
		public short FitHeight
		{
			get
			{
				return this.field_5_fit_height;
			}
			set
			{
				this.field_5_fit_height = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x00070BEB File Offset: 0x0006EDEB
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x00070BF3 File Offset: 0x0006EDF3
		public short Options
		{
			get
			{
				return this.field_6_options;
			}
			set
			{
				this.field_6_options = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00070BFC File Offset: 0x0006EDFC
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00070C0F File Offset: 0x0006EE0F
		public bool LeftToRight
		{
			get
			{
				return this.lefttoright.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.lefttoright.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00070C29 File Offset: 0x0006EE29
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00070C3C File Offset: 0x0006EE3C
		public bool Landscape
		{
			get
			{
				return this.landscape.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.landscape.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x00070C56 File Offset: 0x0006EE56
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00070C69 File Offset: 0x0006EE69
		public bool ValidSettings
		{
			get
			{
				return this.validSettings.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.validSettings.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x00070C83 File Offset: 0x0006EE83
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00070C96 File Offset: 0x0006EE96
		public bool NoColor
		{
			get
			{
				return this.nocolor.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.nocolor.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x00070CB0 File Offset: 0x0006EEB0
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x00070CC3 File Offset: 0x0006EEC3
		public bool Draft
		{
			get
			{
				return this.draft.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.draft.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00070CDD File Offset: 0x0006EEDD
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00070CF0 File Offset: 0x0006EEF0
		public bool Notes
		{
			get
			{
				return this.notes.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.notes.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x00070D0A File Offset: 0x0006EF0A
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x00070D1D File Offset: 0x0006EF1D
		public bool NoOrientation
		{
			get
			{
				return this.noOrientation.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.noOrientation.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x00070D37 File Offset: 0x0006EF37
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x00070D4A File Offset: 0x0006EF4A
		public bool UsePage
		{
			get
			{
				return this.usepage.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.usepage.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x00070D64 File Offset: 0x0006EF64
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x00070D6C File Offset: 0x0006EF6C
		public short HResolution
		{
			get
			{
				return this.field_7_hresolution;
			}
			set
			{
				this.field_7_hresolution = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x00070D75 File Offset: 0x0006EF75
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x00070D7D File Offset: 0x0006EF7D
		public short VResolution
		{
			get
			{
				return this.field_8_vresolution;
			}
			set
			{
				this.field_8_vresolution = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x00070D86 File Offset: 0x0006EF86
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00070D8E File Offset: 0x0006EF8E
		public double HeaderMargin
		{
			get
			{
				return this.field_9_headermargin;
			}
			set
			{
				this.field_9_headermargin = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x00070D97 File Offset: 0x0006EF97
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x00070D9F File Offset: 0x0006EF9F
		public double FooterMargin
		{
			get
			{
				return this.field_10_footermargin;
			}
			set
			{
				this.field_10_footermargin = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00070DA8 File Offset: 0x0006EFA8
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00070DBB File Offset: 0x0006EFBB
		public bool EndNote
		{
			get
			{
				return this.endnote.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.endnote.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00070DD5 File Offset: 0x0006EFD5
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x00070DE8 File Offset: 0x0006EFE8
		public short CellError
		{
			get
			{
				return this.ierror.GetShortValue(this.field_6_options);
			}
			set
			{
				this.field_6_options = this.ierror.SetShortValue(this.field_6_options, value);
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x00070E02 File Offset: 0x0006F002
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x00070E0A File Offset: 0x0006F00A
		public short Copies
		{
			get
			{
				return this.field_11_copies;
			}
			set
			{
				this.field_11_copies = value;
			}
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00070E14 File Offset: 0x0006F014
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PRINTSetUP]\n");
			stringBuilder.Append("    .papersize      = ").Append(this.PaperSize).Append("\n");
			stringBuilder.Append("    .scale          = ").Append(this.Scale).Append("\n");
			stringBuilder.Append("    .pagestart      = ").Append(this.PageStart).Append("\n");
			stringBuilder.Append("    .fitwidth       = ").Append(this.FitWidth).Append("\n");
			stringBuilder.Append("    .fitheight      = ").Append(this.FitHeight).Append("\n");
			stringBuilder.Append("    .options        = ").Append(this.Options).Append("\n");
			stringBuilder.Append("        .ltor       = ").Append(this.LeftToRight).Append("\n");
			stringBuilder.Append("        .landscape  = ").Append(this.Landscape).Append("\n");
			stringBuilder.Append("        .valid      = ").Append(this.ValidSettings).Append("\n");
			stringBuilder.Append("        .mono       = ").Append(this.NoColor).Append("\n");
			stringBuilder.Append("        .draft      = ").Append(this.Draft).Append("\n");
			stringBuilder.Append("        .notes      = ").Append(this.Notes).Append("\n");
			stringBuilder.Append("        .noOrientat = ").Append(this.NoOrientation).Append("\n");
			stringBuilder.Append("        .usepage    = ").Append(this.UsePage).Append("\n");
			stringBuilder.Append("    .hresolution    = ").Append(this.HResolution).Append("\n");
			stringBuilder.Append("    .vresolution    = ").Append(this.VResolution).Append("\n");
			stringBuilder.Append("    .headermargin   = ").Append(this.HeaderMargin).Append("\n");
			stringBuilder.Append("    .footermargin   = ").Append(this.FooterMargin).Append("\n");
			stringBuilder.Append("    .copies         = ").Append(this.Copies).Append("\n");
			stringBuilder.Append("[/PRINTSetUP]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000710B8 File Offset: 0x0006F2B8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.PaperSize);
			out1.WriteShort((int)this.Scale);
			out1.WriteShort((int)this.PageStart);
			out1.WriteShort((int)this.FitWidth);
			out1.WriteShort((int)this.FitHeight);
			out1.WriteShort((int)this.Options);
			out1.WriteShort((int)this.HResolution);
			out1.WriteShort((int)this.VResolution);
			out1.WriteDouble(this.HeaderMargin);
			out1.WriteDouble(this.FooterMargin);
			out1.WriteShort((int)this.Copies);
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00066D27 File Offset: 0x00064F27
		protected override int DataSize
		{
			get
			{
				return 34;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00071149 File Offset: 0x0006F349
		public override short Sid
		{
			get
			{
				return 161;
			}
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00071150 File Offset: 0x0006F350
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PrintSetupRecord
			{
				field_1_paper_size = this.field_1_paper_size,
				field_2_scale = this.field_2_scale,
				field_3_page_start = this.field_3_page_start,
				field_4_fit_width = this.field_4_fit_width,
				field_5_fit_height = this.field_5_fit_height,
				field_6_options = this.field_6_options,
				field_7_hresolution = this.field_7_hresolution,
				field_8_vresolution = this.field_8_vresolution,
				field_9_headermargin = this.field_9_headermargin,
				field_10_footermargin = this.field_10_footermargin,
				field_11_copies = this.field_11_copies
			};
		}

		// Token: 0x04000FBF RID: 4031
		public const short sid = 161;

		// Token: 0x04000FC0 RID: 4032
		private short field_1_paper_size;

		// Token: 0x04000FC1 RID: 4033
		private short field_2_scale;

		// Token: 0x04000FC2 RID: 4034
		private short field_3_page_start;

		// Token: 0x04000FC3 RID: 4035
		private short field_4_fit_width;

		// Token: 0x04000FC4 RID: 4036
		private short field_5_fit_height;

		// Token: 0x04000FC5 RID: 4037
		private short field_6_options;

		// Token: 0x04000FC6 RID: 4038
		private global::NPOI.Util.BitField lefttoright = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000FC7 RID: 4039
		private global::NPOI.Util.BitField landscape = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000FC8 RID: 4040
		private global::NPOI.Util.BitField validSettings = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04000FC9 RID: 4041
		private global::NPOI.Util.BitField nocolor = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000FCA RID: 4042
		private global::NPOI.Util.BitField draft = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04000FCB RID: 4043
		private global::NPOI.Util.BitField notes = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000FCC RID: 4044
		private global::NPOI.Util.BitField noOrientation = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04000FCD RID: 4045
		private global::NPOI.Util.BitField usepage = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04000FCE RID: 4046
		private global::NPOI.Util.BitField endnote = global::NPOI.Util.BitFieldFactory.GetInstance(512);

		// Token: 0x04000FCF RID: 4047
		private global::NPOI.Util.BitField ierror = global::NPOI.Util.BitFieldFactory.GetInstance(3072);

		// Token: 0x04000FD0 RID: 4048
		private short field_7_hresolution;

		// Token: 0x04000FD1 RID: 4049
		private short field_8_vresolution;

		// Token: 0x04000FD2 RID: 4050
		private double field_9_headermargin;

		// Token: 0x04000FD3 RID: 4051
		private double field_10_footermargin;

		// Token: 0x04000FD4 RID: 4052
		private short field_11_copies;
	}
}
