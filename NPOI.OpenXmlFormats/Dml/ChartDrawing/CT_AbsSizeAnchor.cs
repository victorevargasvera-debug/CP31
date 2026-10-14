using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x0200047C RID: 1148
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AbsSizeAnchor
	{
		// Token: 0x06002DC2 RID: 11714 RVA: 0x00072DAB File Offset: 0x00070FAB
		public CT_AbsSizeAnchor()
		{
			this.fromField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker();
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x00072DBE File Offset: 0x00070FBE
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00072DC6 File Offset: 0x00070FC6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x00072DCF File Offset: 0x00070FCF
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00072DD7 File Offset: 0x00070FD7
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x00072DE0 File Offset: 0x00070FE0
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00072DE8 File Offset: 0x00070FE8
		[global::System.Xml.Serialization.XmlElement("cxnSp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Connector), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("graphicFrame", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GraphicFrame), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("grpSp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GroupShape), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("pic", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Picture), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("sp", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Shape), Order = 2)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x04001FBD RID: 8125
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker fromField;

		// Token: 0x04001FBE RID: 8126
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D extField;

		// Token: 0x04001FBF RID: 8127
		private object itemField;
	}
}
