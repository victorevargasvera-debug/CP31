using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023F RID: 575
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlGraphicalObjectFrame
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0004303C File Offset: 0x0004123C
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x00043044 File Offset: 0x00041244
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlGraphicFrameNonVisual nvGraphicFramePr
		{
			get
			{
				return this.nvGraphicFramePrField;
			}
			set
			{
				this.nvGraphicFramePrField = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0004304D File Offset: 0x0004124D
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x00043055 File Offset: 0x00041255
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphic
		{
			get
			{
				return this.graphicField;
			}
			set
			{
				this.graphicField = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0004305E File Offset: 0x0004125E
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x00043066 File Offset: 0x00041266
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrm
		{
			get
			{
				return this.xfrmField;
			}
			set
			{
				this.xfrmField = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0004306F File Offset: 0x0004126F
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x00043077 File Offset: 0x00041277
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04001230 RID: 4656
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlGraphicFrameNonVisual nvGraphicFramePrField;

		// Token: 0x04001231 RID: 4657
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphicField;

		// Token: 0x04001232 RID: 4658
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x04001233 RID: 4659
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
