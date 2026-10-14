using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000630 RID: 1584
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TwipsMeasure
	{
		// Token: 0x060044D7 RID: 17623 RVA: 0x000A3776 File Offset: 0x000A1976
		public static global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["m:val"])
			};
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000A379D File Offset: 0x000A199D
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x000A37CD File Offset: 0x000A19CD
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x000A37D5 File Offset: 0x000A19D5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public uint val
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

		// Token: 0x04002B24 RID: 11044
		private uint valField;
	}
}
