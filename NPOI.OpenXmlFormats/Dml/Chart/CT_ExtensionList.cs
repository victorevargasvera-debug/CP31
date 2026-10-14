using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000469 RID: 1129
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExtensionList
	{
		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x00071FF7 File Offset: 0x000701F7
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00071FFF File Offset: 0x000701FF
		[global::System.Xml.Serialization.XmlElement("ext", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> ext
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

		// Token: 0x04001F7B RID: 8059
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extField;
	}
}
