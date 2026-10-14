using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001AC RID: 428
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPrChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x00034720 File Offset: 0x00032920
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange ct_TblPrChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange();
			ct_TblPrChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_TblPrChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_TblPrChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblPr")
				{
					ct_TblPrChange.tblPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPrChange;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000347F0 File Offset: 0x000329F0
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.tblPr != null)
			{
				this.tblPr.Write(sw, "tblPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00034876 File Offset: 0x00032A76
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x0003487E File Offset: 0x00032A7E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase tblPr
		{
			get
			{
				return this.tblPrField;
			}
			set
			{
				this.tblPrField = value;
			}
		}

		// Token: 0x04000CE5 RID: 3301
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase tblPrField;
	}
}
