using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200007F RID: 127
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartType
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000B0CF File Offset: 0x000092CF
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000B0D7 File Offset: 0x000092D7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartType val
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

		// Token: 0x0400033C RID: 828
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartType valField;
	}
}
