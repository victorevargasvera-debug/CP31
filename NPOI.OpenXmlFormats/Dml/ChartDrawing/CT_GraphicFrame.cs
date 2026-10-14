using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000477 RID: 1143
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GraphicFrame
	{
		// Token: 0x06002D9F RID: 11679 RVA: 0x00072C2D File Offset: 0x00070E2D
		public CT_GraphicFrame()
		{
			this.graphicField = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject();
			this.nvGraphicFramePrField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GraphicFrameNonVisual();
			this.fPublishedField = false;
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x00072C52 File Offset: 0x00070E52
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x00072C5A File Offset: 0x00070E5A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GraphicFrameNonVisual nvGraphicFramePr
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

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00072C63 File Offset: 0x00070E63
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00072C6B File Offset: 0x00070E6B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x00072C74 File Offset: 0x00070E74
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x00072C7C File Offset: 0x00070E7C
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 2)]
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

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x00072C85 File Offset: 0x00070E85
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x00072C8D File Offset: 0x00070E8D
		[global::System.Xml.Serialization.XmlAttribute]
		public string macro
		{
			get
			{
				return this.macroField;
			}
			set
			{
				this.macroField = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00072C96 File Offset: 0x00070E96
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x00072C9E File Offset: 0x00070E9E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fPublished
		{
			get
			{
				return this.fPublishedField;
			}
			set
			{
				this.fPublishedField = value;
			}
		}

		// Token: 0x04001FAE RID: 8110
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_GraphicFrameNonVisual nvGraphicFramePrField;

		// Token: 0x04001FAF RID: 8111
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x04001FB0 RID: 8112
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphicField;

		// Token: 0x04001FB1 RID: 8113
		private string macroField;

		// Token: 0x04001FB2 RID: 8114
		private bool fPublishedField;
	}
}
