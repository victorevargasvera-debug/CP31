using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200022B RID: 555
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ClipPath
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00042DF0 File Offset: 0x00040FF0
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00042DF8 File Offset: 0x00040FF8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x040011DE RID: 4574
		private string vField;
	}
}
