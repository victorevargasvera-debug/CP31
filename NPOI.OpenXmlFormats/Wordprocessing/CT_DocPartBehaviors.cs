using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000077 RID: 119
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartBehaviors
	{
		// Token: 0x06000379 RID: 889 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public CT_DocPartBehaviors()
		{
			this.itemsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartBehavior>();
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000AFE3 File Offset: 0x000091E3
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000AFEB File Offset: 0x000091EB
		[global::System.Xml.Serialization.XmlElement("behavior", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartBehavior> Items
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

		// Token: 0x04000306 RID: 774
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartBehavior> itemsField;
	}
}
