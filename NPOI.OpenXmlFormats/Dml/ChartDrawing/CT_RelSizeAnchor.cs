using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x0200047B RID: 1147
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RelSizeAnchor
	{
		// Token: 0x06002DBB RID: 11707 RVA: 0x00072D5A File Offset: 0x00070F5A
		public CT_RelSizeAnchor()
		{
			this.toField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker();
			this.fromField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker();
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x00072D78 File Offset: 0x00070F78
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x00072D80 File Offset: 0x00070F80
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

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x00072D89 File Offset: 0x00070F89
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x00072D91 File Offset: 0x00070F91
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x00072D9A File Offset: 0x00070F9A
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x00072DA2 File Offset: 0x00070FA2
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

		// Token: 0x04001FBA RID: 8122
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker fromField;

		// Token: 0x04001FBB RID: 8123
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_Marker toField;

		// Token: 0x04001FBC RID: 8124
		private object itemField;
	}
}
