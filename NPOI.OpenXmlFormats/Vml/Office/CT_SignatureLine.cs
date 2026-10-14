using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000217 RID: 535
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SignatureLine
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00041B33 File Offset: 0x0003FD33
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00041B3B File Offset: 0x0003FD3B
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

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00041B44 File Offset: 0x0003FD44
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00041B4F File Offset: 0x0003FD4F
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00041B57 File Offset: 0x0003FD57
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse issignatureline
		{
			get
			{
				return this.issignaturelineField;
			}
			set
			{
				this.issignaturelineField = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00041B60 File Offset: 0x0003FD60
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00041B68 File Offset: 0x0003FD68
		[global::System.Xml.Serialization.XmlIgnore]
		public bool issignaturelineSpecified
		{
			get
			{
				return this.issignaturelineFieldSpecified;
			}
			set
			{
				this.issignaturelineFieldSpecified = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00041B71 File Offset: 0x0003FD71
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00041B79 File Offset: 0x0003FD79
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00041B82 File Offset: 0x0003FD82
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00041B8A File Offset: 0x0003FD8A
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string provid
		{
			get
			{
				return this.providField;
			}
			set
			{
				this.providField = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00041B93 File Offset: 0x0003FD93
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00041B9B File Offset: 0x0003FD9B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse signinginstructionsset
		{
			get
			{
				return this.signinginstructionssetField;
			}
			set
			{
				this.signinginstructionssetField = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00041BA4 File Offset: 0x0003FDA4
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00041BAC File Offset: 0x0003FDAC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool signinginstructionssetSpecified
		{
			get
			{
				return this.signinginstructionssetFieldSpecified;
			}
			set
			{
				this.signinginstructionssetFieldSpecified = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00041BB5 File Offset: 0x0003FDB5
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00041BBD File Offset: 0x0003FDBD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse allowcomments
		{
			get
			{
				return this.allowcommentsField;
			}
			set
			{
				this.allowcommentsField = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00041BC6 File Offset: 0x0003FDC6
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00041BCE File Offset: 0x0003FDCE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool allowcommentsSpecified
		{
			get
			{
				return this.allowcommentsFieldSpecified;
			}
			set
			{
				this.allowcommentsFieldSpecified = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00041BD7 File Offset: 0x0003FDD7
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00041BDF File Offset: 0x0003FDDF
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse showsigndate
		{
			get
			{
				return this.showsigndateField;
			}
			set
			{
				this.showsigndateField = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00041BF0 File Offset: 0x0003FDF0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showsigndateSpecified
		{
			get
			{
				return this.showsigndateFieldSpecified;
			}
			set
			{
				this.showsigndateFieldSpecified = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00041BF9 File Offset: 0x0003FDF9
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x00041C01 File Offset: 0x0003FE01
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string suggestedsigner
		{
			get
			{
				return this.suggestedsignerField;
			}
			set
			{
				this.suggestedsignerField = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00041C0A File Offset: 0x0003FE0A
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x00041C12 File Offset: 0x0003FE12
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string suggestedsigner2
		{
			get
			{
				return this.suggestedsigner2Field;
			}
			set
			{
				this.suggestedsigner2Field = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00041C1B File Offset: 0x0003FE1B
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00041C23 File Offset: 0x0003FE23
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string suggestedsigneremail
		{
			get
			{
				return this.suggestedsigneremailField;
			}
			set
			{
				this.suggestedsigneremailField = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00041C2C File Offset: 0x0003FE2C
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00041C34 File Offset: 0x0003FE34
		[global::System.Xml.Serialization.XmlAttribute]
		public string signinginstructions
		{
			get
			{
				return this.signinginstructionsField;
			}
			set
			{
				this.signinginstructionsField = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00041C3D File Offset: 0x0003FE3D
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x00041C45 File Offset: 0x0003FE45
		[global::System.Xml.Serialization.XmlAttribute]
		public string addlxml
		{
			get
			{
				return this.addlxmlField;
			}
			set
			{
				this.addlxmlField = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00041C4E File Offset: 0x0003FE4E
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x00041C56 File Offset: 0x0003FE56
		[global::System.Xml.Serialization.XmlAttribute]
		public string sigprovurl
		{
			get
			{
				return this.sigprovurlField;
			}
			set
			{
				this.sigprovurlField = value;
			}
		}

		// Token: 0x0400114E RID: 4430
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x0400114F RID: 4431
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse issignaturelineField;

		// Token: 0x04001150 RID: 4432
		private bool issignaturelineFieldSpecified;

		// Token: 0x04001151 RID: 4433
		private string idField;

		// Token: 0x04001152 RID: 4434
		private string providField;

		// Token: 0x04001153 RID: 4435
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse signinginstructionssetField;

		// Token: 0x04001154 RID: 4436
		private bool signinginstructionssetFieldSpecified;

		// Token: 0x04001155 RID: 4437
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse allowcommentsField;

		// Token: 0x04001156 RID: 4438
		private bool allowcommentsFieldSpecified;

		// Token: 0x04001157 RID: 4439
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse showsigndateField;

		// Token: 0x04001158 RID: 4440
		private bool showsigndateFieldSpecified;

		// Token: 0x04001159 RID: 4441
		private string suggestedsignerField;

		// Token: 0x0400115A RID: 4442
		private string suggestedsigner2Field;

		// Token: 0x0400115B RID: 4443
		private string suggestedsigneremailField;

		// Token: 0x0400115C RID: 4444
		private string signinginstructionsField;

		// Token: 0x0400115D RID: 4445
		private string addlxmlField;

		// Token: 0x0400115E RID: 4446
		private string sigprovurlField;
	}
}
