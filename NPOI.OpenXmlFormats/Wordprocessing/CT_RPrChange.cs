using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200016B RID: 363
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06000C4F RID: 3151 RVA: 0x0002A058 File Offset: 0x00028258
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange ct_RPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange();
			ct_RPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_RPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_RPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_RPrChange.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RPrChange;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0002A128 File Offset: 0x00028328
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0002A1AE File Offset: 0x000283AE
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x0002A1B6 File Offset: 0x000283B6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x04000AD0 RID: 2768
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal rPrField;
	}
}
