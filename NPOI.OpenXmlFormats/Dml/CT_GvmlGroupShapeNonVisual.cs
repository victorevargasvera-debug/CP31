using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000240 RID: 576
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlGroupShapeNonVisual
	{
		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x00043080 File Offset: 0x00041280
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x00043088 File Offset: 0x00041288
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

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00043091 File Offset: 0x00041291
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x00043099 File Offset: 0x00041299
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

		// Token: 0x04001234 RID: 4660
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001235 RID: 4661
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps cNvGrpSpPrField;
	}
}
