using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200023B RID: 571
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlConnector
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00042F5F File Offset: 0x0004115F
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00042F67 File Offset: 0x00041167
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlConnectorNonVisual nvCxnSpPr
		{
			get
			{
				return this.nvCxnSpPrField;
			}
			set
			{
				this.nvCxnSpPrField = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00042F70 File Offset: 0x00041170
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00042F78 File Offset: 0x00041178
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00042F81 File Offset: 0x00041181
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00042F89 File Offset: 0x00041189
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00042F92 File Offset: 0x00041192
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00042F9A File Offset: 0x0004119A
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

		// Token: 0x04001223 RID: 4643
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlConnectorNonVisual nvCxnSpPrField;

		// Token: 0x04001224 RID: 4644
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x04001225 RID: 4645
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001226 RID: 4646
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
