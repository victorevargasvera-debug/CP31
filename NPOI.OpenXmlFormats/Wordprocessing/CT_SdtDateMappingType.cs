using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E1 RID: 225
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtDateMappingType
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00014D14 File Offset: 0x00012F14
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType ct_SdtDateMappingType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType();
			if (node.Attributes["w:val"] != null)
			{
				ct_SdtDateMappingType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_SdtDateMappingType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_SdtDateMappingType), node.Attributes["w:val"].Value);
			}
			return ct_SdtDateMappingType;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00014D70 File Offset: 0x00012F70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00014DC9 File Offset: 0x00012FC9
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00014DD1 File Offset: 0x00012FD1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_SdtDateMappingType val
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00014DDA File Offset: 0x00012FDA
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00014DE2 File Offset: 0x00012FE2
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

		// Token: 0x0400058A RID: 1418
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_SdtDateMappingType valField;

		// Token: 0x0400058B RID: 1419
		private bool valFieldSpecified;
	}
}
