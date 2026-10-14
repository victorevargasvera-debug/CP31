using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200003B RID: 59
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Parameter
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00003B49 File Offset: 0x00001D49
		public CT_Parameter()
		{
			this.sqlTypeField = 0;
			this.parameterTypeField = global::NPOI.OpenXmlFormats.ST_ParameterType.prompt;
			this.refreshOnChangeField = false;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00003B66 File Offset: 0x00001D66
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00003B6E File Offset: 0x00001D6E
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00003B77 File Offset: 0x00001D77
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00003B7F File Offset: 0x00001D7F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int sqlType
		{
			get
			{
				return this.sqlTypeField;
			}
			set
			{
				this.sqlTypeField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00003B88 File Offset: 0x00001D88
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00003B90 File Offset: 0x00001D90
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_ParameterType.prompt)]
		public global::NPOI.OpenXmlFormats.ST_ParameterType parameterType
		{
			get
			{
				return this.parameterTypeField;
			}
			set
			{
				this.parameterTypeField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00003B99 File Offset: 0x00001D99
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00003BA1 File Offset: 0x00001DA1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshOnChange
		{
			get
			{
				return this.refreshOnChangeField;
			}
			set
			{
				this.refreshOnChangeField = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00003BAA File Offset: 0x00001DAA
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00003BB2 File Offset: 0x00001DB2
		[global::System.Xml.Serialization.XmlAttribute]
		public string prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00003BBB File Offset: 0x00001DBB
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00003BC3 File Offset: 0x00001DC3
		[global::System.Xml.Serialization.XmlAttribute]
		public bool boolean
		{
			get
			{
				return this.booleanField;
			}
			set
			{
				this.booleanField = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00003BD4 File Offset: 0x00001DD4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool booleanSpecified
		{
			get
			{
				return this.booleanFieldSpecified;
			}
			set
			{
				this.booleanFieldSpecified = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00003BDD File Offset: 0x00001DDD
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00003BE5 File Offset: 0x00001DE5
		[global::System.Xml.Serialization.XmlAttribute]
		public double @double
		{
			get
			{
				return this.doubleField;
			}
			set
			{
				this.doubleField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00003BEE File Offset: 0x00001DEE
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00003BF6 File Offset: 0x00001DF6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool doubleSpecified
		{
			get
			{
				return this.doubleFieldSpecified;
			}
			set
			{
				this.doubleFieldSpecified = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00003BFF File Offset: 0x00001DFF
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00003C07 File Offset: 0x00001E07
		[global::System.Xml.Serialization.XmlAttribute]
		public int integer
		{
			get
			{
				return this.integerField;
			}
			set
			{
				this.integerField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00003C10 File Offset: 0x00001E10
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00003C18 File Offset: 0x00001E18
		[global::System.Xml.Serialization.XmlIgnore]
		public bool integerSpecified
		{
			get
			{
				return this.integerFieldSpecified;
			}
			set
			{
				this.integerFieldSpecified = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00003C21 File Offset: 0x00001E21
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00003C29 File Offset: 0x00001E29
		[global::System.Xml.Serialization.XmlAttribute]
		public string @string
		{
			get
			{
				return this.stringField;
			}
			set
			{
				this.stringField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00003C32 File Offset: 0x00001E32
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00003C3A File Offset: 0x00001E3A
		[global::System.Xml.Serialization.XmlAttribute]
		public string cell
		{
			get
			{
				return this.cellField;
			}
			set
			{
				this.cellField = value;
			}
		}

		// Token: 0x04000189 RID: 393
		private string nameField;

		// Token: 0x0400018A RID: 394
		private int sqlTypeField;

		// Token: 0x0400018B RID: 395
		private global::NPOI.OpenXmlFormats.ST_ParameterType parameterTypeField;

		// Token: 0x0400018C RID: 396
		private bool refreshOnChangeField;

		// Token: 0x0400018D RID: 397
		private string promptField;

		// Token: 0x0400018E RID: 398
		private bool booleanField;

		// Token: 0x0400018F RID: 399
		private bool booleanFieldSpecified;

		// Token: 0x04000190 RID: 400
		private double doubleField;

		// Token: 0x04000191 RID: 401
		private bool doubleFieldSpecified;

		// Token: 0x04000192 RID: 402
		private int integerField;

		// Token: 0x04000193 RID: 403
		private bool integerFieldSpecified;

		// Token: 0x04000194 RID: 404
		private string stringField;

		// Token: 0x04000195 RID: 405
		private string cellField;
	}
}
