using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000471 RID: 1137
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shape
	{
		// Token: 0x06002D67 RID: 11623 RVA: 0x000729B4 File Offset: 0x00070BB4
		public CT_Shape()
		{
			this.txBodyField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBody();
			this.styleField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle();
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties();
			this.nvSpPrField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ShapeNonVisual();
			this.fLocksTextField = true;
			this.fPublishedField = false;
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x00072A01 File Offset: 0x00070C01
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x00072A09 File Offset: 0x00070C09
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ShapeNonVisual nvSpPr
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

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x00072A12 File Offset: 0x00070C12
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x00072A1A File Offset: 0x00070C1A
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

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x00072A23 File Offset: 0x00070C23
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x00072A2B File Offset: 0x00070C2B
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

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x00072A34 File Offset: 0x00070C34
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x00072A3C File Offset: 0x00070C3C
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBody txBody
		{
			get
			{
				return this.txBodyField;
			}
			set
			{
				this.txBodyField = value;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x00072A45 File Offset: 0x00070C45
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x00072A4D File Offset: 0x00070C4D
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

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x00072A56 File Offset: 0x00070C56
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x00072A5E File Offset: 0x00070C5E
		[global::System.Xml.Serialization.XmlAttribute]
		public string textlink
		{
			get
			{
				return this.textlinkField;
			}
			set
			{
				this.textlinkField = value;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x00072A67 File Offset: 0x00070C67
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x00072A6F File Offset: 0x00070C6F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool fLocksText
		{
			get
			{
				return this.fLocksTextField;
			}
			set
			{
				this.fLocksTextField = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x00072A78 File Offset: 0x00070C78
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x00072A80 File Offset: 0x00070C80
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

		// Token: 0x04001F95 RID: 8085
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ShapeNonVisual nvSpPrField;

		// Token: 0x04001F96 RID: 8086
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x04001F97 RID: 8087
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001F98 RID: 8088
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBody txBodyField;

		// Token: 0x04001F99 RID: 8089
		private string macroField;

		// Token: 0x04001F9A RID: 8090
		private string textlinkField;

		// Token: 0x04001F9B RID: 8091
		private bool fLocksTextField;

		// Token: 0x04001F9C RID: 8092
		private bool fPublishedField;
	}
}
