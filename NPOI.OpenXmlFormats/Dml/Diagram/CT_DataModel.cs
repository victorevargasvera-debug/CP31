using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000387 RID: 903
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("dataModel", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_DataModel
	{
		// Token: 0x0600240B RID: 9227 RVA: 0x0005D186 File Offset: 0x0005B386
		public CT_DataModel()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.wholeField = new global::NPOI.OpenXmlFormats.Dml.CT_WholeE2oFormatting();
			this.bgField = new global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFormatting();
			this.cxnLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn>();
			this.ptLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt>();
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x0005D1C5 File Offset: 0x0005B3C5
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x0005D1CD File Offset: 0x0005B3CD
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("pt", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt> ptLst
		{
			get
			{
				return this.ptLstField;
			}
			set
			{
				this.ptLstField = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x0005D1D6 File Offset: 0x0005B3D6
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x0005D1DE File Offset: 0x0005B3DE
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("cxn", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn> cxnLst
		{
			get
			{
				return this.cxnLstField;
			}
			set
			{
				this.cxnLstField = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x0005D1E7 File Offset: 0x0005B3E7
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x0005D1EF File Offset: 0x0005B3EF
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFormatting bg
		{
			get
			{
				return this.bgField;
			}
			set
			{
				this.bgField = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x0005D1F8 File Offset: 0x0005B3F8
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x0005D200 File Offset: 0x0005B400
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_WholeE2oFormatting whole
		{
			get
			{
				return this.wholeField;
			}
			set
			{
				this.wholeField = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0005D209 File Offset: 0x0005B409
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x0005D211 File Offset: 0x0005B411
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

		// Token: 0x04001AAE RID: 6830
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt> ptLstField;

		// Token: 0x04001AAF RID: 6831
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn> cxnLstField;

		// Token: 0x04001AB0 RID: 6832
		private global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFormatting bgField;

		// Token: 0x04001AB1 RID: 6833
		private global::NPOI.OpenXmlFormats.Dml.CT_WholeE2oFormatting wholeField;

		// Token: 0x04001AB2 RID: 6834
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
