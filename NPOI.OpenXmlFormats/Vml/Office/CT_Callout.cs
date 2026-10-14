using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000211 RID: 529
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Callout
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x0004140B File Offset: 0x0003F60B
		public CT_Callout()
		{
			this.lengthspecifiedField = global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.f;
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0004141A File Offset: 0x0003F61A
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00041422 File Offset: 0x0003F622
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0004142B File Offset: 0x0003F62B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00041436 File Offset: 0x0003F636
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0004143E File Offset: 0x0003F63E
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00041447 File Offset: 0x0003F647
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0004144F File Offset: 0x0003F64F
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00041458 File Offset: 0x0003F658
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x00041460 File Offset: 0x0003F660
		[global::System.Xml.Serialization.XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00041469 File Offset: 0x0003F669
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00041471 File Offset: 0x0003F671
		[global::System.Xml.Serialization.XmlAttribute]
		public string gap
		{
			get
			{
				return this.gapField;
			}
			set
			{
				this.gapField = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0004147A File Offset: 0x0003F67A
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x00041482 File Offset: 0x0003F682
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_Angle angle
		{
			get
			{
				return this.angleField;
			}
			set
			{
				this.angleField = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0004148B File Offset: 0x0003F68B
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00041493 File Offset: 0x0003F693
		[global::System.Xml.Serialization.XmlIgnore]
		public bool angleSpecified
		{
			get
			{
				return this.angleFieldSpecified;
			}
			set
			{
				this.angleFieldSpecified = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0004149C File Offset: 0x0003F69C
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x000414A4 File Offset: 0x0003F6A4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse dropauto
		{
			get
			{
				return this.dropautoField;
			}
			set
			{
				this.dropautoField = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000414AD File Offset: 0x0003F6AD
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x000414B5 File Offset: 0x0003F6B5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dropautoSpecified
		{
			get
			{
				return this.dropautoFieldSpecified;
			}
			set
			{
				this.dropautoFieldSpecified = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x000414BE File Offset: 0x0003F6BE
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x000414C6 File Offset: 0x0003F6C6
		[global::System.Xml.Serialization.XmlAttribute]
		public string drop
		{
			get
			{
				return this.dropField;
			}
			set
			{
				this.dropField = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000414CF File Offset: 0x0003F6CF
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x000414D7 File Offset: 0x0003F6D7
		[global::System.Xml.Serialization.XmlAttribute]
		public string distance
		{
			get
			{
				return this.distanceField;
			}
			set
			{
				this.distanceField = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x000414E0 File Offset: 0x0003F6E0
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x000414E8 File Offset: 0x0003F6E8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.f)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lengthspecified
		{
			get
			{
				return this.lengthspecifiedField;
			}
			set
			{
				this.lengthspecifiedField = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x000414F1 File Offset: 0x0003F6F1
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x000414F9 File Offset: 0x0003F6F9
		[global::System.Xml.Serialization.XmlAttribute]
		public string length
		{
			get
			{
				return this.lengthField;
			}
			set
			{
				this.lengthField = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00041502 File Offset: 0x0003F702
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x0004150A File Offset: 0x0003F70A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse accentbar
		{
			get
			{
				return this.accentbarField;
			}
			set
			{
				this.accentbarField = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00041513 File Offset: 0x0003F713
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x0004151B File Offset: 0x0003F71B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accentbarSpecified
		{
			get
			{
				return this.accentbarFieldSpecified;
			}
			set
			{
				this.accentbarFieldSpecified = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00041524 File Offset: 0x0003F724
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0004152C File Offset: 0x0003F72C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse textborder
		{
			get
			{
				return this.textborderField;
			}
			set
			{
				this.textborderField = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00041535 File Offset: 0x0003F735
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0004153D File Offset: 0x0003F73D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool textborderSpecified
		{
			get
			{
				return this.textborderFieldSpecified;
			}
			set
			{
				this.textborderFieldSpecified = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00041546 File Offset: 0x0003F746
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x0004154E File Offset: 0x0003F74E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse minusx
		{
			get
			{
				return this.minusxField;
			}
			set
			{
				this.minusxField = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00041557 File Offset: 0x0003F757
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0004155F File Offset: 0x0003F75F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minusxSpecified
		{
			get
			{
				return this.minusxFieldSpecified;
			}
			set
			{
				this.minusxFieldSpecified = value;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00041568 File Offset: 0x0003F768
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00041570 File Offset: 0x0003F770
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse minusy
		{
			get
			{
				return this.minusyField;
			}
			set
			{
				this.minusyField = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00041579 File Offset: 0x0003F779
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00041581 File Offset: 0x0003F781
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minusySpecified
		{
			get
			{
				return this.minusyFieldSpecified;
			}
			set
			{
				this.minusyFieldSpecified = value;
			}
		}

		// Token: 0x04001111 RID: 4369
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001112 RID: 4370
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse onField;

		// Token: 0x04001113 RID: 4371
		private bool onFieldSpecified;

		// Token: 0x04001114 RID: 4372
		private string typeField;

		// Token: 0x04001115 RID: 4373
		private string gapField;

		// Token: 0x04001116 RID: 4374
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_Angle angleField;

		// Token: 0x04001117 RID: 4375
		private bool angleFieldSpecified;

		// Token: 0x04001118 RID: 4376
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse dropautoField;

		// Token: 0x04001119 RID: 4377
		private bool dropautoFieldSpecified;

		// Token: 0x0400111A RID: 4378
		private string dropField;

		// Token: 0x0400111B RID: 4379
		private string distanceField;

		// Token: 0x0400111C RID: 4380
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lengthspecifiedField;

		// Token: 0x0400111D RID: 4381
		private string lengthField;

		// Token: 0x0400111E RID: 4382
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse accentbarField;

		// Token: 0x0400111F RID: 4383
		private bool accentbarFieldSpecified;

		// Token: 0x04001120 RID: 4384
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse textborderField;

		// Token: 0x04001121 RID: 4385
		private bool textborderFieldSpecified;

		// Token: 0x04001122 RID: 4386
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse minusxField;

		// Token: 0x04001123 RID: 4387
		private bool minusxFieldSpecified;

		// Token: 0x04001124 RID: 4388
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse minusyField;

		// Token: 0x04001125 RID: 4389
		private bool minusyFieldSpecified;
	}
}
