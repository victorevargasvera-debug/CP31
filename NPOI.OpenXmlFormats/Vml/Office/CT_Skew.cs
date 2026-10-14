using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200020A RID: 522
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Skew
	{
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00041075 File Offset: 0x0003F275
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0004107D File Offset: 0x0003F27D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x00041086 File Offset: 0x0003F286
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00041091 File Offset: 0x0003F291
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00041099 File Offset: 0x0003F299
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000410A2 File Offset: 0x0003F2A2
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000410AA File Offset: 0x0003F2AA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x000410B3 File Offset: 0x0003F2B3
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000410BB File Offset: 0x0003F2BB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000410C4 File Offset: 0x0003F2C4
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x000410CC File Offset: 0x0003F2CC
		[global::System.Xml.Serialization.XmlAttribute]
		public string offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000410D5 File Offset: 0x0003F2D5
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x000410DD File Offset: 0x0003F2DD
		[global::System.Xml.Serialization.XmlAttribute]
		public string origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000410E6 File Offset: 0x0003F2E6
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000410EE File Offset: 0x0003F2EE
		[global::System.Xml.Serialization.XmlAttribute]
		public string matrix
		{
			get
			{
				return this.matrixField;
			}
			set
			{
				this.matrixField = value;
			}
		}

		// Token: 0x040010CB RID: 4299
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x040010CC RID: 4300
		private string idField;

		// Token: 0x040010CD RID: 4301
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse onField;

		// Token: 0x040010CE RID: 4302
		private bool onFieldSpecified;

		// Token: 0x040010CF RID: 4303
		private string offsetField;

		// Token: 0x040010D0 RID: 4304
		private string originField;

		// Token: 0x040010D1 RID: 4305
		private string matrixField;
	}
}
