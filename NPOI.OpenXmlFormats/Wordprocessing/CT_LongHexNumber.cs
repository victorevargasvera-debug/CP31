using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000042 RID: 66
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LongHexNumber
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00003FB0 File Offset: 0x000021B0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:val"])
			};
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003FD7 File Offset: 0x000021D7
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write("/>");
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00004006 File Offset: 0x00002206
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000400E File Offset: 0x0000220E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] val
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

		// Token: 0x040001A6 RID: 422
		private byte[] valField;
	}
}
