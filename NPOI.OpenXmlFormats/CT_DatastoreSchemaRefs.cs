using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200000D RID: 13
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DatastoreSchemaRefs
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002684 File Offset: 0x00000884
		public CT_DatastoreSchemaRefs()
		{
			this.schemaRefField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef>();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002697 File Offset: 0x00000897
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000269F File Offset: 0x0000089F
		[global::System.Xml.Serialization.XmlElement("schemaRef")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef> schemaRef
		{
			get
			{
				return this.schemaRefField;
			}
			set
			{
				this.schemaRefField = value;
			}
		}

		// Token: 0x0400004B RID: 75
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef> schemaRefField;
	}
}
