using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200062E RID: 1582
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMathJc
	{
		// Token: 0x060044D0 RID: 17616 RVA: 0x000A36B0 File Offset: 0x000A18B0
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMathJc Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMathJc ct_OMathJc = new global::NPOI.OpenXmlFormats.Shared.CT_OMathJc();
			if (node.Attributes["m:val"] != null)
			{
				ct_OMathJc.val = (global::NPOI.OpenXmlFormats.Shared.ST_Jc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_Jc), node.Attributes["m:val"].Value);
			}
			return ct_OMathJc;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x000A370C File Offset: 0x000A190C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x000A3754 File Offset: 0x000A1954
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x000A375C File Offset: 0x000A195C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_Jc val
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

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000A3765 File Offset: 0x000A1965
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x000A376D File Offset: 0x000A196D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x04002B1D RID: 11037
		private global::NPOI.OpenXmlFormats.Shared.ST_Jc valField;

		// Token: 0x04002B1E RID: 11038
		private bool valFieldSpecified;
	}
}
