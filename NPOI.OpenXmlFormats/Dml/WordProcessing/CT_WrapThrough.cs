using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200035B RID: 859
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WrapThrough
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x00058E3F File Offset: 0x0005703F
		public CT_WrapThrough()
		{
			this.wrapPolygonField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapPath();
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x00058E52 File Offset: 0x00057052
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x00058E5A File Offset: 0x0005705A
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x00058E63 File Offset: 0x00057063
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x00058E6B File Offset: 0x0005706B
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x00058E74 File Offset: 0x00057074
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00058E7C File Offset: 0x0005707C
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

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x00058E85 File Offset: 0x00057085
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00058E8D File Offset: 0x0005708D
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x00058E96 File Offset: 0x00057096
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00058E9E File Offset: 0x0005709E
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00058EA7 File Offset: 0x000570A7
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00058EAF File Offset: 0x000570AF
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

		// Token: 0x040019EC RID: 6636
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapPath wrapPolygonField;

		// Token: 0x040019ED RID: 6637
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText wrapTextField;

		// Token: 0x040019EE RID: 6638
		private uint distLField;

		// Token: 0x040019EF RID: 6639
		private bool distLFieldSpecified;

		// Token: 0x040019F0 RID: 6640
		private uint distRField;

		// Token: 0x040019F1 RID: 6641
		private bool distRFieldSpecified;
	}
}
