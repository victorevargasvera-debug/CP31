using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C3 RID: 1219
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Field
	{
		// Token: 0x060032FB RID: 13051 RVA: 0x0007FB88 File Offset: 0x0007DD88
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field ct_Field = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field();
			if (node.Attributes["x"] != null)
			{
				ct_Field.x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["x"]);
			}
			return ct_Field;
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0007FBCE File Offset: 0x0007DDCE
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", this.x);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x0007FC0E File Offset: 0x0007DE0E
		// (set) Token: 0x060032FE RID: 13054 RVA: 0x0007FC16 File Offset: 0x0007DE16
		[global::System.Xml.Serialization.XmlAttribute]
		public int x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x04002215 RID: 8725
		private int xField;
	}
}
