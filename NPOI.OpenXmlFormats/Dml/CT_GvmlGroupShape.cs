using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000241 RID: 577
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlGroupShape
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000430A2 File Offset: 0x000412A2
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x000430AA File Offset: 0x000412AA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GvmlGroupShapeNonVisual nvGrpSpPr
		{
			get
			{
				return this.nvGrpSpPrField;
			}
			set
			{
				this.nvGrpSpPrField = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000430B3 File Offset: 0x000412B3
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x000430BB File Offset: 0x000412BB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPr
		{
			get
			{
				return this.grpSpPrField;
			}
			set
			{
				this.grpSpPrField = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x000430C4 File Offset: 0x000412C4
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x000430CC File Offset: 0x000412CC
		[global::System.Xml.Serialization.XmlElement("cxnSp", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlConnector), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("graphicFrame", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlGraphicalObjectFrame), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("grpSp", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlGroupShape), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("pic", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlPicture), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("sp", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlShape), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("txSp", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlTextShape), Order = 2)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000430D5 File Offset: 0x000412D5
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x000430DD File Offset: 0x000412DD
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

		// Token: 0x04001236 RID: 4662
		private global::NPOI.OpenXmlFormats.Dml.CT_GvmlGroupShapeNonVisual nvGrpSpPrField;

		// Token: 0x04001237 RID: 4663
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPrField;

		// Token: 0x04001238 RID: 4664
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001239 RID: 4665
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
