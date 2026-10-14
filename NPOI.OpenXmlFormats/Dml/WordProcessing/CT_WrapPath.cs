using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200035C RID: 860
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WrapPath
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x00058EB8 File Offset: 0x000570B8
		public CT_WrapPath()
		{
			this.lineToField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Point2D>();
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x00058ECB File Offset: 0x000570CB
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x00058ED3 File Offset: 0x000570D3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00058EDC File Offset: 0x000570DC
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x00058EE4 File Offset: 0x000570E4
		[global::System.Xml.Serialization.XmlElement("lineTo", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Point2D> lineTo
		{
			get
			{
				return this.lineToField;
			}
			set
			{
				this.lineToField = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00058EED File Offset: 0x000570ED
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00058EF5 File Offset: 0x000570F5
		[global::System.Xml.Serialization.XmlAttribute]
		public bool edited
		{
			get
			{
				return this.editedField;
			}
			set
			{
				this.editedField = value;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00058EFE File Offset: 0x000570FE
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x00058F06 File Offset: 0x00057106
		[global::System.Xml.Serialization.XmlIgnore]
		public bool editedSpecified
		{
			get
			{
				return this.editedFieldSpecified;
			}
			set
			{
				this.editedFieldSpecified = value;
			}
		}

		// Token: 0x040019F2 RID: 6642
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D startField;

		// Token: 0x040019F3 RID: 6643
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Point2D> lineToField;

		// Token: 0x040019F4 RID: 6644
		private bool editedField;

		// Token: 0x040019F5 RID: 6645
		private bool editedFieldSpecified;
	}
}
