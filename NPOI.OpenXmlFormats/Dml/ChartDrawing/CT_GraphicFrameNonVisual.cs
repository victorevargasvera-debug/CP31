using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000476 RID: 1142
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GraphicFrameNonVisual
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x00072BF8 File Offset: 0x00070DF8
		public CT_GraphicFrameNonVisual()
		{
			this.cNvGraphicFramePrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties();
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00072C0B File Offset: 0x00070E0B
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x00072C13 File Offset: 0x00070E13
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

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x00072C1C File Offset: 0x00070E1C
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x00072C24 File Offset: 0x00070E24
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties cNvGraphicFramePr
		{
			get
			{
				return this.cNvGraphicFramePrField;
			}
			set
			{
				this.cNvGraphicFramePrField = value;
			}
		}

		// Token: 0x04001FAC RID: 8108
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001FAD RID: 8109
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;
	}
}
