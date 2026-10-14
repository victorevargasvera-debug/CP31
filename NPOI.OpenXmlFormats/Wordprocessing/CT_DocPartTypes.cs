using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200007E RID: 126
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartTypes
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0000B089 File Offset: 0x00009289
		public CT_DocPartTypes()
		{
			this.itemsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartType>();
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000B09C File Offset: 0x0000929C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0000B0A4 File Offset: 0x000092A4
		[global::System.Xml.Serialization.XmlElement("type", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartType> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000B0AD File Offset: 0x000092AD
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0000B0B5 File Offset: 0x000092B5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff all
		{
			get
			{
				return this.allField;
			}
			set
			{
				this.allField = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000B0BE File Offset: 0x000092BE
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0000B0C6 File Offset: 0x000092C6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool allSpecified
		{
			get
			{
				return this.allFieldSpecified;
			}
			set
			{
				this.allFieldSpecified = value;
			}
		}

		// Token: 0x04000339 RID: 825
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartType> itemsField;

		// Token: 0x0400033A RID: 826
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff allField;

		// Token: 0x0400033B RID: 827
		private bool allFieldSpecified;
	}
}
