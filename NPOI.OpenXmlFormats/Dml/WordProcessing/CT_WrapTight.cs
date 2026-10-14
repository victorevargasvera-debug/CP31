using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200035D RID: 861
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WrapTight
	{
		// Token: 0x06002202 RID: 8706 RVA: 0x00058F0F File Offset: 0x0005710F
		public CT_WrapTight()
		{
			this.wrapPolygonField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapPath();
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00058F22 File Offset: 0x00057122
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00058F2A File Offset: 0x0005712A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapPath wrapPolygon
		{
			get
			{
				return this.wrapPolygonField;
			}
			set
			{
				this.wrapPolygonField = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x00058F33 File Offset: 0x00057133
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00058F3B File Offset: 0x0005713B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText wrapText
		{
			get
			{
				return this.wrapTextField;
			}
			set
			{
				this.wrapTextField = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x00058F44 File Offset: 0x00057144
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00058F4C File Offset: 0x0005714C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distL
		{
			get
			{
				return this.distLField;
			}
			set
			{
				this.distLField = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00058F55 File Offset: 0x00057155
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00058F5D File Offset: 0x0005715D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distLSpecified
		{
			get
			{
				return this.distLFieldSpecified;
			}
			set
			{
				this.distLFieldSpecified = value;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00058F66 File Offset: 0x00057166
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00058F6E File Offset: 0x0005716E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distR
		{
			get
			{
				return this.distRField;
			}
			set
			{
				this.distRField = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00058F77 File Offset: 0x00057177
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00058F7F File Offset: 0x0005717F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distRSpecified
		{
			get
			{
				return this.distRFieldSpecified;
			}
			set
			{
				this.distRFieldSpecified = value;
			}
		}

		// Token: 0x040019F6 RID: 6646
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapPath wrapPolygonField;

		// Token: 0x040019F7 RID: 6647
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText wrapTextField;

		// Token: 0x040019F8 RID: 6648
		private uint distLField;

		// Token: 0x040019F9 RID: 6649
		private bool distLFieldSpecified;

		// Token: 0x040019FA RID: 6650
		private uint distRField;

		// Token: 0x040019FB RID: 6651
		private bool distRFieldSpecified;
	}
}
