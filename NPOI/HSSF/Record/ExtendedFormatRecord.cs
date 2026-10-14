using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D4 RID: 980
	public class ExtendedFormatRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002295 RID: 8853 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ExtendedFormatRecord()
		{
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00068D38 File Offset: 0x00066F38
		public ExtendedFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_font_index = in1.ReadShort();
			this.field_2_format_index = in1.ReadShort();
			this.field_3_cell_options = in1.ReadShort();
			this.field_4_alignment_options = in1.ReadShort();
			this.field_5_indention_options = in1.ReadShort();
			this.field_6_border_options = in1.ReadShort();
			this.field_7_palette_options = in1.ReadShort();
			this.field_8_adtl_palette_options = in1.ReadInt();
			this.field_9_fill_palette_options = in1.ReadShort();
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00068DB8 File Offset: 0x00066FB8
		public void CloneStyleFrom(global::NPOI.HSSF.Record.ExtendedFormatRecord source)
		{
			this.field_1_font_index = source.field_1_font_index;
			this.field_2_format_index = source.field_2_format_index;
			this.field_3_cell_options = source.field_3_cell_options;
			this.field_4_alignment_options = source.field_4_alignment_options;
			this.field_5_indention_options = source.field_5_indention_options;
			this.field_6_border_options = source.field_6_border_options;
			this.field_7_palette_options = source.field_7_palette_options;
			this.field_8_adtl_palette_options = source.field_8_adtl_palette_options;
			this.field_9_fill_palette_options = source.field_9_fill_palette_options;
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00068E31 File Offset: 0x00067031
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00068E39 File Offset: 0x00067039
		public short FontIndex
		{
			get
			{
				return this.field_1_font_index;
			}
			set
			{
				this.field_1_font_index = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00068E42 File Offset: 0x00067042
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00068E4A File Offset: 0x0006704A
		public short FormatIndex
		{
			get
			{
				return this.field_2_format_index;
			}
			set
			{
				this.field_2_format_index = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00068E53 File Offset: 0x00067053
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00068E5B File Offset: 0x0006705B
		public short CellOptions
		{
			get
			{
				return this.field_3_cell_options;
			}
			set
			{
				this.field_3_cell_options = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x00068E64 File Offset: 0x00067064
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x00068E76 File Offset: 0x00067076
		public bool IsLocked
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._locked.IsSet((int)this.field_3_cell_options);
			}
			set
			{
				this.field_3_cell_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._locked.SetShortBoolean(this.field_3_cell_options, value);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00068E8F File Offset: 0x0006708F
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x00068EA1 File Offset: 0x000670A1
		public bool IsHidden
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._hidden.IsSet((int)this.field_3_cell_options);
			}
			set
			{
				this.field_3_cell_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._hidden.SetShortBoolean(this.field_3_cell_options, value);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00068EBA File Offset: 0x000670BA
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00068ECC File Offset: 0x000670CC
		public short XFType
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._xf_type.GetShortValue(this.field_3_cell_options);
			}
			set
			{
				this.field_3_cell_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._xf_type.SetShortValue(this.field_3_cell_options, value);
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00068EE5 File Offset: 0x000670E5
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00068EF7 File Offset: 0x000670F7
		public bool _123Prefix
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._123_prefix.IsSet((int)this.field_3_cell_options);
			}
			set
			{
				this.field_3_cell_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._123_prefix.SetShortBoolean(this.field_3_cell_options, value);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00068F10 File Offset: 0x00067110
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x00068F22 File Offset: 0x00067122
		public short ParentIndex
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._parent_index.GetShortValue(this.field_3_cell_options);
			}
			set
			{
				this.field_3_cell_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._parent_index.SetShortValue(this.field_3_cell_options, value);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00068F3B File Offset: 0x0006713B
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x00068F43 File Offset: 0x00067143
		public short AlignmentOptions
		{
			get
			{
				return this.field_4_alignment_options;
			}
			set
			{
				this.field_4_alignment_options = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x00068F4C File Offset: 0x0006714C
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x00068F5E File Offset: 0x0006715E
		public short Alignment
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._alignment.GetShortValue(this.field_4_alignment_options);
			}
			set
			{
				this.field_4_alignment_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._alignment.SetShortValue(this.field_4_alignment_options, value);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x00068F77 File Offset: 0x00067177
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x00068F89 File Offset: 0x00067189
		public bool WrapText
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._wrap_text.IsSet((int)this.field_4_alignment_options);
			}
			set
			{
				this.field_4_alignment_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._wrap_text.SetShortBoolean(this.field_4_alignment_options, value);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x00068FA2 File Offset: 0x000671A2
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x00068FB4 File Offset: 0x000671B4
		public short VerticalAlignment
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._vertical_alignment.GetShortValue(this.field_4_alignment_options);
			}
			set
			{
				this.field_4_alignment_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._vertical_alignment.SetShortValue(this.field_4_alignment_options, value);
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00068FCD File Offset: 0x000671CD
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00068FDF File Offset: 0x000671DF
		public short JustifyLast
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._justify_last.GetShortValue(this.field_4_alignment_options);
			}
			set
			{
				this.field_4_alignment_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._justify_last.SetShortValue(this.field_4_alignment_options, value);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00068FF8 File Offset: 0x000671F8
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0006900A File Offset: 0x0006720A
		public short Rotation
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._rotation.GetShortValue(this.field_4_alignment_options);
			}
			set
			{
				this.field_4_alignment_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._rotation.SetShortValue(this.field_4_alignment_options, value);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00069023 File Offset: 0x00067223
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0006902B File Offset: 0x0006722B
		public short IndentionOptions
		{
			get
			{
				return this.field_5_indention_options;
			}
			set
			{
				this.field_5_indention_options = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00069034 File Offset: 0x00067234
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x00069046 File Offset: 0x00067246
		public short Indent
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent.GetShortValue(this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent.SetShortValue(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0006905F File Offset: 0x0006725F
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00069071 File Offset: 0x00067271
		public bool ShrinkToFit
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._shrink_to_fit.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._shrink_to_fit.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0006908A File Offset: 0x0006728A
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0006909C File Offset: 0x0006729C
		public bool MergeCells
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._merge_cells.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._merge_cells.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000690B5 File Offset: 0x000672B5
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x000690C7 File Offset: 0x000672C7
		public short ReadingOrder
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._Reading_order.GetShortValue(this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._Reading_order.SetShortValue(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000690E0 File Offset: 0x000672E0
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x000690F2 File Offset: 0x000672F2
		public bool IsIndentNotParentFormat
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_format.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_format.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x0006910B File Offset: 0x0006730B
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x0006911D File Offset: 0x0006731D
		public bool IsIndentNotParentFont
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_font.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_font.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x00069136 File Offset: 0x00067336
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x00069148 File Offset: 0x00067348
		public bool IsIndentNotParentAlignment
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_alignment.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_alignment.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00069161 File Offset: 0x00067361
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x00069173 File Offset: 0x00067373
		public bool IsIndentNotParentBorder
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_border.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_border.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0006918C File Offset: 0x0006738C
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0006919E File Offset: 0x0006739E
		public bool IsIndentNotParentPattern
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_pattern.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_pattern.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x000691B7 File Offset: 0x000673B7
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x000691C9 File Offset: 0x000673C9
		public bool IsIndentNotParentCellOptions
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_cell_options.IsSet((int)this.field_5_indention_options);
			}
			set
			{
				this.field_5_indention_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._indent_not_parent_cell_options.SetShortBoolean(this.field_5_indention_options, value);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x000691E2 File Offset: 0x000673E2
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x000691EA File Offset: 0x000673EA
		public short BorderOptions
		{
			get
			{
				return this.field_6_border_options;
			}
			set
			{
				this.field_6_border_options = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x000691F3 File Offset: 0x000673F3
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00069205 File Offset: 0x00067405
		public short BorderLeft
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._border_left.GetShortValue(this.field_6_border_options);
			}
			set
			{
				this.field_6_border_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._border_left.SetShortValue(this.field_6_border_options, value);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0006921E File Offset: 0x0006741E
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x00069230 File Offset: 0x00067430
		public short BorderRight
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._border_right.GetShortValue(this.field_6_border_options);
			}
			set
			{
				this.field_6_border_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._border_right.SetShortValue(this.field_6_border_options, value);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00069249 File Offset: 0x00067449
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0006925B File Offset: 0x0006745B
		public short BorderTop
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._border_top.GetShortValue(this.field_6_border_options);
			}
			set
			{
				this.field_6_border_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._border_top.SetShortValue(this.field_6_border_options, value);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00069274 File Offset: 0x00067474
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x00069286 File Offset: 0x00067486
		public short BorderBottom
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._border_bottom.GetShortValue(this.field_6_border_options);
			}
			set
			{
				this.field_6_border_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._border_bottom.SetShortValue(this.field_6_border_options, value);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0006929F File Offset: 0x0006749F
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x000692A7 File Offset: 0x000674A7
		public short PaletteOptions
		{
			get
			{
				return this.field_7_palette_options;
			}
			set
			{
				this.field_7_palette_options = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000692B0 File Offset: 0x000674B0
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x000692C2 File Offset: 0x000674C2
		public short LeftBorderPaletteIdx
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._left_border_palette_idx.GetShortValue(this.field_7_palette_options);
			}
			set
			{
				this.field_7_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._left_border_palette_idx.SetShortValue(this.field_7_palette_options, value);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000692DB File Offset: 0x000674DB
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x000692ED File Offset: 0x000674ED
		public short RightBorderPaletteIdx
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._right_border_palette_idx.GetShortValue(this.field_7_palette_options);
			}
			set
			{
				this.field_7_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._right_border_palette_idx.SetShortValue(this.field_7_palette_options, value);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00069306 File Offset: 0x00067506
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0006930E File Offset: 0x0006750E
		public int AdtlPaletteOptions
		{
			get
			{
				return this.field_8_adtl_palette_options;
			}
			set
			{
				this.field_8_adtl_palette_options = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00069317 File Offset: 0x00067517
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0006932A File Offset: 0x0006752A
		public short TopBorderPaletteIdx
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.ExtendedFormatRecord._top_border_palette_idx.GetValue(this.field_8_adtl_palette_options);
			}
			set
			{
				this.field_8_adtl_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._top_border_palette_idx.SetValue(this.field_8_adtl_palette_options, (int)value);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x00069343 File Offset: 0x00067543
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x00069356 File Offset: 0x00067556
		public short BottomBorderPaletteIdx
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.ExtendedFormatRecord._bottom_border_palette_idx.GetValue(this.field_8_adtl_palette_options);
			}
			set
			{
				this.field_8_adtl_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._bottom_border_palette_idx.SetValue(this.field_8_adtl_palette_options, (int)value);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x0006936F File Offset: 0x0006756F
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x00069382 File Offset: 0x00067582
		public short AdtlDiagBorderPaletteIdx
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_diag_border_palette_idx.GetValue(this.field_8_adtl_palette_options);
			}
			set
			{
				this.field_8_adtl_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_diag_border_palette_idx.SetValue(this.field_8_adtl_palette_options, (int)value);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x0006939B File Offset: 0x0006759B
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000693AE File Offset: 0x000675AE
		public short AdtlDiagLineStyle
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_diag_line_style.GetValue(this.field_8_adtl_palette_options);
			}
			set
			{
				this.field_8_adtl_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_diag_line_style.SetValue(this.field_8_adtl_palette_options, (int)value);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000693C7 File Offset: 0x000675C7
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x000693D9 File Offset: 0x000675D9
		public short Diagonal
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._diag.GetShortValue(this.field_7_palette_options);
			}
			set
			{
				this.field_7_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._diag.SetShortValue(this.field_7_palette_options, value);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000693F2 File Offset: 0x000675F2
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00069405 File Offset: 0x00067605
		public short AdtlFillPattern
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_fill_pattern.GetValue(this.field_8_adtl_palette_options);
			}
			set
			{
				this.field_8_adtl_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._adtl_fill_pattern.SetValue(this.field_8_adtl_palette_options, (int)value);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0006941E File Offset: 0x0006761E
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00069426 File Offset: 0x00067626
		public short FillPaletteOptions
		{
			get
			{
				return this.field_9_fill_palette_options;
			}
			set
			{
				this.field_9_fill_palette_options = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0006942F File Offset: 0x0006762F
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x00069441 File Offset: 0x00067641
		public short FillForeground
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._fill_foreground.GetShortValue(this.field_9_fill_palette_options);
			}
			set
			{
				this.field_9_fill_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._fill_foreground.SetShortValue(this.field_9_fill_palette_options, value);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0006945A File Offset: 0x0006765A
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0006946C File Offset: 0x0006766C
		public short FillBackground
		{
			get
			{
				return global::NPOI.HSSF.Record.ExtendedFormatRecord._fill_background.GetShortValue(this.field_9_fill_palette_options);
			}
			set
			{
				this.field_9_fill_palette_options = global::NPOI.HSSF.Record.ExtendedFormatRecord._fill_background.SetShortValue(this.field_9_fill_palette_options, value);
			}
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00069488 File Offset: 0x00067688
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[EXTENDEDFORMAT]\n");
			if (this.XFType == 1)
			{
				stringBuilder.Append(" STYLE_RECORD_TYPE\n");
			}
			else if (this.XFType == 0)
			{
				stringBuilder.Append(" CELL_RECORD_TYPE\n");
			}
			stringBuilder.Append("    .fontindex       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FontIndex)).Append("\n");
			stringBuilder.Append("    .formatindex     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FormatIndex)).Append("\n");
			stringBuilder.Append("    .celloptions     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.CellOptions)).Append("\n");
			stringBuilder.Append("          .Islocked  = ").Append(this.IsLocked).Append("\n");
			stringBuilder.Append("          .Ishidden  = ").Append(this.IsHidden).Append("\n");
			stringBuilder.Append("          .recordtype= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.XFType)).Append("\n");
			stringBuilder.Append("          .parentidx = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ParentIndex)).Append("\n");
			stringBuilder.Append("    .alignmentoptions= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.AlignmentOptions)).Append("\n");
			stringBuilder.Append("          .alignment = ").Append(this.Alignment).Append("\n");
			stringBuilder.Append("          .wraptext  = ").Append(this.WrapText).Append("\n");
			stringBuilder.Append("          .valignment= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.VerticalAlignment)).Append("\n");
			stringBuilder.Append("          .justlast  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.JustifyLast)).Append("\n");
			stringBuilder.Append("          .rotation  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Rotation)).Append("\n");
			stringBuilder.Append("    .indentionoptions= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.IndentionOptions)).Append("\n");
			stringBuilder.Append("          .indent    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Indent)).Append("\n");
			stringBuilder.Append("          .shrinktoft= ").Append(this.ShrinkToFit).Append("\n");
			stringBuilder.Append("          .mergecells= ").Append(this.MergeCells).Append("\n");
			stringBuilder.Append("          .Readngordr= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ReadingOrder)).Append("\n");
			stringBuilder.Append("          .formatflag= ").Append(this.IsIndentNotParentFormat).Append("\n");
			stringBuilder.Append("          .fontflag  = ").Append(this.IsIndentNotParentFont).Append("\n");
			stringBuilder.Append("          .prntalgnmt= ").Append(this.IsIndentNotParentAlignment).Append("\n");
			stringBuilder.Append("          .borderflag= ").Append(this.IsIndentNotParentBorder).Append("\n");
			stringBuilder.Append("          .paternflag= ").Append(this.IsIndentNotParentPattern).Append("\n");
			stringBuilder.Append("          .celloption= ").Append(this.IsIndentNotParentCellOptions).Append("\n");
			stringBuilder.Append("    .borderoptns     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BorderOptions)).Append("\n");
			stringBuilder.Append("          .lftln     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BorderLeft)).Append("\n");
			stringBuilder.Append("          .rgtln     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BorderRight)).Append("\n");
			stringBuilder.Append("          .topln     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BorderTop)).Append("\n");
			stringBuilder.Append("          .btmln     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BorderBottom)).Append("\n");
			stringBuilder.Append("    .paleteoptns     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.PaletteOptions)).Append("\n");
			stringBuilder.Append("          .leftborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LeftBorderPaletteIdx)).Append("\n");
			stringBuilder.Append("          .rghtborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RightBorderPaletteIdx)).Append("\n");
			stringBuilder.Append("          .diag      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Diagonal)).Append("\n");
			stringBuilder.Append("    .paleteoptn2     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.AdtlPaletteOptions)).Append("\n");
			stringBuilder.Append("          .topborder = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.TopBorderPaletteIdx)).Append("\n");
			stringBuilder.Append("          .botmborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BottomBorderPaletteIdx)).Append("\n");
			stringBuilder.Append("          .adtldiag  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.AdtlDiagBorderPaletteIdx)).Append("\n");
			stringBuilder.Append("          .diaglnstyl= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.AdtlDiagLineStyle)).Append("\n");
			stringBuilder.Append("          .Fillpattrn= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.AdtlFillPattern)).Append("\n");
			stringBuilder.Append("    .Fillpaloptn     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FillPaletteOptions)).Append("\n");
			stringBuilder.Append("          .foreground= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FillForeground)).Append("\n");
			stringBuilder.Append("          .background= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FillBackground)).Append("\n");
			stringBuilder.Append("[/EXTENDEDFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00069AE4 File Offset: 0x00067CE4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.FontIndex);
			out1.WriteShort((int)this.FormatIndex);
			out1.WriteShort((int)this.CellOptions);
			out1.WriteShort((int)this.AlignmentOptions);
			out1.WriteShort((int)this.IndentionOptions);
			out1.WriteShort((int)this.BorderOptions);
			out1.WriteShort((int)this.PaletteOptions);
			out1.WriteInt(this.AdtlPaletteOptions);
			out1.WriteShort((int)this.FillPaletteOptions);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00069B5D File Offset: 0x00067D5D
		public override short Sid
		{
			get
			{
				return 224;
			}
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00069B64 File Offset: 0x00067D64
		public override int GetHashCode()
		{
			int num = 31;
			int num2 = 1;
			num2 = num * num2 + (int)this.field_1_font_index;
			num2 = num * num2 + (int)this.field_2_format_index;
			num2 = num * num2 + (int)this.field_3_cell_options;
			num2 = num * num2 + (int)this.field_4_alignment_options;
			num2 = num * num2 + (int)this.field_5_indention_options;
			num2 = num * num2 + (int)this.field_6_border_options;
			num2 = num * num2 + (int)this.field_7_palette_options;
			num2 = num * num2 + this.field_8_adtl_palette_options;
			return num * num2 + (int)this.field_9_fill_palette_options;
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00069BD8 File Offset: 0x00067DD8
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj is global::NPOI.HSSF.Record.ExtendedFormatRecord)
			{
				global::NPOI.HSSF.Record.ExtendedFormatRecord extendedFormatRecord = (global::NPOI.HSSF.Record.ExtendedFormatRecord)obj;
				return this.field_1_font_index == extendedFormatRecord.field_1_font_index && this.field_2_format_index == extendedFormatRecord.field_2_format_index && this.field_3_cell_options == extendedFormatRecord.field_3_cell_options && this.field_4_alignment_options == extendedFormatRecord.field_4_alignment_options && this.field_5_indention_options == extendedFormatRecord.field_5_indention_options && this.field_6_border_options == extendedFormatRecord.field_6_border_options && this.field_7_palette_options == extendedFormatRecord.field_7_palette_options && this.field_8_adtl_palette_options == extendedFormatRecord.field_8_adtl_palette_options && this.field_9_fill_palette_options == extendedFormatRecord.field_9_fill_palette_options;
			}
			return false;
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00069C98 File Offset: 0x00067E98
		public int[] StateSummary
		{
			get
			{
				return new int[]
				{
					(int)this.field_1_font_index,
					(int)this.field_2_format_index,
					(int)this.field_3_cell_options,
					(int)this.field_4_alignment_options,
					(int)this.field_5_indention_options,
					(int)this.field_6_border_options,
					(int)this.field_7_palette_options,
					this.field_8_adtl_palette_options,
					(int)this.field_9_fill_palette_options
				};
			}
		}

		// Token: 0x04000E5E RID: 3678
		public const short sid = 224;

		// Token: 0x04000E5F RID: 3679
		public const short NULL = -16;

		// Token: 0x04000E60 RID: 3680
		public const short XF_STYLE = 1;

		// Token: 0x04000E61 RID: 3681
		public const short XF_CELL = 0;

		// Token: 0x04000E62 RID: 3682
		public const short NONE = 0;

		// Token: 0x04000E63 RID: 3683
		public const short THIN = 1;

		// Token: 0x04000E64 RID: 3684
		public const short MEDIUM = 2;

		// Token: 0x04000E65 RID: 3685
		public const short DASHED = 3;

		// Token: 0x04000E66 RID: 3686
		public const short DOTTED = 4;

		// Token: 0x04000E67 RID: 3687
		public const short THICK = 5;

		// Token: 0x04000E68 RID: 3688
		public const short DOUBLE = 6;

		// Token: 0x04000E69 RID: 3689
		public const short HAIR = 7;

		// Token: 0x04000E6A RID: 3690
		public const short MEDIUM_DASHED = 8;

		// Token: 0x04000E6B RID: 3691
		public const short DASH_DOT = 9;

		// Token: 0x04000E6C RID: 3692
		public const short MEDIUM_DASH_DOT = 10;

		// Token: 0x04000E6D RID: 3693
		public const short DASH_DOT_DOT = 11;

		// Token: 0x04000E6E RID: 3694
		public const short MEDIUM_DASH_DOT_DOT = 12;

		// Token: 0x04000E6F RID: 3695
		public const short SLANTED_DASH_DOT = 13;

		// Token: 0x04000E70 RID: 3696
		public const short GENERAL = 0;

		// Token: 0x04000E71 RID: 3697
		public const short LEFT = 1;

		// Token: 0x04000E72 RID: 3698
		public const short CENTER = 2;

		// Token: 0x04000E73 RID: 3699
		public const short RIGHT = 3;

		// Token: 0x04000E74 RID: 3700
		public const short FILL = 4;

		// Token: 0x04000E75 RID: 3701
		public const short JUSTIFY = 5;

		// Token: 0x04000E76 RID: 3702
		public const short CENTER_SELECTION = 6;

		// Token: 0x04000E77 RID: 3703
		public const short VERTICAL_TOP = 0;

		// Token: 0x04000E78 RID: 3704
		public const short VERTICAL_CENTER = 1;

		// Token: 0x04000E79 RID: 3705
		public const short VERTICAL_BOTTOM = 2;

		// Token: 0x04000E7A RID: 3706
		public const short VERTICAL_JUSTIFY = 3;

		// Token: 0x04000E7B RID: 3707
		public const short NO_FILL = 0;

		// Token: 0x04000E7C RID: 3708
		public const short SOLID_FILL = 1;

		// Token: 0x04000E7D RID: 3709
		public const short FINE_DOTS = 2;

		// Token: 0x04000E7E RID: 3710
		public const short ALT_BARS = 3;

		// Token: 0x04000E7F RID: 3711
		public const short SPARSE_DOTS = 4;

		// Token: 0x04000E80 RID: 3712
		public const short THICK_HORZ_BANDS = 5;

		// Token: 0x04000E81 RID: 3713
		public const short THICK_VERT_BANDS = 6;

		// Token: 0x04000E82 RID: 3714
		public const short THICK_BACKWARD_DIAG = 7;

		// Token: 0x04000E83 RID: 3715
		public const short THICK_FORWARD_DIAG = 8;

		// Token: 0x04000E84 RID: 3716
		public const short BIG_SPOTS = 9;

		// Token: 0x04000E85 RID: 3717
		public const short BRICKS = 10;

		// Token: 0x04000E86 RID: 3718
		public const short THIN_HORZ_BANDS = 11;

		// Token: 0x04000E87 RID: 3719
		public const short THIN_VERT_BANDS = 12;

		// Token: 0x04000E88 RID: 3720
		public const short THIN_BACKWARD_DIAG = 13;

		// Token: 0x04000E89 RID: 3721
		public const short THIN_FORWARD_DIAG = 14;

		// Token: 0x04000E8A RID: 3722
		public const short SQUARES = 15;

		// Token: 0x04000E8B RID: 3723
		public const short DIAMONDS = 16;

		// Token: 0x04000E8C RID: 3724
		private short field_1_font_index;

		// Token: 0x04000E8D RID: 3725
		private short field_2_format_index;

		// Token: 0x04000E8E RID: 3726
		private static global::NPOI.Util.BitField _locked = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000E8F RID: 3727
		private static global::NPOI.Util.BitField _hidden = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000E90 RID: 3728
		private static global::NPOI.Util.BitField _xf_type = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04000E91 RID: 3729
		private static global::NPOI.Util.BitField _123_prefix = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000E92 RID: 3730
		private static global::NPOI.Util.BitField _parent_index = global::NPOI.Util.BitFieldFactory.GetInstance(65520);

		// Token: 0x04000E93 RID: 3731
		private short field_3_cell_options;

		// Token: 0x04000E94 RID: 3732
		private static global::NPOI.Util.BitField _alignment = global::NPOI.Util.BitFieldFactory.GetInstance(7);

		// Token: 0x04000E95 RID: 3733
		private static global::NPOI.Util.BitField _wrap_text = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000E96 RID: 3734
		private static global::NPOI.Util.BitField _vertical_alignment = global::NPOI.Util.BitFieldFactory.GetInstance(112);

		// Token: 0x04000E97 RID: 3735
		private static global::NPOI.Util.BitField _justify_last = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04000E98 RID: 3736
		private static global::NPOI.Util.BitField _rotation = global::NPOI.Util.BitFieldFactory.GetInstance(65280);

		// Token: 0x04000E99 RID: 3737
		private short field_4_alignment_options;

		// Token: 0x04000E9A RID: 3738
		private static global::NPOI.Util.BitField _indent = global::NPOI.Util.BitFieldFactory.GetInstance(15);

		// Token: 0x04000E9B RID: 3739
		private static global::NPOI.Util.BitField _shrink_to_fit = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04000E9C RID: 3740
		private static global::NPOI.Util.BitField _merge_cells = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000E9D RID: 3741
		private static global::NPOI.Util.BitField _Reading_order = global::NPOI.Util.BitFieldFactory.GetInstance(192);

		// Token: 0x04000E9E RID: 3742
		private static global::NPOI.Util.BitField _indent_not_parent_format = global::NPOI.Util.BitFieldFactory.GetInstance(1024);

		// Token: 0x04000E9F RID: 3743
		private static global::NPOI.Util.BitField _indent_not_parent_font = global::NPOI.Util.BitFieldFactory.GetInstance(2048);

		// Token: 0x04000EA0 RID: 3744
		private static global::NPOI.Util.BitField _indent_not_parent_alignment = global::NPOI.Util.BitFieldFactory.GetInstance(4096);

		// Token: 0x04000EA1 RID: 3745
		private static global::NPOI.Util.BitField _indent_not_parent_border = global::NPOI.Util.BitFieldFactory.GetInstance(8192);

		// Token: 0x04000EA2 RID: 3746
		private static global::NPOI.Util.BitField _indent_not_parent_pattern = global::NPOI.Util.BitFieldFactory.GetInstance(16384);

		// Token: 0x04000EA3 RID: 3747
		private static global::NPOI.Util.BitField _indent_not_parent_cell_options = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x04000EA4 RID: 3748
		private short field_5_indention_options;

		// Token: 0x04000EA5 RID: 3749
		private static global::NPOI.Util.BitField _border_left = global::NPOI.Util.BitFieldFactory.GetInstance(15);

		// Token: 0x04000EA6 RID: 3750
		private static global::NPOI.Util.BitField _border_right = global::NPOI.Util.BitFieldFactory.GetInstance(240);

		// Token: 0x04000EA7 RID: 3751
		private static global::NPOI.Util.BitField _border_top = global::NPOI.Util.BitFieldFactory.GetInstance(3840);

		// Token: 0x04000EA8 RID: 3752
		private static global::NPOI.Util.BitField _border_bottom = global::NPOI.Util.BitFieldFactory.GetInstance(61440);

		// Token: 0x04000EA9 RID: 3753
		private short field_6_border_options;

		// Token: 0x04000EAA RID: 3754
		private static global::NPOI.Util.BitField _left_border_palette_idx = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04000EAB RID: 3755
		private static global::NPOI.Util.BitField _right_border_palette_idx = global::NPOI.Util.BitFieldFactory.GetInstance(16256);

		// Token: 0x04000EAC RID: 3756
		private static global::NPOI.Util.BitField _diag = global::NPOI.Util.BitFieldFactory.GetInstance(49152);

		// Token: 0x04000EAD RID: 3757
		private short field_7_palette_options;

		// Token: 0x04000EAE RID: 3758
		private static global::NPOI.Util.BitField _top_border_palette_idx = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04000EAF RID: 3759
		private static global::NPOI.Util.BitField _bottom_border_palette_idx = global::NPOI.Util.BitFieldFactory.GetInstance(16256);

		// Token: 0x04000EB0 RID: 3760
		private static global::NPOI.Util.BitField _adtl_diag_border_palette_idx = global::NPOI.Util.BitFieldFactory.GetInstance(2080768);

		// Token: 0x04000EB1 RID: 3761
		private static global::NPOI.Util.BitField _adtl_diag_line_style = global::NPOI.Util.BitFieldFactory.GetInstance(31457280);

		// Token: 0x04000EB2 RID: 3762
		private static global::NPOI.Util.BitField _adtl_fill_pattern = global::NPOI.Util.BitFieldFactory.GetInstance(-67108864);

		// Token: 0x04000EB3 RID: 3763
		private int field_8_adtl_palette_options;

		// Token: 0x04000EB4 RID: 3764
		private static global::NPOI.Util.BitField _fill_foreground = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04000EB5 RID: 3765
		private static global::NPOI.Util.BitField _fill_background = global::NPOI.Util.BitFieldFactory.GetInstance(16256);

		// Token: 0x04000EB6 RID: 3766
		private short field_9_fill_palette_options;
	}
}
