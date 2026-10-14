using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000074 RID: 116
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocParts
	{
		// Token: 0x0600036C RID: 876 RVA: 0x0000AF48 File Offset: 0x00009148
		public CT_DocParts()
		{
			this.itemsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPart>();
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000AF5B File Offset: 0x0000915B
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000AF63 File Offset: 0x00009163
		[global::System.Xml.Serialization.XmlElement("docPart", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPart> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x04000301 RID: 769
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPart> itemsField;
	}
}
