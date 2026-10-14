using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000043 RID: 67
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShortHexNumber
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00004017 File Offset: 0x00002217
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:val"])
			};
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000403E File Offset: 0x0000223E
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write("/>");
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000406D File Offset: 0x0000226D
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00004075 File Offset: 0x00002275
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

		// Token: 0x040001A7 RID: 423
		private byte[] valField;
	}
}
