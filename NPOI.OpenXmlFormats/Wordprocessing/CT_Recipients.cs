using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000F2 RID: 242
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("recipients", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Recipients
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x000157BE File Offset: 0x000139BE
		public CT_Recipients()
		{
			this.recipientDataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RecipientData>();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000157D1 File Offset: 0x000139D1
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000157D9 File Offset: 0x000139D9
		[global::System.Xml.Serialization.XmlElement("recipientData", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RecipientData> recipientData
		{
			get
			{
				return this.recipientDataField;
			}
			set
			{
				this.recipientDataField = value;
			}
		}

		// Token: 0x040005D3 RID: 1491
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RecipientData> recipientDataField;
	}
}
