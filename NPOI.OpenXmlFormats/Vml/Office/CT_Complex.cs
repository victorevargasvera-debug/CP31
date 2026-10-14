using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000229 RID: 553
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Complex
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00042AEE File Offset: 0x00040CEE
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00042AF6 File Offset: 0x00040CF6
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00042AFF File Offset: 0x00040CFF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x040011B2 RID: 4530
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;
	}
}
