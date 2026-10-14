using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200007B RID: 123
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartGallery
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000B045 File Offset: 0x00009245
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0000B04D File Offset: 0x0000924D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartGallery val
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

		// Token: 0x0400030E RID: 782
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocPartGallery valField;
	}
}
