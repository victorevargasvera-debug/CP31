using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004FF RID: 1279
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellStyles
	{
		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x00087C21 File Offset: 0x00085E21
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x00087C29 File Offset: 0x00085E29
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle> cellStyle
		{
			get
			{
				return this.cellStyleField;
			}
			set
			{
				this.cellStyleField = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x00087C32 File Offset: 0x00085E32
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x00087C3A File Offset: 0x00085E3A
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x00087C43 File Offset: 0x00085E43
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x00087C4B File Offset: 0x00085E4B
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

		// Token: 0x06003684 RID: 13956 RVA: 0x00087C54 File Offset: 0x00085E54
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles ct_CellStyles = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyles();
			ct_CellStyles.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_CellStyles.cellStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cellStyle")
				{
					ct_CellStyles.cellStyle.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellStyles;
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00087CFC File Offset: 0x00085EFC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.cellStyle != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle ct_CellStyle in this.cellStyle)
				{
					ct_CellStyle.Write(sw, "cellStyle");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040023E0 RID: 9184
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle> cellStyleField;

		// Token: 0x040023E1 RID: 9185
		private uint countField;

		// Token: 0x040023E2 RID: 9186
		private bool countFieldSpecified;
	}
}
