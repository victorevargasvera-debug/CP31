using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AD RID: 1197
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ServerFormats
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x0007ACA8 File Offset: 0x00078EA8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats ct_ServerFormats = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats();
			if (node.Attributes["count"] != null)
			{
				ct_ServerFormats.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_ServerFormats.serverFormat = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "serverFormat")
				{
					ct_ServerFormats.serverFormat.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ServerFormats;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0007AD64 File Offset: 0x00078F64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.serverFormat != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat ct_ServerFormat in this.serverFormat)
				{
					ct_ServerFormat.Write(sw, "serverFormat");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0007AE04 File Offset: 0x00079004
		public CT_ServerFormats()
		{
			this.serverFormatField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat>();
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x0007AE17 File Offset: 0x00079017
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x0007AE1F File Offset: 0x0007901F
		[global::System.Xml.Serialization.XmlElement("serverFormat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat> serverFormat
		{
			get
			{
				return this.serverFormatField;
			}
			set
			{
				this.serverFormatField = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x0007AE28 File Offset: 0x00079028
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x0007AE30 File Offset: 0x00079030
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

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x0007AE39 File Offset: 0x00079039
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x0007AE41 File Offset: 0x00079041
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

		// Token: 0x04002127 RID: 8487
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat> serverFormatField;

		// Token: 0x04002128 RID: 8488
		private uint countField;

		// Token: 0x04002129 RID: 8489
		private bool countFieldSpecified;
	}
}
