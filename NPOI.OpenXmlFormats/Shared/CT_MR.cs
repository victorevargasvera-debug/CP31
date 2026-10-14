using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066D RID: 1645
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MR
	{
		// Token: 0x06004668 RID: 18024 RVA: 0x000A9111 File Offset: 0x000A7311
		public CT_MR()
		{
			this.eField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg>();
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x000A9124 File Offset: 0x000A7324
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x000A912C File Offset: 0x000A732C
		[global::System.Xml.Serialization.XmlElement("e", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> e
		{
			get
			{
				return this.eField;
			}
			set
			{
				this.eField = value;
			}
		}

		// Token: 0x04002C18 RID: 11288
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> eField;
	}
}
