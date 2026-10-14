using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000BE RID: 190
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrackChangeNumbering : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering
			{
				original = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["original"]),
				author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["author"]),
				date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["date"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"])
			};
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000F380 File Offset: 0x0000D580
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "original", this.original);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", base.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000F3FE File Offset: 0x0000D5FE
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000F406 File Offset: 0x0000D606
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string original
		{
			get
			{
				return this.originalField;
			}
			set
			{
				this.originalField = value;
			}
		}

		// Token: 0x040004A6 RID: 1190
		private string originalField;
	}
}
