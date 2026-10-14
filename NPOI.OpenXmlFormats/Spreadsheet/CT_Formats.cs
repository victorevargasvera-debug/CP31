using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CD RID: 1229
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Formats
	{
		// Token: 0x06003364 RID: 13156 RVA: 0x00080D9C File Offset: 0x0007EF9C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats ct_Formats = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats();
			if (node.Attributes["count"] != null)
			{
				ct_Formats.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Formats.format = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "format")
				{
					ct_Formats.format.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Formats;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00080E58 File Offset: 0x0007F058
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.format != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format ct_Format in this.format)
				{
					ct_Format.Write(sw, "format");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00080EF8 File Offset: 0x0007F0F8
		public CT_Formats()
		{
			this.formatField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format>();
			this.countField = 0U;
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x00080F12 File Offset: 0x0007F112
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x00080F1A File Offset: 0x0007F11A
		[global::System.Xml.Serialization.XmlElement("format", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format> format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x00080F23 File Offset: 0x0007F123
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x00080F2B File Offset: 0x0007F12B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x04002243 RID: 8771
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format> formatField;

		// Token: 0x04002244 RID: 8772
		private uint countField;
	}
}
