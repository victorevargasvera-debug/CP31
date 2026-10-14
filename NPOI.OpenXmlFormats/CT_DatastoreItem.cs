using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200000B RID: 11
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DatastoreItem
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000263E File Offset: 0x0000083E
		public CT_DatastoreItem()
		{
			this.schemaRefsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef>();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002651 File Offset: 0x00000851
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002659 File Offset: 0x00000859
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("schemaRef", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef> schemaRefs
		{
			get
			{
				return this.schemaRefsField;
			}
			set
			{
				this.schemaRefsField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002662 File Offset: 0x00000862
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000266A File Offset: 0x0000086A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "token")]
		public string itemID
		{
			get
			{
				return this.itemIDField;
			}
			set
			{
				this.itemIDField = value;
			}
		}

		// Token: 0x04000048 RID: 72
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_DatastoreSchemaRef> schemaRefsField;

		// Token: 0x04000049 RID: 73
		private string itemIDField;
	}
}
