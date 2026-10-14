using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200007D RID: 125
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartName
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000B056 File Offset: 0x00009256
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000B05E File Offset: 0x0000925E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000B067 File Offset: 0x00009267
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000B06F File Offset: 0x0000926F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff decorated
		{
			get
			{
				return this.decoratedField;
			}
			set
			{
				this.decoratedField = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000B078 File Offset: 0x00009278
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000B080 File Offset: 0x00009280
		[global::System.Xml.Serialization.XmlIgnore]
		public bool decoratedSpecified
		{
			get
			{
				return this.decoratedFieldSpecified;
			}
			set
			{
				this.decoratedFieldSpecified = value;
			}
		}

		// Token: 0x04000336 RID: 822
		private string valField;

		// Token: 0x04000337 RID: 823
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff decoratedField;

		// Token: 0x04000338 RID: 824
		private bool decoratedFieldSpecified;
	}
}
