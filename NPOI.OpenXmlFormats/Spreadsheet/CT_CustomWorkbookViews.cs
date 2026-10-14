using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000520 RID: 1312
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomWorkbookViews
	{
		// Token: 0x060039BE RID: 14782 RVA: 0x0008F6B4 File Offset: 0x0008D8B4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews ct_CustomWorkbookViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews();
			ct_CustomWorkbookViews.customWorkbookView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customWorkbookView")
				{
					ct_CustomWorkbookViews.customWorkbookView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CustomWorkbookViews;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0008F744 File Offset: 0x0008D944
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.customWorkbookView != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView ct_CustomWorkbookView in this.customWorkbookView)
				{
					ct_CustomWorkbookView.Write(sw, "customWorkbookView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
		// (set) Token: 0x060039C2 RID: 14786 RVA: 0x0008F7D8 File Offset: 0x0008D9D8
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView> customWorkbookView
		{
			get
			{
				return this.customWorkbookViewField;
			}
			set
			{
				this.customWorkbookViewField = value;
			}
		}

		// Token: 0x040024EE RID: 9454
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView> customWorkbookViewField;
	}
}
