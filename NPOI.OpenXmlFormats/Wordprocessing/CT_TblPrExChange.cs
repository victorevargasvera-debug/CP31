using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B1 RID: 433
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPrExChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x00035444 File Offset: 0x00033644
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange ct_TblPrExChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange();
			ct_TblPrExChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_TblPrExChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_TblPrExChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblPrEx")
				{
					ct_TblPrExChange.tblPrEx = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPrExChange;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00035514 File Offset: 0x00033714
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id);
			sw.Write(">");
			if (this.tblPrEx != null)
			{
				this.tblPrEx.Write(sw, "tblPrEx");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0003559A File Offset: 0x0003379A
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000355A2 File Offset: 0x000337A2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase tblPrEx
		{
			get
			{
				return this.tblPrExField;
			}
			set
			{
				this.tblPrExField = value;
			}
		}

		// Token: 0x04000D18 RID: 3352
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase tblPrExField;
	}
}
