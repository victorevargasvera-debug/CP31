using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200051E RID: 1310
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_BookViews
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x0008ED70 File Offset: 0x0008CF70
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews ct_BookViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews();
			ct_BookViews.workbookView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "workbookView")
				{
					ct_BookViews.workbookView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BookViews;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0008EE00 File Offset: 0x0008D000
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.workbookView != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView ct_BookView in this.workbookView)
				{
					ct_BookView.Write(sw, "workbookView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x0008EE8C File Offset: 0x0008D08C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView AddNewWorkbookView()
		{
			if (this.workbookViewField == null)
			{
				this.workbookViewField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView ct_BookView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView();
			this.workbookViewField.Add(ct_BookView);
			return ct_BookView;
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x0008EEBF File Offset: 0x0008D0BF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView GetWorkbookViewArray(int index)
		{
			if (this.workbookViewField == null)
			{
				return null;
			}
			return this.workbookViewField[index];
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x0008EED7 File Offset: 0x0008D0D7
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0008EEDF File Offset: 0x0008D0DF
		[global::System.Xml.Serialization.XmlElement("workbookView")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView> workbookView
		{
			get
			{
				return this.workbookViewField;
			}
			set
			{
				this.workbookViewField = value;
			}
		}

		// Token: 0x040024D3 RID: 9427
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView> workbookViewField;
	}
}
