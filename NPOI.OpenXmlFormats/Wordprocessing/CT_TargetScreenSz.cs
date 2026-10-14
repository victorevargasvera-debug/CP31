using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000108 RID: 264
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TargetScreenSz
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x000161CC File Offset: 0x000143CC
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x000161D4 File Offset: 0x000143D4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TargetScreenSz val
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

		// Token: 0x04000654 RID: 1620
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TargetScreenSz valField;
	}
}
