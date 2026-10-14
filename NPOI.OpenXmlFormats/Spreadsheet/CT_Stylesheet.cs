using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060E RID: 1550
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(ElementName = "styleSheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Stylesheet
	{
		// Token: 0x060043C0 RID: 17344 RVA: 0x000A137C File Offset: 0x0009F57C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet ct_Stylesheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "numFmts")
				{
					ct_Stylesheet.numFmts = global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fonts")
				{
					ct_Stylesheet.fonts = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fills")
				{
					ct_Stylesheet.fills = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "borders")
				{
					ct_Stylesheet.borders = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellStyleXfs")
				{
					ct_Stylesheet.cellStyleXfs = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellXfs")
				{
					ct_Stylesheet.cellXfs = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellStyles")
				{
					ct_Stylesheet.cellStyles = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dxfs")
				{
					ct_Stylesheet.dxfs = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tableStyles")
				{
					ct_Stylesheet.tableStyles = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colors")
				{
					ct_Stylesheet.colors = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Stylesheet.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Stylesheet;
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x000A156C File Offset: 0x0009F76C
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<styleSheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\"");
			sw.Write(" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"x14ac x16r2 xr\" xmlns:x14ac=\"http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac\" xmlns:x16r2=\"http://schemas.microsoft.com/office/spreadsheetml/2015/02/main\" xmlns:xr=\"http://schemas.microsoft.com/office/spreadsheetml/2014/revision\"");
			sw.Write(">");
			if (this.numFmts != null)
			{
				this.numFmts.Write(sw, "numFmts");
			}
			if (this.fonts != null)
			{
				this.fonts.Write(sw, "fonts");
			}
			if (this.fills != null)
			{
				this.fills.Write(sw, "fills");
			}
			if (this.borders != null)
			{
				this.borders.Write(sw, "borders");
			}
			if (this.cellStyleXfs != null)
			{
				this.cellStyleXfs.Write(sw, "cellStyleXfs");
			}
			if (this.cellXfs != null)
			{
				this.cellXfs.Write(sw, "cellXfs");
			}
			if (this.cellStyles != null)
			{
				this.cellStyles.Write(sw, "cellStyles");
			}
			if (this.dxfs != null)
			{
				this.dxfs.Write(sw, "dxfs");
			}
			if (this.tableStyles != null)
			{
				this.tableStyles.Write(sw, "tableStyles");
			}
			if (this.colors != null)
			{
				this.colors.Write(sw, "colors");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write("</styleSheet>");
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x000A16C3 File Offset: 0x0009F8C3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders AddNewBorders()
		{
			this.bordersField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders();
			return this.bordersField;
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x000A16D6 File Offset: 0x0009F8D6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs AddNewCellStyleXfs()
		{
			this.cellStyleXfsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs();
			return this.cellStyleXfsField;
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x000A16E9 File Offset: 0x0009F8E9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs AddNewCellXfs()
		{
			this.cellXfsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs();
			return this.cellXfsField;
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x000A16FC File Offset: 0x0009F8FC
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x000A1704 File Offset: 0x0009F904
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts numFmts
		{
			get
			{
				return this.numFmtsField;
			}
			set
			{
				this.numFmtsField = value;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x000A170D File Offset: 0x0009F90D
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x000A1715 File Offset: 0x0009F915
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts fonts
		{
			get
			{
				return this.fontsField;
			}
			set
			{
				this.fontsField = value;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x000A171E File Offset: 0x0009F91E
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x000A1726 File Offset: 0x0009F926
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills fills
		{
			get
			{
				return this.fillsField;
			}
			set
			{
				this.fillsField = value;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x000A172F File Offset: 0x0009F92F
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x000A1737 File Offset: 0x0009F937
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders borders
		{
			get
			{
				return this.bordersField;
			}
			set
			{
				this.bordersField = value;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x000A1740 File Offset: 0x0009F940
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x000A1748 File Offset: 0x0009F948
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs cellStyleXfs
		{
			get
			{
				return this.cellStyleXfsField;
			}
			set
			{
				this.cellStyleXfsField = value;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x000A1751 File Offset: 0x0009F951
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x000A1759 File Offset: 0x0009F959
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs cellXfs
		{
			get
			{
				return this.cellXfsField;
			}
			set
			{
				this.cellXfsField = value;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x000A1762 File Offset: 0x0009F962
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x000A176A File Offset: 0x0009F96A
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles cellStyles
		{
			get
			{
				return this.cellStylesField;
			}
			set
			{
				this.cellStylesField = value;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x000A1773 File Offset: 0x0009F973
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x000A177B File Offset: 0x0009F97B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs dxfs
		{
			get
			{
				return this.dxfsField;
			}
			set
			{
				this.dxfsField = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x000A1784 File Offset: 0x0009F984
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x000A178C File Offset: 0x0009F98C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles tableStyles
		{
			get
			{
				return this.tableStylesField;
			}
			set
			{
				this.tableStylesField = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x000A1795 File Offset: 0x0009F995
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x000A179D File Offset: 0x0009F99D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors colors
		{
			get
			{
				return this.colorsField;
			}
			set
			{
				this.colorsField = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x000A17A6 File Offset: 0x0009F9A6
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x000A17AE File Offset: 0x0009F9AE
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

		// Token: 0x04002A9E RID: 10910
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts numFmtsField;

		// Token: 0x04002A9F RID: 10911
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts fontsField;

		// Token: 0x04002AA0 RID: 10912
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills fillsField;

		// Token: 0x04002AA1 RID: 10913
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders bordersField;

		// Token: 0x04002AA2 RID: 10914
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs cellStyleXfsField;

		// Token: 0x04002AA3 RID: 10915
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs cellXfsField;

		// Token: 0x04002AA4 RID: 10916
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles cellStylesField;

		// Token: 0x04002AA5 RID: 10917
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs dxfsField;

		// Token: 0x04002AA6 RID: 10918
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles tableStylesField;

		// Token: 0x04002AA7 RID: 10919
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors colorsField;

		// Token: 0x04002AA8 RID: 10920
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
