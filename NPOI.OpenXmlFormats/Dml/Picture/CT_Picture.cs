using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Picture
{
	// Token: 0x0200037A RID: 890
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/picture")]
	[global::System.Xml.Serialization.XmlRoot("pic", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/picture", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Picture
	{
		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0005CC1C File Offset: 0x0005AE1C
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x0005CC24 File Offset: 0x0005AE24
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual nvPicPr
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0005CC2D File Offset: 0x0005AE2D
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x0005CC35 File Offset: 0x0005AE35
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

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0005CC3E File Offset: 0x0005AE3E
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x0005CC46 File Offset: 0x0005AE46
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

		// Token: 0x060023B3 RID: 9139 RVA: 0x0005CC4F File Offset: 0x0005AE4F
		public global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual AddNewNvPicPr()
		{
			this.nvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual();
			return this.nvPicPrField;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0005CC62 File Offset: 0x0005AE62
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties AddNewBlipFill()
		{
			this.blipFillField = new global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties();
			return this.blipFillField;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0005CC75 File Offset: 0x0005AE75
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties AddNewSpPr()
		{
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties();
			return this.spPrField;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0005CC88 File Offset: 0x0005AE88
		public void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0} xmlns:pic=\"{1}\">", nodeName, "http://schemas.openxmlformats.org/drawingml/2006/picture"));
			if (this.nvPicPr != null)
			{
				this.nvPicPr.Write(sw, "pic:nvPicPr");
			}
			if (this.blipFill != null)
			{
				this.blipFill.Write(sw, "pic:blipFill");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "pic:spPr");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04001A81 RID: 6785
		private global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual nvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual();

		// Token: 0x04001A82 RID: 6786
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField = new global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties();

		// Token: 0x04001A83 RID: 6787
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties();
	}
}
