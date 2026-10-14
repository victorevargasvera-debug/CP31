using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000237 RID: 567
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GvmlTextShape
	{
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00042E93 File Offset: 0x00041093
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00042E9B File Offset: 0x0004109B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00042EA4 File Offset: 0x000410A4
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00042EAC File Offset: 0x000410AC
		[global::System.Xml.Serialization.XmlElement("useSpRect", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GvmlUseShapeRectangle), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("xfrm", typeof(global::NPOI.OpenXmlFormats.Dml.CT_Transform2D), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00042EB5 File Offset: 0x000410B5
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00042EBD File Offset: 0x000410BD
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04001217 RID: 4631
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBody txBodyField;

		// Token: 0x04001218 RID: 4632
		private object itemField;

		// Token: 0x04001219 RID: 4633
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
