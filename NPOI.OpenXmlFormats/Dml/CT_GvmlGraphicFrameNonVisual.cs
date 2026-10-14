using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023E RID: 574
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlGraphicFrameNonVisual
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x0004301A File Offset: 0x0004121A
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x00043022 File Offset: 0x00041222
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

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0004302B File Offset: 0x0004122B
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x00043033 File Offset: 0x00041233
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

		// Token: 0x0400122E RID: 4654
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x0400122F RID: 4655
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;
	}
}
