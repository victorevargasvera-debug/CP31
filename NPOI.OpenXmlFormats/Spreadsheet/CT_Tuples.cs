using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000491 RID: 1169
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Tuples
	{
		// Token: 0x06002F40 RID: 12096 RVA: 0x00076874 File Offset: 0x00074A74
		public CT_Tuples()
		{
			this.tplField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple>();
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x00076887 File Offset: 0x00074A87
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x0007688F File Offset: 0x00074A8F
		[global::System.Xml.Serialization.XmlElement("tpl", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple> tpl
		{
			get
			{
				return this.tplField;
			}
			set
			{
				this.tplField = value;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x00076898 File Offset: 0x00074A98
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x000768A0 File Offset: 0x00074AA0
		[global::System.Xml.Serialization.XmlAttribute]
		public uint c
		{
			get
			{
				return this.cField;
			}
			set
			{
				this.cField = value;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000768A9 File Offset: 0x00074AA9
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x000768B1 File Offset: 0x00074AB1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cSpecified
		{
			get
			{
				return this.cFieldSpecified;
			}
			set
			{
				this.cFieldSpecified = value;
			}
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000768BC File Offset: 0x00074ABC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples ct_Tuples = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples();
			if (node.Attributes["c"] != null)
			{
				ct_Tuples.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["c"]);
			}
			ct_Tuples.tpl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpl")
				{
					ct_Tuples.tpl.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Tuples;
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00076978 File Offset: 0x00074B78
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "c", this.c, false);
			sw.Write(">");
			if (this.tpl != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple ct_Tuple in this.tpl)
				{
					ct_Tuple.Write(sw, "tpl");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002061 RID: 8289
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple> tplField;

		// Token: 0x04002062 RID: 8290
		private uint cField;

		// Token: 0x04002063 RID: 8291
		private bool cFieldSpecified;
	}
}
