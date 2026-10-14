using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015E RID: 350
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SectPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x000246CA File Offset: 0x000228CA
		public CT_SectPrChange()
		{
			this.sectPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000246E0 File Offset: 0x000228E0
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange ct_SectPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange();
			ct_SectPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_SectPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_SectPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sectPr")
				{
					ct_SectPrChange.sectPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SectPrChange;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000247B0 File Offset: 0x000229B0
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.sectPr != null)
			{
				this.sectPr.Write(sw, "sectPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00024836 File Offset: 0x00022A36
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0002483E File Offset: 0x00022A3E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase sectPr
		{
			get
			{
				return this.sectPrField;
			}
			set
			{
				this.sectPrField = value;
			}
		}

		// Token: 0x040009E0 RID: 2528
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase sectPrField;
	}
}
