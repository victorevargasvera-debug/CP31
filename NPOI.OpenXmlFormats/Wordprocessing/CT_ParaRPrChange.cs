using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000166 RID: 358
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ParaRPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06000B94 RID: 2964 RVA: 0x00027540 File Offset: 0x00025740
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange ct_ParaRPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange();
			ct_ParaRPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["author"]);
			ct_ParaRPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["date"]);
			ct_ParaRPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_ParaRPrChange.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ParaRPrChange;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00027610 File Offset: 0x00025810
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", base.id);
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00027696 File Offset: 0x00025896
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0002769E File Offset: 0x0002589E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal rPr
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

		// Token: 0x04000A5A RID: 2650
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal rPrField;
	}
}
