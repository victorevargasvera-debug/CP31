using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000478 RID: 1144
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupShapeNonVisual
	{
		// Token: 0x06002DAA RID: 11690 RVA: 0x00072CA7 File Offset: 0x00070EA7
		public CT_GroupShapeNonVisual()
		{
			this.cNvGrpSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps();
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x00072CBA File Offset: 0x00070EBA
		// (set) Token: 0x06002DAC RID: 11692 RVA: 0x00072CC2 File Offset: 0x00070EC2
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

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x00072CCB File Offset: 0x00070ECB
		// (set) Token: 0x06002DAE RID: 11694 RVA: 0x00072CD3 File Offset: 0x00070ED3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps cNvGrpSpPr
		{
			get
			{
				return this.cNvGrpSpPrField;
			}
			set
			{
				this.cNvGrpSpPrField = value;
			}
		}

		// Token: 0x04001FB3 RID: 8115
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001FB4 RID: 8116
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps cNvGrpSpPrField;
	}
}
