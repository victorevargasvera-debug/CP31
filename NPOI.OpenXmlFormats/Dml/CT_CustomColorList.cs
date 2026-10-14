using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200027E RID: 638
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomColorList
	{
		// Token: 0x06001A6B RID: 6763 RVA: 0x0004792E File Offset: 0x00045B2E
		public CT_CustomColorList()
		{
			this.custClrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor>();
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00047941 File Offset: 0x00045B41
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x00047949 File Offset: 0x00045B49
		[global::System.Xml.Serialization.XmlElement("custClr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor> custClr
		{
			get
			{
				return this.custClrField;
			}
			set
			{
				this.custClrField = value;
			}
		}

		// Token: 0x040013BF RID: 5055
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor> custClrField;
	}
}
