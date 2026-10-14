using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200011A RID: 282
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HdrFtrRef : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x000196F4 File Offset: 0x000178F4
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef();
			if (node.Attributes["w:type"] != null)
			{
				ct_HdrFtrRef.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr), node.Attributes["w:type"].Value);
			}
			ct_HdrFtrRef.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			return ct_HdrFtrRef;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001976C File Offset: 0x0001796C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write("/>");
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000197C5 File Offset: 0x000179C5
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x000197CD File Offset: 0x000179CD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x040006EF RID: 1775
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr typeField;
	}
}
