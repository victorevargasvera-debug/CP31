using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C2 RID: 962
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextProps
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x0005E864 File Offset: 0x0005CA64
		public CT_TextProps()
		{
			this.sp3dField = new global::NPOI.OpenXmlFormats.Dml.CT_Shape3D();
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x0005E877 File Offset: 0x0005CA77
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0005E87F File Offset: 0x0005CA7F
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3d
		{
			get
			{
				return this.sp3dField;
			}
			set
			{
				this.sp3dField = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x0005E888 File Offset: 0x0005CA88
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x0005E890 File Offset: 0x0005CA90
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FlatText flatTx
		{
			get
			{
				return this.flatTxField;
			}
			set
			{
				this.flatTxField = value;
			}
		}

		// Token: 0x04001C5A RID: 7258
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x04001C5B RID: 7259
		private global::NPOI.OpenXmlFormats.Dml.CT_FlatText flatTxField;
	}
}
