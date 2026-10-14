using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000049 RID: 73
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HpsMeasure
	{
		// Token: 0x06000268 RID: 616 RVA: 0x000041E9 File Offset: 0x000023E9
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00004210 File Offset: 0x00002410
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00004242 File Offset: 0x00002442
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000424A File Offset: 0x0000244A
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

		// Token: 0x040001AD RID: 429
		private ulong valField;
	}
}
