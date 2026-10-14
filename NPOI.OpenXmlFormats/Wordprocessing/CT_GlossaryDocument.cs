using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200006F RID: 111
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("glossaryDocument", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_GlossaryDocument : global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocumentBase
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00009C15 File Offset: 0x00007E15
		public CT_GlossaryDocument()
		{
			this.docPartsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocParts();
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00009C28 File Offset: 0x00007E28
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00009C30 File Offset: 0x00007E30
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocParts docParts
		{
			get
			{
				return this.docPartsField;
			}
			set
			{
				this.docPartsField = value;
			}
		}

		// Token: 0x040002DC RID: 732
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocParts docPartsField;
	}
}
