using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023A RID: 570
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlConnectorNonVisual
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00042F3D File Offset: 0x0004113D
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00042F45 File Offset: 0x00041145
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00042F4E File Offset: 0x0004114E
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x00042F56 File Offset: 0x00041156
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

		// Token: 0x04001221 RID: 4641
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001222 RID: 4642
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties cNvCxnSpPrField;
	}
}
