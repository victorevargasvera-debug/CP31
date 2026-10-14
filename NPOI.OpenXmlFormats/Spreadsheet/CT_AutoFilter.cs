using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200052E RID: 1326
	public class CT_AutoFilter
	{
		// Token: 0x06003A4E RID: 14926 RVA: 0x00090BA4 File Offset: 0x0008EDA4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter ct_AutoFilter = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter();
			ct_AutoFilter.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			ct_AutoFilter.filterColumn = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sortState")
				{
					ct_AutoFilter.sortState = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_AutoFilter.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "filterColumn")
				{
					ct_AutoFilter.filterColumn.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_AutoFilter;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00090C90 File Offset: 0x0008EE90
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write(">");
			if (this.filterColumn != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn ct_FilterColumn in this.filterColumn)
				{
					ct_FilterColumn.Write(sw, "filterColumn");
				}
			}
			if (this.sortState != null)
			{
				this.sortState.Write(sw, "sortState");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x00090D60 File Offset: 0x0008EF60
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x00090D68 File Offset: 0x0008EF68
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn> filterColumn
		{
			get
			{
				return this.filterColumnField;
			}
			set
			{
				this.filterColumnField = value;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x00090D71 File Offset: 0x0008EF71
		// (set) Token: 0x06003A53 RID: 14931 RVA: 0x00090D79 File Offset: 0x0008EF79
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00090D82 File Offset: 0x0008EF82
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x00090D8A File Offset: 0x0008EF8A
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

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00090D93 File Offset: 0x0008EF93
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x00090D9B File Offset: 0x0008EF9B
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x0400252B RID: 9515
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn> filterColumnField;

		// Token: 0x0400252C RID: 9516
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortStateField;

		// Token: 0x0400252D RID: 9517
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400252E RID: 9518
		private string refField;
	}
}
