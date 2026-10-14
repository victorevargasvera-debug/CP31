using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A8 RID: 424
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblOverlap
	{
		// Token: 0x06000FF0 RID: 4080 RVA: 0x0003453C File Offset: 0x0003273C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap ct_TblOverlap = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap();
			if (node.Attributes["w:val"] != null)
			{
				ct_TblOverlap.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblOverlap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblOverlap), node.Attributes["w:val"].Value);
			}
			return ct_TblOverlap;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00034598 File Offset: 0x00032798
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000345F1 File Offset: 0x000327F1
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000345F9 File Offset: 0x000327F9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblOverlap val
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

		// Token: 0x04000CD9 RID: 3289
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblOverlap valField;
	}
}
