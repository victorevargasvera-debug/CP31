using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046B RID: 1131
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustSplit
	{
		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00072019 File Offset: 0x00070219
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00072021 File Offset: 0x00070221
		[global::System.Xml.Serialization.XmlElement("secondPiePt", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> secondPiePt
		{
			get
			{
				return this.secondPiePtField;
			}
			set
			{
				this.secondPiePtField = value;
			}
		}

		// Token: 0x04001F7D RID: 8061
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> secondPiePtField;
	}
}
