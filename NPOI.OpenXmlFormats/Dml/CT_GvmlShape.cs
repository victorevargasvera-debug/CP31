using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000239 RID: 569
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlShape
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00042EE8 File Offset: 0x000410E8
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00042EF0 File Offset: 0x000410F0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlShapeNonVisual nvSpPr
		{
			get
			{
				return this.nvSpPrField;
			}
			set
			{
				this.nvSpPrField = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00042EF9 File Offset: 0x000410F9
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00042F01 File Offset: 0x00041101
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00042F0A File Offset: 0x0004110A
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00042F12 File Offset: 0x00041112
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlTextShape txSp
		{
			get
			{
				return this.txSpField;
			}
			set
			{
				this.txSpField = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00042F1B File Offset: 0x0004111B
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x00042F23 File Offset: 0x00041123
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00042F2C File Offset: 0x0004112C
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00042F34 File Offset: 0x00041134
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

		// Token: 0x0400121C RID: 4636
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlShapeNonVisual nvSpPrField;

		// Token: 0x0400121D RID: 4637
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x0400121E RID: 4638
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlTextShape txSpField;

		// Token: 0x0400121F RID: 4639
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001220 RID: 4640
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
