using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000FC RID: 252
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FitText
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x00015D18 File Offset: 0x00013F18
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:val"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"])
			};
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00015D68 File Offset: 0x00013F68
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00015DC6 File Offset: 0x00013FC6
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00015DCE File Offset: 0x00013FCE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong val
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00015DD7 File Offset: 0x00013FD7
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00015DDF File Offset: 0x00013FDF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x0400061F RID: 1567
		private ulong valField;

		// Token: 0x04000620 RID: 1568
		private string idField;
	}
}
