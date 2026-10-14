using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000DD RID: 221
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtEndPr
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x00013CB8 File Offset: 0x00011EB8
		public CT_SdtEndPr()
		{
			this.itemsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr>();
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00013CCB File Offset: 0x00011ECB
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00013CD3 File Offset: 0x00011ED3
		[global::System.Xml.Serialization.XmlElement("rPr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> Items
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

		// Token: 0x06000656 RID: 1622 RVA: 0x00013CDC File Offset: 0x00011EDC
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr AddNewRPr()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			this.itemsField.Add(ct_RPr);
			return ct_RPr;
		}

		// Token: 0x04000564 RID: 1380
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> itemsField;
	}
}
