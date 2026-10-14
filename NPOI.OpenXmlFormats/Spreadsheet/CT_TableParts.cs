using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BA RID: 1466
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TableParts
	{
		// Token: 0x06004081 RID: 16513 RVA: 0x0009C761 File Offset: 0x0009A961
		public CT_TableParts()
		{
			this.tablePartField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart>();
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0009C774 File Offset: 0x0009A974
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart AddNewTablePart()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart ct_TablePart = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart();
			this.tablePart.Add(ct_TablePart);
			return ct_TablePart;
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x0009C794 File Offset: 0x0009A994
		// (set) Token: 0x06004084 RID: 16516 RVA: 0x0009C79C File Offset: 0x0009A99C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart> tablePart
		{
			get
			{
				return this.tablePartField;
			}
			set
			{
				this.tablePartField = value;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004085 RID: 16517 RVA: 0x0009C7A5 File Offset: 0x0009A9A5
		// (set) Token: 0x06004086 RID: 16518 RVA: 0x0009C7AD File Offset: 0x0009A9AD
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

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x0009C7B6 File Offset: 0x0009A9B6
		// (set) Token: 0x06004088 RID: 16520 RVA: 0x0009C7BE File Offset: 0x0009A9BE
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

		// Token: 0x06004089 RID: 16521 RVA: 0x0009C7C8 File Offset: 0x0009A9C8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts ct_TableParts = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts();
			ct_TableParts.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_TableParts.tablePart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tablePart")
				{
					ct_TableParts.tablePart.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TableParts;
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0009C870 File Offset: 0x0009AA70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.tablePart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart ct_TablePart in this.tablePart)
				{
					ct_TablePart.Write(sw, "tablePart");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028EA RID: 10474
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart> tablePartField;

		// Token: 0x040028EB RID: 10475
		private uint countField;

		// Token: 0x040028EC RID: 10476
		private bool countFieldSpecified;
	}
}
