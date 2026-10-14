using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000222 RID: 546
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RelationTable
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00042973 File Offset: 0x00040B73
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x0004297B File Offset: 0x00040B7B
		[global::System.Xml.Serialization.XmlElement("rel")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Relation> rel
		{
			get
			{
				return this.relField;
			}
			set
			{
				this.relField = value;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00042984 File Offset: 0x00040B84
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x0004298C File Offset: 0x00040B8C
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00042995 File Offset: 0x00040B95
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x04001190 RID: 4496
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Relation> relField;

		// Token: 0x04001191 RID: 4497
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;
	}
}
