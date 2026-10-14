using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000A1 RID: 161
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FrameScrollbar
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000CEAB File Offset: 0x0000B0AB
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FrameScrollbar val
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

		// Token: 0x040003D9 RID: 985
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FrameScrollbar valField;
	}
}
