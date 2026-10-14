using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000101 RID: 257
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontRel : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00015FCF File Offset: 0x000141CF
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00015FD7 File Offset: 0x000141D7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "token")]
		public string fontKey
		{
			get
			{
				return this.fontKeyField;
			}
			set
			{
				this.fontKeyField = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00015FE0 File Offset: 0x000141E0
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00015FE8 File Offset: 0x000141E8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff subsetted
		{
			get
			{
				return this.subsettedField;
			}
			set
			{
				this.subsettedField = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00015FF1 File Offset: 0x000141F1
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00015FF9 File Offset: 0x000141F9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool subsettedSpecified
		{
			get
			{
				return this.subsettedFieldSpecified;
			}
			set
			{
				this.subsettedFieldSpecified = value;
			}
		}

		// Token: 0x04000638 RID: 1592
		private string fontKeyField;

		// Token: 0x04000639 RID: 1593
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff subsettedField;

		// Token: 0x0400063A RID: 1594
		private bool subsettedFieldSpecified;
	}
}
