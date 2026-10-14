using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C5 RID: 1477
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Dialogsheet
	{
		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x0009DDC0 File Offset: 0x0009BFC0
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x0009DDC8 File Offset: 0x0009BFC8
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

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x0009DDD1 File Offset: 0x0009BFD1
		// (set) Token: 0x0600410A RID: 16650 RVA: 0x0009DDD9 File Offset: 0x0009BFD9
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

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x0009DDE2 File Offset: 0x0009BFE2
		// (set) Token: 0x0600410C RID: 16652 RVA: 0x0009DDEA File Offset: 0x0009BFEA
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

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x0009DDF3 File Offset: 0x0009BFF3
		// (set) Token: 0x0600410E RID: 16654 RVA: 0x0009DDFB File Offset: 0x0009BFFB
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

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600410F RID: 16655 RVA: 0x0009DE04 File Offset: 0x0009C004
		// (set) Token: 0x06004110 RID: 16656 RVA: 0x0009DE0C File Offset: 0x0009C00C
		[global::System.Xml.Serialization.XmlArray(Order = 4)]
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

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x0009DE15 File Offset: 0x0009C015
		// (set) Token: 0x06004112 RID: 16658 RVA: 0x0009DE1D File Offset: 0x0009C01D
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

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x0009DE26 File Offset: 0x0009C026
		// (set) Token: 0x06004114 RID: 16660 RVA: 0x0009DE2E File Offset: 0x0009C02E
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

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0009DE37 File Offset: 0x0009C037
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x0009DE3F File Offset: 0x0009C03F
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

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0009DE48 File Offset: 0x0009C048
		// (set) Token: 0x06004118 RID: 16664 RVA: 0x0009DE50 File Offset: 0x0009C050
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

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x0009DE59 File Offset: 0x0009C059
		// (set) Token: 0x0600411A RID: 16666 RVA: 0x0009DE61 File Offset: 0x0009C061
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

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x0009DE6A File Offset: 0x0009C06A
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x0009DE72 File Offset: 0x0009C072
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

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x0009DE7B File Offset: 0x0009C07B
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x0009DE83 File Offset: 0x0009C083
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

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x0009DE8C File Offset: 0x0009C08C
		// (set) Token: 0x06004120 RID: 16672 RVA: 0x0009DE94 File Offset: 0x0009C094
		[global::System.Xml.Serialization.XmlArray(Order = 12)]
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

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x0009DE9D File Offset: 0x0009C09D
		// (set) Token: 0x06004122 RID: 16674 RVA: 0x0009DEA5 File Offset: 0x0009C0A5
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

		// Token: 0x0400291C RID: 10524
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPrField;

		// Token: 0x0400291D RID: 10525
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetViewsField;

		// Token: 0x0400291E RID: 10526
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPrField;

		// Token: 0x0400291F RID: 10527
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection sheetProtectionField;

		// Token: 0x04002920 RID: 10528
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView> customSheetViewsField;

		// Token: 0x04002921 RID: 10529
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptionsField;

		// Token: 0x04002922 RID: 10530
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x04002923 RID: 10531
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetupField;

		// Token: 0x04002924 RID: 10532
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x04002925 RID: 10533
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawingField;

		// Token: 0x04002926 RID: 10534
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingField;

		// Token: 0x04002927 RID: 10535
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHFField;

		// Token: 0x04002928 RID: 10536
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject> oleObjectsField;

		// Token: 0x04002929 RID: 10537
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
