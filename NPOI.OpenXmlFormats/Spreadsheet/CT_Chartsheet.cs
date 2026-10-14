using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BC RID: 1468
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("chartsheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Chartsheet
	{
		// Token: 0x06004091 RID: 16529 RVA: 0x0009C990 File Offset: 0x0009AB90
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet ct_Chartsheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sheetPr")
				{
					ct_Chartsheet.sheetPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetViews")
				{
					ct_Chartsheet.sheetViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetProtection")
				{
					ct_Chartsheet.sheetProtection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "customSheetViews")
				{
					ct_Chartsheet.customSheetViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageMargins")
				{
					ct_Chartsheet.pageMargins = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetup")
				{
					ct_Chartsheet.pageSetup = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headerFooter")
				{
					ct_Chartsheet.headerFooter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawing")
				{
					ct_Chartsheet.drawing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacyDrawing")
				{
					ct_Chartsheet.legacyDrawing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacyDrawingHF")
				{
					ct_Chartsheet.legacyDrawingHF = global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "picture")
				{
					ct_Chartsheet.picture = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webPublishItems")
				{
					ct_Chartsheet.webPublishItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Chartsheet.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Chartsheet;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
		internal void Write(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
				streamWriter.Write("<chartsheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\"");
				streamWriter.Write(" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"");
				streamWriter.Write(">");
				if (this.sheetPr != null)
				{
					this.sheetPr.Write(streamWriter, "sheetPr");
				}
				if (this.sheetViews != null)
				{
					this.sheetViews.Write(streamWriter, "sheetViews");
				}
				if (this.sheetProtection != null)
				{
					this.sheetProtection.Write(streamWriter, "sheetProtection");
				}
				if (this.customSheetViews != null)
				{
					this.customSheetViews.Write(streamWriter, "customSheetViews");
				}
				if (this.pageMargins != null)
				{
					this.pageMargins.Write(streamWriter, "pageMargins");
				}
				if (this.pageSetup != null)
				{
					this.pageSetup.Write(streamWriter, "pageSetup");
				}
				if (this.headerFooter != null)
				{
					this.headerFooter.Write(streamWriter, "headerFooter");
				}
				if (this.drawing != null)
				{
					this.drawing.Write(streamWriter, "drawing");
				}
				if (this.legacyDrawing != null)
				{
					this.legacyDrawing.Write(streamWriter, "legacyDrawing");
				}
				if (this.legacyDrawingHF != null)
				{
					this.legacyDrawingHF.Write(streamWriter, "legacyDrawingHF");
				}
				if (this.picture != null)
				{
					this.picture.Write(streamWriter, "picture");
				}
				if (this.webPublishItems != null)
				{
					this.webPublishItems.Write(streamWriter, "webPublishItems");
				}
				if (this.extLst != null)
				{
					this.extLst.Write(streamWriter, "extLst");
				}
				streamWriter.Write("</chartsheet>");
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06004093 RID: 16531 RVA: 0x0009CD80 File Offset: 0x0009AF80
		// (set) Token: 0x06004094 RID: 16532 RVA: 0x0009CD88 File Offset: 0x0009AF88
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr sheetPr
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

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x0009CD91 File Offset: 0x0009AF91
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x0009CD99 File Offset: 0x0009AF99
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews sheetViews
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

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x0009CDA2 File Offset: 0x0009AFA2
		// (set) Token: 0x06004098 RID: 16536 RVA: 0x0009CDAA File Offset: 0x0009AFAA
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection sheetProtection
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

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x0009CDB3 File Offset: 0x0009AFB3
		// (set) Token: 0x0600409A RID: 16538 RVA: 0x0009CDBB File Offset: 0x0009AFBB
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews customSheetViews
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

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x0009CDC4 File Offset: 0x0009AFC4
		// (set) Token: 0x0600409C RID: 16540 RVA: 0x0009CDCC File Offset: 0x0009AFCC
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x0009CDD5 File Offset: 0x0009AFD5
		// (set) Token: 0x0600409E RID: 16542 RVA: 0x0009CDDD File Offset: 0x0009AFDD
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup pageSetup
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

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x0009CDE6 File Offset: 0x0009AFE6
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x0009CDEE File Offset: 0x0009AFEE
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x0009CDF7 File Offset: 0x0009AFF7
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x0009CDFF File Offset: 0x0009AFFF
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x0009CE08 File Offset: 0x0009B008
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x0009CE10 File Offset: 0x0009B010
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x0009CE19 File Offset: 0x0009B019
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x0009CE21 File Offset: 0x0009B021
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x0009CE2A File Offset: 0x0009B02A
		// (set) Token: 0x060040A8 RID: 16552 RVA: 0x0009CE32 File Offset: 0x0009B032
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x0009CE3B File Offset: 0x0009B03B
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x0009CE43 File Offset: 0x0009B043
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems webPublishItems
		{
			get
			{
				return this.webPublishItemsField;
			}
			set
			{
				this.webPublishItemsField = value;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x0009CE4C File Offset: 0x0009B04C
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x0009CE54 File Offset: 0x0009B054
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x040028EE RID: 10478
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr sheetPrField;

		// Token: 0x040028EF RID: 10479
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews sheetViewsField;

		// Token: 0x040028F0 RID: 10480
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection sheetProtectionField;

		// Token: 0x040028F1 RID: 10481
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews customSheetViewsField;

		// Token: 0x040028F2 RID: 10482
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x040028F3 RID: 10483
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup pageSetupField;

		// Token: 0x040028F4 RID: 10484
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x040028F5 RID: 10485
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawingField;

		// Token: 0x040028F6 RID: 10486
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingField;

		// Token: 0x040028F7 RID: 10487
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHFField;

		// Token: 0x040028F8 RID: 10488
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture pictureField;

		// Token: 0x040028F9 RID: 10489
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems webPublishItemsField;

		// Token: 0x040028FA RID: 10490
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
