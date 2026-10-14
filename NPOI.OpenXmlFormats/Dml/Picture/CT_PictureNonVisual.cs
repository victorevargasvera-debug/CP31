using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Picture
{
	// Token: 0x0200037B RID: 891
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/picture")]
	[global::System.Serializable]
	public class CT_PictureNonVisual
	{
		// Token: 0x060023B8 RID: 9144 RVA: 0x0005CD30 File Offset: 0x0005AF30
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps();
			return this.cNvPrField;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0005CD43 File Offset: 0x0005AF43
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties AddNewCNvPicPr()
		{
			this.cNvPicPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties();
			return this.cNvPicPrField;
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0005CD56 File Offset: 0x0005AF56
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0005CD5E File Offset: 0x0005AF5E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPr
		{
			get
			{
				return this.cNvPrField;
			}
			set
			{
				this.cNvPrField = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0005CD67 File Offset: 0x0005AF67
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0005CD6F File Offset: 0x0005AF6F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties cNvPicPr
		{
			get
			{
				return this.cNvPicPrField;
			}
			set
			{
				this.cNvPicPrField = value;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0005CD78 File Offset: 0x0005AF78
		internal void Write(global::System.IO.StreamWriter sw, string p)
		{
			sw.Write(string.Format("<{0}>", p));
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvPicPr != null)
			{
				this.cNvPicPr.Write(sw, "cNvPicPr");
			}
			sw.Write(string.Format("</{0}>", p));
		}

		// Token: 0x04001A84 RID: 6788
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps cNvPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps();

		// Token: 0x04001A85 RID: 6789
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties cNvPicPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties();
	}
}
