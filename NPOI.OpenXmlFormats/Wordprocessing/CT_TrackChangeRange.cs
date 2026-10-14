using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000104 RID: 260
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrackChangeRange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0001600A File Offset: 0x0001420A
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00016012 File Offset: 0x00014212
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml displacedByCustomXml
		{
			get
			{
				return this.displacedByCustomXmlField;
			}
			set
			{
				this.displacedByCustomXmlField = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001601B File Offset: 0x0001421B
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00016023 File Offset: 0x00014223
		[global::System.Xml.Serialization.XmlIgnore]
		public bool displacedByCustomXmlSpecified
		{
			get
			{
				return this.displacedByCustomXmlFieldSpecified;
			}
			set
			{
				this.displacedByCustomXmlFieldSpecified = value;
			}
		}

		// Token: 0x04000644 RID: 1604
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml displacedByCustomXmlField;

		// Token: 0x04000645 RID: 1605
		private bool displacedByCustomXmlFieldSpecified;
	}
}
