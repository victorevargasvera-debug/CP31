using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200008F RID: 143
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFTextType
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000B89E File Offset: 0x00009A9E
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000B8A6 File Offset: 0x00009AA6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FFTextType val
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000B8AF File Offset: 0x00009AAF
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType
			{
				valField = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_FFTextType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_FFTextType), global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]))
			};
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000B8EA File Offset: 0x00009AEA
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.valField.ToString());
			sw.Write("/>");
		}

		// Token: 0x0400038E RID: 910
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FFTextType valField;
	}
}
