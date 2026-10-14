using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200001C RID: 28
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/characteristics")]
	[global::System.Serializable]
	public class CT_Characteristic
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00003188 File Offset: 0x00001388
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00003191 File Offset: 0x00001391
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00003199 File Offset: 0x00001399
		public global::NPOI.OpenXmlFormats.ST_Relation relation
		{
			get
			{
				return this.relationField;
			}
			set
			{
				this.relationField = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000031A2 File Offset: 0x000013A2
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000031AA File Offset: 0x000013AA
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000031B3 File Offset: 0x000013B3
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000031BB File Offset: 0x000013BB
		public string vocabulary
		{
			get
			{
				return this.vocabularyField;
			}
			set
			{
				this.vocabularyField = value;
			}
		}

		// Token: 0x040000BC RID: 188
		private string nameField;

		// Token: 0x040000BD RID: 189
		private global::NPOI.OpenXmlFormats.ST_Relation relationField;

		// Token: 0x040000BE RID: 190
		private string valField;

		// Token: 0x040000BF RID: 191
		private string vocabularyField;
	}
}
