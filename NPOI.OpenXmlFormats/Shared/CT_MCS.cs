using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066B RID: 1643
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MCS
	{
		// Token: 0x06004650 RID: 18000 RVA: 0x000A8D48 File Offset: 0x000A6F48
		public CT_MCS()
		{
			this.mcField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC>();
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x000A8D5B File Offset: 0x000A6F5B
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x000A8D63 File Offset: 0x000A6F63
		[global::System.Xml.Serialization.XmlElement("mc", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC> mc
		{
			get
			{
				return this.mcField;
			}
			set
			{
				this.mcField = value;
			}
		}

		// Token: 0x04002C0E RID: 11278
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC> mcField;
	}
}
