using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000F6 RID: 246
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AltChunkPr
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00015998 File Offset: 0x00013B98
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr ct_AltChunkPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "matchSrc")
				{
					ct_AltChunkPr.matchSrc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AltChunkPr;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00015A18 File Offset: 0x00013C18
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.matchSrc != null)
			{
				this.matchSrc.Write(sw, "matchSrc");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00015A6B File Offset: 0x00013C6B
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00015A73 File Offset: 0x00013C73
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff matchSrc
		{
			get
			{
				return this.matchSrcField;
			}
			set
			{
				this.matchSrcField = value;
			}
		}

		// Token: 0x040005DB RID: 1499
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff matchSrcField;
	}
}
