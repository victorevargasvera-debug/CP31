using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048C RID: 1164
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CacheHierarchies
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x00075AEC File Offset: 0x00073CEC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies ct_CacheHierarchies = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies();
			if (node.Attributes["count"] != null)
			{
				ct_CacheHierarchies.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_CacheHierarchies.cacheHierarchy = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cacheHierarchy")
				{
					ct_CacheHierarchies.cacheHierarchy.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CacheHierarchies;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00075BA8 File Offset: 0x00073DA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.cacheHierarchy != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy ct_CacheHierarchy in this.cacheHierarchy)
				{
					ct_CacheHierarchy.Write(sw, "cacheHierarchy");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00075C48 File Offset: 0x00073E48
		public CT_CacheHierarchies()
		{
			this.cacheHierarchyField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy>();
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x00075C5B File Offset: 0x00073E5B
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x00075C63 File Offset: 0x00073E63
		[global::System.Xml.Serialization.XmlElement("cacheHierarchy", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy> cacheHierarchy
		{
			get
			{
				return this.cacheHierarchyField;
			}
			set
			{
				this.cacheHierarchyField = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00075C6C File Offset: 0x00073E6C
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x00075C74 File Offset: 0x00073E74
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00075C7D File Offset: 0x00073E7D
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x00075C85 File Offset: 0x00073E85
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

		// Token: 0x04002039 RID: 8249
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy> cacheHierarchyField;

		// Token: 0x0400203A RID: 8250
		private uint countField;

		// Token: 0x0400203B RID: 8251
		private bool countFieldSpecified;
	}
}
