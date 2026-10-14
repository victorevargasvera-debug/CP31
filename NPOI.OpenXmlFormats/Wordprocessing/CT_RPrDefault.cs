using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000147 RID: 327
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RPrDefault
	{
		// Token: 0x060008E5 RID: 2277 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault ct_RPrDefault = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_RPrDefault.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RPrDefault;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0001FCDF File Offset: 0x0001DEDF
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0001FCE7 File Offset: 0x0001DEE7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		public bool IsSetRPr()
		{
			return this.rPrField != null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001FCFB File Offset: 0x0001DEFB
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr AddNewRPr()
		{
			this.rPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			return this.rPrField;
		}

		// Token: 0x04000827 RID: 2087
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;
	}
}
