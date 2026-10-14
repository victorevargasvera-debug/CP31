using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000475 RID: 1141
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Picture
	{
		// Token: 0x06002D8D RID: 11661 RVA: 0x00072B62 File Offset: 0x00070D62
		public CT_Picture()
		{
			this.blipFillField = new global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties();
			this.nvPicPrField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_PictureNonVisual();
			this.macroField = "";
			this.fPublishedField = false;
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x00072B92 File Offset: 0x00070D92
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00072B9A File Offset: 0x00070D9A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_PictureNonVisual nvPicPr
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

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x00072BA3 File Offset: 0x00070DA3
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00072BAB File Offset: 0x00070DAB
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x00072BB4 File Offset: 0x00070DB4
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00072BBC File Offset: 0x00070DBC
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

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x00072BC5 File Offset: 0x00070DC5
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00072BCD File Offset: 0x00070DCD
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

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x00072BD6 File Offset: 0x00070DD6
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00072BDE File Offset: 0x00070DDE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00072BE7 File Offset: 0x00070DE7
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00072BEF File Offset: 0x00070DEF
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

		// Token: 0x04001FA6 RID: 8102
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_PictureNonVisual nvPicPrField;

		// Token: 0x04001FA7 RID: 8103
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001FA8 RID: 8104
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x04001FA9 RID: 8105
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001FAA RID: 8106
		private string macroField;

		// Token: 0x04001FAB RID: 8107
		private bool fPublishedField;
	}
}
