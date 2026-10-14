using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000EA RID: 234
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Tabs
	{
		// Token: 0x060006A2 RID: 1698 RVA: 0x00015453 File Offset: 0x00013653
		public CT_Tabs()
		{
			this.tabField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop>();
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00015466 File Offset: 0x00013666
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x0001546E File Offset: 0x0001366E
		[global::System.Xml.Serialization.XmlElement("tab", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop> tab
		{
			get
			{
				return this.tabField;
			}
			set
			{
				this.tabField = value;
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00015478 File Offset: 0x00013678
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop AddNewTab()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop ct_TabStop = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop();
			this.tabField.Add(ct_TabStop);
			return ct_TabStop;
		}

		// Token: 0x040005AF RID: 1455
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop> tabField;
	}
}
