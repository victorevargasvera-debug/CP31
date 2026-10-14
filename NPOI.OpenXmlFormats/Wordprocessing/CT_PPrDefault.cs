using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000148 RID: 328
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PPrDefault
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x0001FD10 File Offset: 0x0001DF10
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault ct_PPrDefault = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pPr")
				{
					ct_PPrDefault.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PPrDefault;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001FD90 File Offset: 0x0001DF90
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0001FDE3 File Offset: 0x0001DFE3
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0001FDEB File Offset: 0x0001DFEB
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

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr AddNewPPr()
		{
			this.pPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr();
			return this.pPrField;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001FE07 File Offset: 0x0001E007
		public bool IsSetPPr()
		{
			return this.pPrField != null;
		}

		// Token: 0x04000828 RID: 2088
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPrField;
	}
}
