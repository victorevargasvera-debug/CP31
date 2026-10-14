using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A8 RID: 1192
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Sets
	{
		// Token: 0x060030CC RID: 12492 RVA: 0x0007A4DC File Offset: 0x000786DC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets ct_Sets = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets();
			if (node.Attributes["count"] != null)
			{
				ct_Sets.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Sets.set = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "set")
				{
					ct_Sets.set.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Sets;
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0007A598 File Offset: 0x00078798
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.set != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set ct_Set in this.set)
				{
					ct_Set.Write(sw, "set");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0007A638 File Offset: 0x00078838
		public CT_Sets()
		{
			this.setField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set>();
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x0007A64B File Offset: 0x0007884B
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x0007A653 File Offset: 0x00078853
		[global::System.Xml.Serialization.XmlElement("set", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set> set
		{
			get
			{
				return this.setField;
			}
			set
			{
				this.setField = value;
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0007A65C File Offset: 0x0007885C
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x0007A664 File Offset: 0x00078864
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

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0007A66D File Offset: 0x0007886D
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x0007A675 File Offset: 0x00078875
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

		// Token: 0x0400210F RID: 8463
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set> setField;

		// Token: 0x04002110 RID: 8464
		private uint countField;

		// Token: 0x04002111 RID: 8465
		private bool countFieldSpecified;
	}
}
