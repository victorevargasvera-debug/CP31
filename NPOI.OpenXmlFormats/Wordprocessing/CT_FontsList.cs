using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000085 RID: 133
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("fonts", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_FontsList
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x0000B25A File Offset: 0x0000945A
		public CT_FontsList()
		{
			this.fontField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Font>();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000B26D File Offset: 0x0000946D
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0000B275 File Offset: 0x00009475
		[global::System.Xml.Serialization.XmlElement("font", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Font> font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x04000357 RID: 855
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Font> fontField;
	}
}
