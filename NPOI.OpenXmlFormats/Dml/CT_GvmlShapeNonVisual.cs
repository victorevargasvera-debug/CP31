using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000238 RID: 568
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlShapeNonVisual
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00042EC6 File Offset: 0x000410C6
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00042ECE File Offset: 0x000410CE
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00042ED7 File Offset: 0x000410D7
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00042EDF File Offset: 0x000410DF
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

		// Token: 0x0400121A RID: 4634
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x0400121B RID: 4635
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps cNvSpPrField;
	}
}
