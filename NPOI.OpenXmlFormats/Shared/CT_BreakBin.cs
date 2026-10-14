using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000635 RID: 1589
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BreakBin
	{
		// Token: 0x060044EA RID: 17642 RVA: 0x000A39C0 File Offset: 0x000A1BC0
		public static global::NPOI.OpenXmlFormats.Shared.CT_BreakBin Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BreakBin ct_BreakBin = new global::NPOI.OpenXmlFormats.Shared.CT_BreakBin();
			if (node.Attributes["m:val"] != null)
			{
				ct_BreakBin.val = (global::NPOI.OpenXmlFormats.Shared.ST_BreakBin)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_BreakBin), node.Attributes["m:val"].Value);
			}
			return ct_BreakBin;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x000A3A1C File Offset: 0x000A1C1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x000A3A64 File Offset: 0x000A1C64
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x000A3A6C File Offset: 0x000A1C6C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_BreakBin val
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x000A3A75 File Offset: 0x000A1C75
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x000A3A80 File Offset: 0x000A1C80
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valField > global::NPOI.OpenXmlFormats.Shared.ST_BreakBin.NONE;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x04002B32 RID: 11058
		private global::NPOI.OpenXmlFormats.Shared.ST_BreakBin valField;

		// Token: 0x04002B33 RID: 11059
		private bool valFieldSpecified;
	}
}
