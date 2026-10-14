using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200034A RID: 842
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ClipboardStyleSheet
	{
		// Token: 0x06002127 RID: 8487 RVA: 0x000574E7 File Offset: 0x000556E7
		public CT_ClipboardStyleSheet()
		{
			this.clrMapField = new global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping();
			this.themeElementsField = new global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles();
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00057505 File Offset: 0x00055705
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x0005750D File Offset: 0x0005570D
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles themeElements
		{
			get
			{
				return this.themeElementsField;
			}
			set
			{
				this.themeElementsField = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x00057516 File Offset: 0x00055716
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x0005751E File Offset: 0x0005571E
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMap
		{
			get
			{
				return this.clrMapField;
			}
			set
			{
				this.clrMapField = value;
			}
		}

		// Token: 0x04001979 RID: 6521
		private global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles themeElementsField;

		// Token: 0x0400197A RID: 6522
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMapField;
	}
}
