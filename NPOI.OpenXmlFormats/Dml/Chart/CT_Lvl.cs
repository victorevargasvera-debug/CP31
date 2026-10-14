using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046A RID: 1130
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Lvl
	{
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00072008 File Offset: 0x00070208
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00072010 File Offset: 0x00070210
		[global::System.Xml.Serialization.XmlElement("pt", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> pt
		{
			get
			{
				return this.ptField;
			}
			set
			{
				this.ptField = value;
			}
		}

		// Token: 0x04001F7C RID: 8060
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> ptField;
	}
}
