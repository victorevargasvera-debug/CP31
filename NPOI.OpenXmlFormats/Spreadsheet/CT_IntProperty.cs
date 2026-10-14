using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000618 RID: 1560
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_IntProperty
	{
		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x000A1B7E File Offset: 0x0009FD7E
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x000A1B86 File Offset: 0x0009FD86
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000A1B8F File Offset: 0x0009FD8F
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x000A1BB6 File Offset: 0x0009FDB6
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		// Token: 0x04002ABD RID: 10941
		private int valField;
	}
}
