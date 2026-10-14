using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000F3 RID: 243
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RecipientData
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x000157E2 File Offset: 0x000139E2
		public CT_RecipientData()
		{
			this.columnField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.activeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00015800 File Offset: 0x00013A00
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00015808 File Offset: 0x00013A08
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00015811 File Offset: 0x00013A11
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00015819 File Offset: 0x00013A19
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber column
		{
			get
			{
				return this.columnField;
			}
			set
			{
				this.columnField = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00015822 File Offset: 0x00013A22
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0001582A File Offset: 0x00013A2A
		[global::System.Xml.Serialization.XmlElement(DataType = "base64Binary", Order = 2)]
		public byte[] uniqueTag
		{
			get
			{
				return this.uniqueTagField;
			}
			set
			{
				this.uniqueTagField = value;
			}
		}

		// Token: 0x040005D4 RID: 1492
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff activeField;

		// Token: 0x040005D5 RID: 1493
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber columnField;

		// Token: 0x040005D6 RID: 1494
		private byte[] uniqueTagField;
	}
}
