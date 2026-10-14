using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200014B RID: 331
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Em
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x00020B74 File Offset: 0x0001ED74
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em ct_Em = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em();
			if (node.Attributes["w:val"] != null)
			{
				ct_Em.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Em)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Em), node.Attributes["w:val"].Value);
			}
			return ct_Em;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00020C29 File Offset: 0x0001EE29
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00020C31 File Offset: 0x0001EE31
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Em val
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

		// Token: 0x04000851 RID: 2129
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Em valField;
	}
}
