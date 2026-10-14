using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000070 RID: 112
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_GlossaryDocument))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocumentBase
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00009C39 File Offset: 0x00007E39
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00009C41 File Offset: 0x00007E41
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background background
		{
			get
			{
				return this.backgroundField;
			}
			set
			{
				this.backgroundField = value;
			}
		}

		// Token: 0x040002DD RID: 733
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background backgroundField;
	}
}
