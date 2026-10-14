using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000004 RID: 4
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/schemaLibrary/2006/main")]
	[global::System.Serializable]
	public class CT_SchemaLibrary
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002279 File Offset: 0x00000479
		public CT_SchemaLibrary()
		{
			this.schemaField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema>();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000228C File Offset: 0x0000048C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002294 File Offset: 0x00000494
		[global::System.Xml.Serialization.XmlElement("schema")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema> schema
		{
			get
			{
				return this.schemaField;
			}
			set
			{
				this.schemaField = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema> schemaField;
	}
}
