using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C8 RID: 1480
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomSheetViews
	{
		// Token: 0x0600415C RID: 16732 RVA: 0x0009E1C0 File Offset: 0x0009C3C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews ct_CustomSheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews();
			ct_CustomSheetViews.customSheetView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customSheetView")
				{
					ct_CustomSheetViews.customSheetView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CustomSheetViews;
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x0009E250 File Offset: 0x0009C450
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.customSheetView != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView ct_CustomSheetView in this.customSheetView)
				{
					ct_CustomSheetView.Write(sw, "customSheetView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x0009E2DC File Offset: 0x0009C4DC
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x0009E2E4 File Offset: 0x0009C4E4
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView> customSheetView
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

		// Token: 0x04002945 RID: 10565
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView> customSheetViewField;
	}
}
