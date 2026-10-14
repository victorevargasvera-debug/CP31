using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C6 RID: 1478
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Macrosheet
	{
		// Token: 0x06004124 RID: 16676 RVA: 0x0009DEB0 File Offset: 0x0009C0B0
		public CT_Macrosheet()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.oleObjectsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject>();
			this.pictureField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture();
			this.legacyDrawingHFField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing();
			this.legacyDrawingField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing();
			this.drawingField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing();
			this.customPropertiesField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty>();
			this.colBreaksField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak();
			this.rowBreaksField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak();
			this.headerFooterField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter();
			this.pageSetupField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup();
			this.pageMarginsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins();
			this.printOptionsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions();
			this.conditionalFormattingField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting>();
			this.phoneticPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr();
			this.customSheetViewsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView>();
			this.dataConsolidateField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate();
			this.sortStateField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState();
			this.autoFilterField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter();
			this.sheetProtectionField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection();
			this.sheetDataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row>();
			this.colsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
			this.sheetFormatPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr();
			this.sheetViewsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews();
			this.dimensionField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension();
			this.sheetPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x0009DFE1 File Offset: 0x0009C1E1
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x0009DFE9 File Offset: 0x0009C1E9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPr
		{
			get
			{
				return this.sheetPrField;
			}
			set
			{
				this.sheetPrField = value;
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x0009DFF2 File Offset: 0x0009C1F2
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x0009DFFA File Offset: 0x0009C1FA
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension dimension
		{
			get
			{
				return this.dimensionField;
			}
			set
			{
				this.dimensionField = value;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x0009E003 File Offset: 0x0009C203
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x0009E00B File Offset: 0x0009C20B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetViews
		{
			get
			{
				return this.sheetViewsField;
			}
			set
			{
				this.sheetViewsField = value;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x0009E014 File Offset: 0x0009C214
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x0009E01C File Offset: 0x0009C21C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPr
		{
			get
			{
				return this.sheetFormatPrField;
			}
			set
			{
				this.sheetFormatPrField = value;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x0009E025 File Offset: 0x0009C225
		// (set) Token: 0x0600412E RID: 16686 RVA: 0x0009E02D File Offset: 0x0009C22D
		[global::System.Xml.Serialization.XmlArray(Order = 4)]
		[global::System.Xml.Serialization.XmlArrayItem("col", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col), IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> cols
		{
			get
			{
				return this.colsField;
			}
			set
			{
				this.colsField = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x0009E036 File Offset: 0x0009C236
		// (set) Token: 0x06004130 RID: 16688 RVA: 0x0009E03E File Offset: 0x0009C23E
		[global::System.Xml.Serialization.XmlArray(Order = 5)]
		[global::System.Xml.Serialization.XmlArrayItem("row", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> sheetData
		{
			get
			{
				return this.sheetDataField;
			}
			set
			{
				this.sheetDataField = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x0009E047 File Offset: 0x0009C247
		// (set) Token: 0x06004132 RID: 16690 RVA: 0x0009E04F File Offset: 0x0009C24F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection sheetProtection
		{
			get
			{
				return this.sheetProtectionField;
			}
			set
			{
				this.sheetProtectionField = value;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x0009E058 File Offset: 0x0009C258
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x0009E060 File Offset: 0x0009C260
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilter
		{
			get
			{
				return this.autoFilterField;
			}
			set
			{
				this.autoFilterField = value;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x0009E069 File Offset: 0x0009C269
		// (set) Token: 0x06004136 RID: 16694 RVA: 0x0009E071 File Offset: 0x0009C271
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortState
		{
			get
			{
				return this.sortStateField;
			}
			set
			{
				this.sortStateField = value;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x0009E07A File Offset: 0x0009C27A
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x0009E082 File Offset: 0x0009C282
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate dataConsolidate
		{
			get
			{
				return this.dataConsolidateField;
			}
			set
			{
				this.dataConsolidateField = value;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x0009E08B File Offset: 0x0009C28B
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x0009E093 File Offset: 0x0009C293
		[global::System.Xml.Serialization.XmlArray(Order = 10)]
		[global::System.Xml.Serialization.XmlArrayItem("customSheetView", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView> customSheetViews
		{
			get
			{
				return this.customSheetViewsField;
			}
			set
			{
				this.customSheetViewsField = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0009E09C File Offset: 0x0009C29C
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x0009E0A4 File Offset: 0x0009C2A4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPr
		{
			get
			{
				return this.phoneticPrField;
			}
			set
			{
				this.phoneticPrField = value;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x0009E0AD File Offset: 0x0009C2AD
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x0009E0B5 File Offset: 0x0009C2B5
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting> conditionalFormatting
		{
			get
			{
				return this.conditionalFormattingField;
			}
			set
			{
				this.conditionalFormattingField = value;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x0009E0BE File Offset: 0x0009C2BE
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x0009E0C6 File Offset: 0x0009C2C6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions
		{
			get
			{
				return this.printOptionsField;
			}
			set
			{
				this.printOptionsField = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x0009E0CF File Offset: 0x0009C2CF
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x0009E0D7 File Offset: 0x0009C2D7
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMargins
		{
			get
			{
				return this.pageMarginsField;
			}
			set
			{
				this.pageMarginsField = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x0009E0E0 File Offset: 0x0009C2E0
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x0009E0E8 File Offset: 0x0009C2E8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetup
		{
			get
			{
				return this.pageSetupField;
			}
			set
			{
				this.pageSetupField = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x0009E0F1 File Offset: 0x0009C2F1
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x0009E0F9 File Offset: 0x0009C2F9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter
		{
			get
			{
				return this.headerFooterField;
			}
			set
			{
				this.headerFooterField = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x0009E102 File Offset: 0x0009C302
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x0009E10A File Offset: 0x0009C30A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaks
		{
			get
			{
				return this.rowBreaksField;
			}
			set
			{
				this.rowBreaksField = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x0009E113 File Offset: 0x0009C313
		// (set) Token: 0x0600414A RID: 16714 RVA: 0x0009E11B File Offset: 0x0009C31B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaks
		{
			get
			{
				return this.colBreaksField;
			}
			set
			{
				this.colBreaksField = value;
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x0009E124 File Offset: 0x0009C324
		// (set) Token: 0x0600414C RID: 16716 RVA: 0x0009E12C File Offset: 0x0009C32C
		[global::System.Xml.Serialization.XmlArray(Order = 19)]
		[global::System.Xml.Serialization.XmlArrayItem("customPr", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty> customProperties
		{
			get
			{
				return this.customPropertiesField;
			}
			set
			{
				this.customPropertiesField = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x0009E135 File Offset: 0x0009C335
		// (set) Token: 0x0600414E RID: 16718 RVA: 0x0009E13D File Offset: 0x0009C33D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawing
		{
			get
			{
				return this.drawingField;
			}
			set
			{
				this.drawingField = value;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x0009E146 File Offset: 0x0009C346
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x0009E14E File Offset: 0x0009C34E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawing
		{
			get
			{
				return this.legacyDrawingField;
			}
			set
			{
				this.legacyDrawingField = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x0009E157 File Offset: 0x0009C357
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x0009E15F File Offset: 0x0009C35F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHF
		{
			get
			{
				return this.legacyDrawingHFField;
			}
			set
			{
				this.legacyDrawingHFField = value;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x0009E168 File Offset: 0x0009C368
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x0009E170 File Offset: 0x0009C370
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture picture
		{
			get
			{
				return this.pictureField;
			}
			set
			{
				this.pictureField = value;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x0009E179 File Offset: 0x0009C379
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x0009E181 File Offset: 0x0009C381
		[global::System.Xml.Serialization.XmlArray(Order = 24)]
		[global::System.Xml.Serialization.XmlArrayItem("oleObject", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject> oleObjects
		{
			get
			{
				return this.oleObjectsField;
			}
			set
			{
				this.oleObjectsField = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x0009E18A File Offset: 0x0009C38A
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x0009E192 File Offset: 0x0009C392
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x0400292A RID: 10538
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPrField;

		// Token: 0x0400292B RID: 10539
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension dimensionField;

		// Token: 0x0400292C RID: 10540
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetViewsField;

		// Token: 0x0400292D RID: 10541
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPrField;

		// Token: 0x0400292E RID: 10542
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> colsField;

		// Token: 0x0400292F RID: 10543
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> sheetDataField;

		// Token: 0x04002930 RID: 10544
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection sheetProtectionField;

		// Token: 0x04002931 RID: 10545
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilterField;

		// Token: 0x04002932 RID: 10546
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortStateField;

		// Token: 0x04002933 RID: 10547
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate dataConsolidateField;

		// Token: 0x04002934 RID: 10548
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView> customSheetViewsField;

		// Token: 0x04002935 RID: 10549
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPrField;

		// Token: 0x04002936 RID: 10550
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting> conditionalFormattingField;

		// Token: 0x04002937 RID: 10551
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptionsField;

		// Token: 0x04002938 RID: 10552
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x04002939 RID: 10553
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetupField;

		// Token: 0x0400293A RID: 10554
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x0400293B RID: 10555
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaksField;

		// Token: 0x0400293C RID: 10556
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaksField;

		// Token: 0x0400293D RID: 10557
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty> customPropertiesField;

		// Token: 0x0400293E RID: 10558
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawingField;

		// Token: 0x0400293F RID: 10559
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingField;

		// Token: 0x04002940 RID: 10560
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHFField;

		// Token: 0x04002941 RID: 10561
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture pictureField;

		// Token: 0x04002942 RID: 10562
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject> oleObjectsField;

		// Token: 0x04002943 RID: 10563
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
