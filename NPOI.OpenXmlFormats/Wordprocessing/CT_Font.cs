using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000086 RID: 134
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Font
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x0000B280 File Offset: 0x00009480
		public CT_Font()
		{
			this.embedBoldItalicField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel();
			this.embedItalicField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel();
			this.embedBoldField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel();
			this.embedRegularField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel();
			this.sigField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontSig();
			this.pitchField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Pitch();
			this.notTrueTypeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.familyField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontFamily();
			this.charsetField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_UcharHexNumber();
			this.panose1Field = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Panose();
			this.altNameField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000B30C File Offset: 0x0000950C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0000B314 File Offset: 0x00009514
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String altName
		{
			get
			{
				return this.altNameField;
			}
			set
			{
				this.altNameField = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000B31D File Offset: 0x0000951D
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000B325 File Offset: 0x00009525
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Panose panose1
		{
			get
			{
				return this.panose1Field;
			}
			set
			{
				this.panose1Field = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000B32E File Offset: 0x0000952E
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000B336 File Offset: 0x00009536
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_UcharHexNumber charset
		{
			get
			{
				return this.charsetField;
			}
			set
			{
				this.charsetField = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000B33F File Offset: 0x0000953F
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000B347 File Offset: 0x00009547
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontFamily family
		{
			get
			{
				return this.familyField;
			}
			set
			{
				this.familyField = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000B350 File Offset: 0x00009550
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000B358 File Offset: 0x00009558
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff notTrueType
		{
			get
			{
				return this.notTrueTypeField;
			}
			set
			{
				this.notTrueTypeField = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000B361 File Offset: 0x00009561
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0000B369 File Offset: 0x00009569
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Pitch pitch
		{
			get
			{
				return this.pitchField;
			}
			set
			{
				this.pitchField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000B372 File Offset: 0x00009572
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000B37A File Offset: 0x0000957A
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontSig sig
		{
			get
			{
				return this.sigField;
			}
			set
			{
				this.sigField = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000B383 File Offset: 0x00009583
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000B38B File Offset: 0x0000958B
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedRegular
		{
			get
			{
				return this.embedRegularField;
			}
			set
			{
				this.embedRegularField = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000B394 File Offset: 0x00009594
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000B39C File Offset: 0x0000959C
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedBold
		{
			get
			{
				return this.embedBoldField;
			}
			set
			{
				this.embedBoldField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000B3A5 File Offset: 0x000095A5
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000B3AD File Offset: 0x000095AD
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedItalic
		{
			get
			{
				return this.embedItalicField;
			}
			set
			{
				this.embedItalicField = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000B3B6 File Offset: 0x000095B6
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000B3BE File Offset: 0x000095BE
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedBoldItalic
		{
			get
			{
				return this.embedBoldItalicField;
			}
			set
			{
				this.embedBoldItalicField = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000B3C7 File Offset: 0x000095C7
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000B3CF File Offset: 0x000095CF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
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

		// Token: 0x04000358 RID: 856
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String altNameField;

		// Token: 0x04000359 RID: 857
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Panose panose1Field;

		// Token: 0x0400035A RID: 858
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_UcharHexNumber charsetField;

		// Token: 0x0400035B RID: 859
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontFamily familyField;

		// Token: 0x0400035C RID: 860
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff notTrueTypeField;

		// Token: 0x0400035D RID: 861
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Pitch pitchField;

		// Token: 0x0400035E RID: 862
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontSig sigField;

		// Token: 0x0400035F RID: 863
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedRegularField;

		// Token: 0x04000360 RID: 864
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedBoldField;

		// Token: 0x04000361 RID: 865
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedItalicField;

		// Token: 0x04000362 RID: 866
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel embedBoldItalicField;

		// Token: 0x04000363 RID: 867
		private string nameField;
	}
}
