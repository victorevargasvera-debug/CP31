using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200006D RID: 109
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SmartTagPr
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00009BF1 File Offset: 0x00007DF1
		public CT_SmartTagPr()
		{
			this.attrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr>();
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00009C04 File Offset: 0x00007E04
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00009C0C File Offset: 0x00007E0C
		[global::System.Xml.Serialization.XmlElement("attr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr> attr
		{
			get
			{
				return this.attrField;
			}
			set
			{
				this.attrField = value;
			}
		}

		// Token: 0x040002BE RID: 702
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr> attrField;
	}
}
