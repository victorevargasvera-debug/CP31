using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CC RID: 1484
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomChartsheetViews
	{
		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x0009E69D File Offset: 0x0009C89D
		// (set) Token: 0x06004173 RID: 16755 RVA: 0x0009E6A5 File Offset: 0x0009C8A5
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView> customSheetView
		{
			get
			{
				return this.customSheetViewField;
			}
			set
			{
				this.customSheetViewField = value;
			}
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews ct_CustomChartsheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetViews();
			ct_CustomChartsheetViews.customSheetView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customSheetView")
				{
					ct_CustomChartsheetViews.customSheetView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CustomChartsheetViews;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x0009E740 File Offset: 0x0009C940
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.customSheetView != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView ct_CustomChartsheetView in this.customSheetView)
				{
					ct_CustomChartsheetView.Write(sw, "customSheetView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002949 RID: 10569
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView> customSheetViewField;
	}
}
