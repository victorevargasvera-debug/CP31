using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200063E RID: 1598
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_YAlign
	{
		// Token: 0x0600450F RID: 17679 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
		public static global::NPOI.OpenXmlFormats.Shared.CT_YAlign Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_YAlign ct_YAlign = new global::NPOI.OpenXmlFormats.Shared.CT_YAlign();
			if (node.Attributes["m:val"] != null)
			{
				ct_YAlign.val = (global::NPOI.OpenXmlFormats.Shared.ST_YAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_YAlign), node.Attributes["m:val"].Value);
			}
			return ct_YAlign;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x000A3E14 File Offset: 0x000A2014
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x000A3E6D File Offset: 0x000A206D
		// (set) Token: 0x06004512 RID: 17682 RVA: 0x000A3E75 File Offset: 0x000A2075
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_YAlign val
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

		// Token: 0x04002B43 RID: 11075
		private global::NPOI.OpenXmlFormats.Shared.ST_YAlign valField;
	}
}
