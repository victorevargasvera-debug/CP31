using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D9 RID: 1241
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MemberProperties
	{
		// Token: 0x060033CF RID: 13263 RVA: 0x000821D8 File Offset: 0x000803D8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties ct_MemberProperties = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties();
			if (node.Attributes["count"] != null)
			{
				ct_MemberProperties.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_MemberProperties.mp = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mp")
				{
					ct_MemberProperties.mp.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MemberProperties;
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00082294 File Offset: 0x00080494
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.mp != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty ct_MemberProperty in this.mp)
				{
					ct_MemberProperty.Write(sw, "mp");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00082334 File Offset: 0x00080534
		public CT_MemberProperties()
		{
			this.mpField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty>();
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x00082347 File Offset: 0x00080547
		// (set) Token: 0x060033D3 RID: 13267 RVA: 0x0008234F File Offset: 0x0008054F
		[global::System.Xml.Serialization.XmlElement("mp", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty> mp
		{
			get
			{
				return this.mpField;
			}
			set
			{
				this.mpField = value;
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x00082358 File Offset: 0x00080558
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x00082360 File Offset: 0x00080560
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

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x00082369 File Offset: 0x00080569
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x00082371 File Offset: 0x00080571
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

		// Token: 0x04002279 RID: 8825
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty> mpField;

		// Token: 0x0400227A RID: 8826
		private uint countField;

		// Token: 0x0400227B RID: 8827
		private bool countFieldSpecified;
	}
}
