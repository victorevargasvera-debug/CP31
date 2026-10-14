using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000046 RID: 70
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TwipsMeasure
	{
		// Token: 0x0600025B RID: 603 RVA: 0x000040F7 File Offset: 0x000022F7
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:val"])
			};
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000411E File Offset: 0x0000231E
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write("/>");
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000414F File Offset: 0x0000234F
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00004157 File Offset: 0x00002357
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

		// Token: 0x040001AA RID: 426
		private ulong valField;
	}
}
