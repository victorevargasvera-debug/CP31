using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000578 RID: 1400
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetViews
	{
		// Token: 0x06003CE6 RID: 15590 RVA: 0x00093F28 File Offset: 0x00092128
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews ct_SheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews();
			ct_SheetViews.sheetView = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_SheetViews.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetView")
				{
					ct_SheetViews.sheetView.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SheetViews;
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00093FD8 File Offset: 0x000921D8
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
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView ct_SheetView in this.sheetView)
				{
					ct_SheetView.Write(sw, "sheetView");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x0009407C File Offset: 0x0009227C
		public CT_SheetViews()
		{
			this.sheetViewField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView>();
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00094090 File Offset: 0x00092290
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView AddNewSheetView()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView ct_SheetView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView();
			this.sheetViewField.Add(ct_SheetView);
			return ct_SheetView;
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x000940B0 File Offset: 0x000922B0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView GetSheetViewArray(int index)
		{
			return this.sheetViewField[index];
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x000940BE File Offset: 0x000922BE
		public void SetSheetViewArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView array)
		{
			this.sheetViewField[index] = array;
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x000940CD File Offset: 0x000922CD
		public int sizeOfSheetViewArray()
		{
			return this.sheetViewField.Count;
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x000940DA File Offset: 0x000922DA
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x000940E2 File Offset: 0x000922E2
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView> sheetView
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

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x000940EB File Offset: 0x000922EB
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x000940F3 File Offset: 0x000922F3
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

		// Token: 0x040026EE RID: 9966
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView> sheetViewField;

		// Token: 0x040026EF RID: 9967
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
