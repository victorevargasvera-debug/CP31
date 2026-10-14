using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000146 RID: 326
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocDefaults
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults ct_DocDefaults = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPrDefault")
				{
					ct_DocDefaults.rPrDefault = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pPrDefault")
				{
					ct_DocDefaults.pPrDefault = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DocDefaults;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0001FB40 File Offset: 0x0001DD40
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rPrDefault != null)
			{
				this.rPrDefault.Write(sw, "rPrDefault");
			}
			if (this.pPrDefault != null)
			{
				this.pPrDefault.Write(sw, "pPrDefault");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault rPrDefault
		{
			get
			{
				return this.rPrDefaultField;
			}
			set
			{
				this.rPrDefaultField = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0001FBBD File Offset: 0x0001DDBD
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0001FBC5 File Offset: 0x0001DDC5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault pPrDefault
		{
			get
			{
				return this.pPrDefaultField;
			}
			set
			{
				this.pPrDefaultField = value;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001FBCE File Offset: 0x0001DDCE
		public bool IsSetRPrDefault()
		{
			return this.rPrDefaultField != null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001FBD9 File Offset: 0x0001DDD9
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault AddNewRPrDefault()
		{
			this.rPrDefaultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault();
			return this.rPrDefaultField;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		public bool IsSetPPrDefault()
		{
			return this.pPrDefaultField != null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001FBF7 File Offset: 0x0001DDF7
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault AddNewPPrDefault()
		{
			this.pPrDefaultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault();
			return this.pPrDefaultField;
		}

		// Token: 0x04000825 RID: 2085
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault rPrDefaultField;

		// Token: 0x04000826 RID: 2086
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault pPrDefaultField;
	}
}
