using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023D RID: 573
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlPicture
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00042FC5 File Offset: 0x000411C5
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00042FCD File Offset: 0x000411CD
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlPictureNonVisual nvPicPr
		{
			get
			{
				return this.nvPicPrField;
			}
			set
			{
				this.nvPicPrField = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00042FD6 File Offset: 0x000411D6
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00042FDE File Offset: 0x000411DE
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00042FE7 File Offset: 0x000411E7
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00042FEF File Offset: 0x000411EF
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00042FF8 File Offset: 0x000411F8
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00043000 File Offset: 0x00041200
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00043009 File Offset: 0x00041209
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x00043011 File Offset: 0x00041211
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x04001229 RID: 4649
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlPictureNonVisual nvPicPrField;

		// Token: 0x0400122A RID: 4650
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x0400122B RID: 4651
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x0400122C RID: 4652
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x0400122D RID: 4653
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
