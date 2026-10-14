using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001BE RID: 446
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x060010FA RID: 4346 RVA: 0x000387C8 File Offset: 0x000369C8
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange ct_TcPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange();
			ct_TcPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_TcPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_TcPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tcPr")
				{
					ct_TcPrChange.tcPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TcPrChange;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00038898 File Offset: 0x00036A98
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.tcPr != null)
			{
				this.tcPr.Write(sw, "tcPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0003891E File Offset: 0x00036B1E
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x00038926 File Offset: 0x00036B26
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner tcPr
		{
			get
			{
				return this.tcPrField;
			}
			set
			{
				this.tcPrField = value;
			}
		}

		// Token: 0x04000D5C RID: 3420
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner tcPrField;
	}
}
