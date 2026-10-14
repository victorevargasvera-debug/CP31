using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200022C RID: 556
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(TypeName = "CT_Fill", Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot("CT_Fill", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Fill
	{
		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x00042E01 File Offset: 0x00041001
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x00042E09 File Offset: 0x00041009
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00042E12 File Offset: 0x00041012
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00042E1D File Offset: 0x0004101D
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x00042E25 File Offset: 0x00041025
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_FillType1 type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00042E2E File Offset: 0x0004102E
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00042E36 File Offset: 0x00041036
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x040011DF RID: 4575
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x040011E0 RID: 4576
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_FillType1 typeField;

		// Token: 0x040011E1 RID: 4577
		private bool typeFieldSpecified;
	}
}
