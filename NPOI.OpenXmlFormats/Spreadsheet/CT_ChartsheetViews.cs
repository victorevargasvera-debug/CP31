using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BE RID: 1470
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ChartsheetViews
	{
		// Token: 0x060040B7 RID: 16567 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews ct_ChartsheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetViews();
			ct_ChartsheetViews.sheetView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ChartsheetViews.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetView")
				{
					ct_ChartsheetViews.sheetView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ChartsheetViews;
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0009D094 File Offset: 0x0009B294
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.sheetView != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView ct_ChartsheetView in this.sheetView)
				{
					ct_ChartsheetView.Write(sw, "sheetView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x0009D138 File Offset: 0x0009B338
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x0009D140 File Offset: 0x0009B340
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView> sheetView
		{
			get
			{
				return this.sheetViewField;
			}
			set
			{
				this.sheetViewField = value;
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x0009D149 File Offset: 0x0009B349
		// (set) Token: 0x060040BC RID: 16572 RVA: 0x0009D151 File Offset: 0x0009B351
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

		// Token: 0x040028FE RID: 10494
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView> sheetViewField;

		// Token: 0x040028FF RID: 10495
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
