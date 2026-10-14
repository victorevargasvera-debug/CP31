using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000256 RID: 598
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableStyleCellStyle
	{
		// Token: 0x0600184B RID: 6219 RVA: 0x00043A53 File Offset: 0x00041C53
		public CT_TableStyleCellStyle()
		{
			this.cell3DField = new global::NPOI.OpenXmlFormats.Dml.CT_Cell3D();
			this.fillRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			this.fillField = new global::NPOI.OpenXmlFormats.Dml.CT_FillProperties();
			this.tcBdrField = new global::NPOI.OpenXmlFormats.Dml.CT_TableCellBorderStyle();
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00043A87 File Offset: 0x00041C87
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x00043A8F File Offset: 0x00041C8F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableCellBorderStyle tcBdr
		{
			get
			{
				return this.tcBdrField;
			}
			set
			{
				this.tcBdrField = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00043A98 File Offset: 0x00041C98
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x00043AA0 File Offset: 0x00041CA0
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FillProperties fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00043AA9 File Offset: 0x00041CA9
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x00043AB1 File Offset: 0x00041CB1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRef
		{
			get
			{
				return this.fillRefField;
			}
			set
			{
				this.fillRefField = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00043ABA File Offset: 0x00041CBA
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x00043AC2 File Offset: 0x00041CC2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Cell3D cell3D
		{
			get
			{
				return this.cell3DField;
			}
			set
			{
				this.cell3DField = value;
			}
		}

		// Token: 0x040012A8 RID: 4776
		private global::NPOI.OpenXmlFormats.Dml.CT_TableCellBorderStyle tcBdrField;

		// Token: 0x040012A9 RID: 4777
		private global::NPOI.OpenXmlFormats.Dml.CT_FillProperties fillField;

		// Token: 0x040012AA RID: 4778
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRefField;

		// Token: 0x040012AB RID: 4779
		private global::NPOI.OpenXmlFormats.Dml.CT_Cell3D cell3DField;
	}
}
