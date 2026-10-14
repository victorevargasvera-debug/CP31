using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000078 RID: 120
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartBehavior
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000AFF4 File Offset: 0x000091F4
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0000AFFC File Offset: 0x000091FC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartBehavior val
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

		// Token: 0x04000307 RID: 775
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartBehavior valField;
	}
}
