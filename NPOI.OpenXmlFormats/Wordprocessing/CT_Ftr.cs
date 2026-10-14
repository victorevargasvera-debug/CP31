using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000117 RID: 279
	[global::System.Xml.Serialization.XmlRoot("ftr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	public class CT_Ftr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x000196A8 File Offset: 0x000178A8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr)global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr.Parse(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr(), node, namespaceManager);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000196BB File Offset: 0x000178BB
		internal void Write(global::System.IO.StreamWriter sw)
		{
			base.Write(sw, "ftr");
		}
	}
}
