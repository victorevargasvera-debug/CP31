using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000470 RID: 1136
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeNonVisual
	{
		// Token: 0x06002D62 RID: 11618 RVA: 0x00072974 File Offset: 0x00070B74
		public CT_ShapeNonVisual()
		{
			this.cNvSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps();
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps();
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00072992 File Offset: 0x00070B92
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x0007299A File Offset: 0x00070B9A
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

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000729A3 File Offset: 0x00070BA3
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000729AB File Offset: 0x00070BAB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps cNvSpPr
		{
			get
			{
				return this.cNvSpPrField;
			}
			set
			{
				this.cNvSpPrField = value;
			}
		}

		// Token: 0x04001F93 RID: 8083
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001F94 RID: 8084
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps cNvSpPrField;
	}
}
