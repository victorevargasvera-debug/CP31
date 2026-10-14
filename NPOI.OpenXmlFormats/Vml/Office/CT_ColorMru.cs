using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000214 RID: 532
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorMru
	{
		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00041A73 File Offset: 0x0003FC73
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x00041A7B File Offset: 0x0003FC7B
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00041A84 File Offset: 0x0003FC84
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00041A8F File Offset: 0x0003FC8F
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x00041A97 File Offset: 0x0003FC97
		[global::System.Xml.Serialization.XmlAttribute]
		public string colors
		{
			get
			{
				return this.colorsField;
			}
			set
			{
				this.colorsField = value;
			}
		}

		// Token: 0x04001144 RID: 4420
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001145 RID: 4421
		private string colorsField;
	}
}
