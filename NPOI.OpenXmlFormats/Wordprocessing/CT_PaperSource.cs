using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C6 RID: 198
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PaperSource
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource
			{
				first = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:first"]),
				other = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:other"])
			};
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000FB44 File Offset: 0x0000DD44
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:first", this.first);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:other", this.other);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string first
		{
			get
			{
				return this.firstField;
			}
			set
			{
				this.firstField = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000FBB1 File Offset: 0x0000DDB1
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000FBB9 File Offset: 0x0000DDB9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string other
		{
			get
			{
				return this.otherField;
			}
			set
			{
				this.otherField = value;
			}
		}

		// Token: 0x040004CD RID: 1229
		private string firstField;

		// Token: 0x040004CE RID: 1230
		private string otherField;
	}
}
