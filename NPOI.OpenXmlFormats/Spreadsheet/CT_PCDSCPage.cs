using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000481 RID: 1153
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PCDSCPage
	{
		// Token: 0x06002E2B RID: 11819 RVA: 0x00073F08 File Offset: 0x00072108
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage ct_PCDSCPage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSCPage();
			if (node.Attributes["count"] != null)
			{
				ct_PCDSCPage.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PCDSCPage.pageItem = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pageItem")
				{
					ct_PCDSCPage.pageItem.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PCDSCPage;
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00073FC4 File Offset: 0x000721C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.pageItem != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem ct_PageItem in this.pageItem)
				{
					ct_PageItem.Write(sw, "pageItem");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00074064 File Offset: 0x00072264
		public CT_PCDSCPage()
		{
			this.pageItemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem>();
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x00074077 File Offset: 0x00072277
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x0007407F File Offset: 0x0007227F
		[global::System.Xml.Serialization.XmlElement("pageItem", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem> pageItem
		{
			get
			{
				return this.pageItemField;
			}
			set
			{
				this.pageItemField = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x00074088 File Offset: 0x00072288
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x00074090 File Offset: 0x00072290
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00074099 File Offset: 0x00072299
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x000740A1 File Offset: 0x000722A1
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

		// Token: 0x04001FEA RID: 8170
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem> pageItemField;

		// Token: 0x04001FEB RID: 8171
		private uint countField;

		// Token: 0x04001FEC RID: 8172
		private bool countFieldSpecified;
	}
}
