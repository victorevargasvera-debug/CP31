using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046C RID: 1132
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BandFmts
	{
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x0007202A File Offset: 0x0007022A
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x00072032 File Offset: 0x00070232
		[global::System.Xml.Serialization.XmlElement("bandFmt", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt> bandFmt
		{
			get
			{
				return this.bandFmtField;
			}
			set
			{
				this.bandFmtField = value;
			}
		}

		// Token: 0x04001F7E RID: 8062
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt> bandFmtField;
	}
}
