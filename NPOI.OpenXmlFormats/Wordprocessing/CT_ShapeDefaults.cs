using System;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A0 RID: 416
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeDefaults
	{
		// Token: 0x06000FB4 RID: 4020 RVA: 0x00032C33 File Offset: 0x00030E33
		public CT_ShapeDefaults()
		{
			this.itemsField = new global::System.Xml.XmlElement[0];
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00032C47 File Offset: 0x00030E47
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00032C4F File Offset: 0x00030E4F
		[global::System.Xml.Serialization.XmlAnyElement(Namespace = "urn:schemas-microsoft-com:office:office", Order = 0)]
		public global::System.Xml.XmlElement[] Items
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

		// Token: 0x04000CBB RID: 3259
		private global::System.Xml.XmlElement[] itemsField;
	}
}
