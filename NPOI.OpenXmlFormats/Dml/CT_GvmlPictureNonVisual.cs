using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023C RID: 572
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlPictureNonVisual
	{
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00042FA3 File Offset: 0x000411A3
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00042FAB File Offset: 0x000411AB
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

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00042FB4 File Offset: 0x000411B4
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x00042FBC File Offset: 0x000411BC
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

		// Token: 0x04001227 RID: 4647
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001228 RID: 4648
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties cNvPicPrField;
	}
}
