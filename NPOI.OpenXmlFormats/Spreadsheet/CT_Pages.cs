using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000480 RID: 1152
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Pages
	{
		// Token: 0x06002E22 RID: 11810 RVA: 0x00073D64 File Offset: 0x00071F64
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages ct_Pages = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages();
			if (node.Attributes["count"] != null)
			{
				ct_Pages.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Pages.page = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "page")
				{
					ct_Pages.page.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Pages;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00073E20 File Offset: 0x00072020
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.page != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage ct_PCDSCPage in this.page)
				{
					ct_PCDSCPage.Write(sw, "page");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00073EC0 File Offset: 0x000720C0
		public CT_Pages()
		{
			this.pageField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage>();
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00073ED3 File Offset: 0x000720D3
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x00073EDB File Offset: 0x000720DB
		[global::System.Xml.Serialization.XmlElement("page", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage> page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00073EE4 File Offset: 0x000720E4
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x00073EEC File Offset: 0x000720EC
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00073EF5 File Offset: 0x000720F5
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x00073EFD File Offset: 0x000720FD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x04001FE7 RID: 8167
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage> pageField;

		// Token: 0x04001FE8 RID: 8168
		private uint countField;

		// Token: 0x04001FE9 RID: 8169
		private bool countFieldSpecified;
	}
}
