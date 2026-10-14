using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000196 RID: 406
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocRsids
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x00031AF0 File Offset: 0x0002FCF0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids ct_DocRsids = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids();
			ct_DocRsids.rsid = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rsidRoot")
				{
					ct_DocRsids.rsidRoot = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rsid")
				{
					ct_DocRsids.rsid.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DocRsids;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00031BA0 File Offset: 0x0002FDA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rsidRoot != null)
			{
				this.rsidRoot.Write(sw, "rsidRoot");
			}
			if (this.rsid != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber ct_LongHexNumber in this.rsid)
				{
					ct_LongHexNumber.Write(sw, "rsid");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00031C44 File Offset: 0x0002FE44
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00031C4C File Offset: 0x0002FE4C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber rsidRoot
		{
			get
			{
				return this.rsidRootField;
			}
			set
			{
				this.rsidRootField = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00031C55 File Offset: 0x0002FE55
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00031C5D File Offset: 0x0002FE5D
		[global::System.Xml.Serialization.XmlElement("rsid", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber> rsid
		{
			get
			{
				return this.rsidField;
			}
			set
			{
				this.rsidField = value;
			}
		}

		// Token: 0x04000C6B RID: 3179
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber rsidRootField;

		// Token: 0x04000C6C RID: 3180
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber> rsidField;
	}
}
