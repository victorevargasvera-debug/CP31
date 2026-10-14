using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000113 RID: 275
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ProofErr
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x00018554 File Offset: 0x00016754
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr ct_ProofErr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr();
			if (node.Attributes["w:type"] != null)
			{
				ct_ProofErr.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ProofErr)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ProofErr), node.Attributes["w:type"].Value);
			}
			return ct_ProofErr;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000185B0 File Offset: 0x000167B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			sw.Write("/>");
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000185F8 File Offset: 0x000167F8
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00018600 File Offset: 0x00016800
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ProofErr type
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

		// Token: 0x040006C9 RID: 1737
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ProofErr typeField;
	}
}
