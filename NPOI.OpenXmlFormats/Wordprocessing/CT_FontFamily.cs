using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000087 RID: 135
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontFamily
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000B3D8 File Offset: 0x000095D8
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000B3E0 File Offset: 0x000095E0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FontFamily val
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

		// Token: 0x04000364 RID: 868
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FontFamily valField;
	}
}
