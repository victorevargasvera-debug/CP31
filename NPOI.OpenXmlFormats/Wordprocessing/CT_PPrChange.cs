using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000169 RID: 361
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x0002909C File Offset: 0x0002729C
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange ct_PPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange();
			ct_PPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_PPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_PPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pPr")
				{
					ct_PPrChange.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PPrChange;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002916C File Offset: 0x0002736C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000291F2 File Offset: 0x000273F2
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000291FA File Offset: 0x000273FA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}

		// Token: 0x04000AAE RID: 2734
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase pPrField;
	}
}
