using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000118 RID: 280
	[global::System.Xml.Serialization.XmlRoot("hdr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	public class CT_Hdr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x000196D1 File Offset: 0x000178D1
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr)global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr.Parse(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr(), node, namespaceManager);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000196E4 File Offset: 0x000178E4
		internal void Write(global::System.IO.StreamWriter sw)
		{
			base.Write(sw, "hdr");
		}
	}
}
