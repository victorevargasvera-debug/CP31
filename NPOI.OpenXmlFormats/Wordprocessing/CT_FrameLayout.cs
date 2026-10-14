using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200009E RID: 158
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FrameLayout
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FrameLayout val
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

		// Token: 0x040003CC RID: 972
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FrameLayout valField;
	}
}
