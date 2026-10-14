using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000472 RID: 1138
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ConnectorNonVisual
	{
		// Token: 0x06002D78 RID: 11640 RVA: 0x00072A89 File Offset: 0x00070C89
		public CT_ConnectorNonVisual()
		{
			this.cNvCxnSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties();
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x00072A9C File Offset: 0x00070C9C
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x00072AA4 File Offset: 0x00070CA4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPr
		{
			get
			{
				return this.cNvPrField;
			}
			set
			{
				this.cNvPrField = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x00072AAD File Offset: 0x00070CAD
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00072AB5 File Offset: 0x00070CB5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties cNvCxnSpPr
		{
			get
			{
				return this.cNvCxnSpPrField;
			}
			set
			{
				this.cNvCxnSpPrField = value;
			}
		}

		// Token: 0x04001F9D RID: 8093
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001F9E RID: 8094
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties cNvCxnSpPrField;
	}
}
