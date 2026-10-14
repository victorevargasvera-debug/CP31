using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000115 RID: 277
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DataBinding
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x000186F0 File Offset: 0x000168F0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding
			{
				prefixMappings = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:prefixMappings"]),
				xpath = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:xpath"]),
				storeItemID = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:storeItemID"])
			};
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00018758 File Offset: 0x00016958
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:prefixMappings", this.prefixMappings);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:xpath", this.xpath);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:storeItemID", this.storeItemID);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000187C5 File Offset: 0x000169C5
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000187CD File Offset: 0x000169CD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string prefixMappings
		{
			get
			{
				return this.prefixMappingsField;
			}
			set
			{
				this.prefixMappingsField = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x000187D6 File Offset: 0x000169D6
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x000187DE File Offset: 0x000169DE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string xpath
		{
			get
			{
				return this.xpathField;
			}
			set
			{
				this.xpathField = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x000187E7 File Offset: 0x000169E7
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x000187EF File Offset: 0x000169EF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string storeItemID
		{
			get
			{
				return this.storeItemIDField;
			}
			set
			{
				this.storeItemIDField = value;
			}
		}

		// Token: 0x040006CB RID: 1739
		private string prefixMappingsField;

		// Token: 0x040006CC RID: 1740
		private string xpathField;

		// Token: 0x040006CD RID: 1741
		private string storeItemIDField;
	}
}
