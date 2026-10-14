using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000170 RID: 368
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblStylePr
	{
		// Token: 0x06000CAF RID: 3247 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr ct_TblStylePr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr();
			if (node.Attributes["w:type"] != null)
			{
				ct_TblStylePr.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblStyleOverrideType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblStyleOverrideType), node.Attributes["w:type"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pPr")
				{
					ct_TblStylePr.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPr")
				{
					ct_TblStylePr.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblPr")
				{
					ct_TblStylePr.tblPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trPr")
				{
					ct_TblStylePr.trPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcPr")
				{
					ct_TblStylePr.tcPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblStylePr;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0002BD3C File Offset: 0x00029F3C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			sw.Write(">");
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.tblPr != null)
			{
				this.tblPr.Write(sw, "tblPr");
			}
			if (this.trPr != null)
			{
				this.trPr.Write(sw, "trPr");
			}
			if (this.tcPr != null)
			{
				this.tcPr.Write(sw, "tcPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0002BE12 File Offset: 0x0002A012
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x0002BE1A File Offset: 0x0002A01A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPr
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0002BE23 File Offset: 0x0002A023
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x0002BE2B File Offset: 0x0002A02B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0002BE34 File Offset: 0x0002A034
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x0002BE3C File Offset: 0x0002A03C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0002BE45 File Offset: 0x0002A045
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0002BE4D File Offset: 0x0002A04D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0002BE56 File Offset: 0x0002A056
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0002BE5E File Offset: 0x0002A05E
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPr
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0002BE67 File Offset: 0x0002A067
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0002BE6F File Offset: 0x0002A06F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblStyleOverrideType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x04000B05 RID: 2821
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPrField;

		// Token: 0x04000B06 RID: 2822
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;

		// Token: 0x04000B07 RID: 2823
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase tblPrField;

		// Token: 0x04000B08 RID: 2824
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPrField;

		// Token: 0x04000B09 RID: 2825
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPrField;

		// Token: 0x04000B0A RID: 2826
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblStyleOverrideType typeField;
	}
}
