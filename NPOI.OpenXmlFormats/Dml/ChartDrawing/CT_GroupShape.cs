using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000479 RID: 1145
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupShape
	{
		// Token: 0x06002DAF RID: 11695 RVA: 0x00072CDC File Offset: 0x00070EDC
		public CT_GroupShape()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.grpSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties();
			this.nvGrpSpPrField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GroupShapeNonVisual();
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00072D05 File Offset: 0x00070F05
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x00072D0D File Offset: 0x00070F0D
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GroupShapeNonVisual nvGrpSpPr
		{
			get
			{
				return this.nvGrpSpPrField;
			}
			set
			{
				this.nvGrpSpPrField = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00072D16 File Offset: 0x00070F16
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x00072D1E File Offset: 0x00070F1E
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPr
		{
			get
			{
				return this.grpSpPrField;
			}
			set
			{
				this.grpSpPrField = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x00072D27 File Offset: 0x00070F27
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x00072D2F File Offset: 0x00070F2F
		[global::System.Xml.Serialization.XmlElement("cxnSp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Connector), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("graphicFrame", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GraphicFrame), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("grpSp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GroupShape), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("pic", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Picture), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("sp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Shape), Order = 2)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x04001FB5 RID: 8117
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GroupShapeNonVisual nvGrpSpPrField;

		// Token: 0x04001FB6 RID: 8118
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPrField;

		// Token: 0x04001FB7 RID: 8119
		private global::System.Collections.Generic.List<object> itemsField;
	}
}
