using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C6 RID: 454
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HMerge
	{
		// Token: 0x06001159 RID: 4441 RVA: 0x00039AC8 File Offset: 0x00037CC8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge ct_HMerge = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge();
			if (node.Attributes["w:val"] != null)
			{
				ct_HMerge.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge), node.Attributes["w:val"].Value);
			}
			return ct_HMerge;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00039B24 File Offset: 0x00037D24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x00039B7D File Offset: 0x00037D7D
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x00039B85 File Offset: 0x00037D85
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge val
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x00039B8E File Offset: 0x00037D8E
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x00039B96 File Offset: 0x00037D96
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x04000D81 RID: 3457
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge valField;

		// Token: 0x04000D82 RID: 3458
		private bool valFieldSpecified;
	}
}
