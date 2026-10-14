using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E7 RID: 1255
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TableColumns
	{
		// Token: 0x060034CA RID: 13514 RVA: 0x00084434 File Offset: 0x00082634
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns ct_TableColumns = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns();
			if (node.Attributes["count"] != null)
			{
				ct_TableColumns.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_TableColumns.tableColumn = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tableColumn")
				{
					ct_TableColumns.tableColumn.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TableColumns;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000844F0 File Offset: 0x000826F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.tableColumn != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn in this.tableColumn)
				{
					ct_TableColumn.Write(sw, "tableColumn");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x00084590 File Offset: 0x00082790
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x00084598 File Offset: 0x00082798
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn> tableColumn
		{
			get
			{
				return this.tableColumnField;
			}
			set
			{
				this.tableColumnField = value;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x000845A1 File Offset: 0x000827A1
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x000845A9 File Offset: 0x000827A9
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

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x000845B2 File Offset: 0x000827B2
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x000845BA File Offset: 0x000827BA
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

		// Token: 0x04002322 RID: 8994
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn> tableColumnField;

		// Token: 0x04002323 RID: 8995
		private uint countField;

		// Token: 0x04002324 RID: 8996
		private bool countFieldSpecified;
	}
}
