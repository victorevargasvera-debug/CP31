using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046D RID: 1133
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PivotFmts
	{
		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0007203B File Offset: 0x0007023B
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00072043 File Offset: 0x00070243
		[global::System.Xml.Serialization.XmlElement("pivotFmt", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt> pivotFmt
		{
			get
			{
				return this.pivotFmtField;
			}
			set
			{
				this.pivotFmtField = value;
			}
		}

		// Token: 0x04001F7F RID: 8063
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt> pivotFmtField;
	}
}
