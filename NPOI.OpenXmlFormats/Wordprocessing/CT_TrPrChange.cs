using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B9 RID: 441
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x00036778 File Offset: 0x00034978
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange ct_TrPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange();
			ct_TrPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_TrPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_TrPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "trPr")
				{
					ct_TrPrChange.trPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TrPrChange;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00036848 File Offset: 0x00034A48
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.trPr != null)
			{
				this.trPr.Write(sw, "trPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000368CE File Offset: 0x00034ACE
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x000368D6 File Offset: 0x00034AD6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase trPr
		{
			get
			{
				return this.trPrField;
			}
			set
			{
				this.trPrField = value;
			}
		}

		// Token: 0x04000D33 RID: 3379
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase trPrField;
	}
}
