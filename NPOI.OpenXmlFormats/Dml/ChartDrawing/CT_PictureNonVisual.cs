using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000474 RID: 1140
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureNonVisual
	{
		// Token: 0x06002D88 RID: 11656 RVA: 0x00072B2D File Offset: 0x00070D2D
		public CT_PictureNonVisual()
		{
			this.cNvPicPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties();
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x00072B40 File Offset: 0x00070D40
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00072B48 File Offset: 0x00070D48
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

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00072B51 File Offset: 0x00070D51
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00072B59 File Offset: 0x00070D59
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties cNvPicPr
		{
			get
			{
				return this.cNvPicPrField;
			}
			set
			{
				this.cNvPicPrField = value;
			}
		}

		// Token: 0x04001FA4 RID: 8100
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001FA5 RID: 8101
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties cNvPicPrField;
	}
}
