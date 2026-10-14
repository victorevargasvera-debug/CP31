using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000F5 RID: 245
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AltChunk
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x00015878 File Offset: 0x00013A78
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk ct_AltChunk = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk();
			ct_AltChunk.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "altChunkPr")
				{
					ct_AltChunk.altChunkPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AltChunk;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00015910 File Offset: 0x00013B10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			if (this.altChunkPr != null)
			{
				this.altChunkPr.Write(sw, "altChunkPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00015974 File Offset: 0x00013B74
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x0001597C File Offset: 0x00013B7C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr altChunkPr
		{
			get
			{
				return this.altChunkPrField;
			}
			set
			{
				this.altChunkPrField = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00015985 File Offset: 0x00013B85
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0001598D File Offset: 0x00013B8D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x040005D9 RID: 1497
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunkPr altChunkPrField;

		// Token: 0x040005DA RID: 1498
		private string idField;
	}
}
