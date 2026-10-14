using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000075 RID: 117
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPart
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000AF6C File Offset: 0x0000916C
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000AF74 File Offset: 0x00009174
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartPr docPartPr
		{
			get
			{
				return this.docPartPrField;
			}
			set
			{
				this.docPartPrField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000AF7D File Offset: 0x0000917D
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000AF85 File Offset: 0x00009185
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body docPartBody
		{
			get
			{
				return this.docPartBodyField;
			}
			set
			{
				this.docPartBodyField = value;
			}
		}

		// Token: 0x04000302 RID: 770
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartPr docPartPrField;

		// Token: 0x04000303 RID: 771
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body docPartBodyField;
	}
}
