using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024B RID: 587
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableCol
	{
		// Token: 0x060017C1 RID: 6081 RVA: 0x00043473 File Offset: 0x00041673
		public CT_TableCol()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00043486 File Offset: 0x00041686
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0004348E File Offset: 0x0004168E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00043497 File Offset: 0x00041697
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0004349F File Offset: 0x0004169F
		[global::System.Xml.Serialization.XmlAttribute]
		public long w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x04001264 RID: 4708
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001265 RID: 4709
		private long wField;
	}
}
