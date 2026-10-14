using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000089 RID: 137
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Pitch
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000B3E9 File Offset: 0x000095E9
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000B3F1 File Offset: 0x000095F1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Pitch val
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

		// Token: 0x0400036C RID: 876
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Pitch valField;
	}
}
