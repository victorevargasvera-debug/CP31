using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000216 RID: 534
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Ink
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00041B00 File Offset: 0x0003FD00
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x00041B08 File Offset: 0x0003FD08
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00041B11 File Offset: 0x0003FD11
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00041B19 File Offset: 0x0003FD19
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse annotation
		{
			get
			{
				return this.annotationField;
			}
			set
			{
				this.annotationField = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00041B22 File Offset: 0x0003FD22
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00041B2A File Offset: 0x0003FD2A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool annotationSpecified
		{
			get
			{
				return this.annotationFieldSpecified;
			}
			set
			{
				this.annotationFieldSpecified = value;
			}
		}

		// Token: 0x0400114B RID: 4427
		private byte[] iField;

		// Token: 0x0400114C RID: 4428
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse annotationField;

		// Token: 0x0400114D RID: 4429
		private bool annotationFieldSpecified;
	}
}
