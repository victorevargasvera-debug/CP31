using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000011 RID: 17
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VectorLpstr
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002BED File Offset: 0x00000DED
		public CT_VectorLpstr()
		{
			this.vectorField = new global::NPOI.OpenXmlFormats.CT_Vector();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002C00 File Offset: 0x00000E00
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002C08 File Offset: 0x00000E08
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		public global::NPOI.OpenXmlFormats.CT_Vector vector
		{
			get
			{
				return this.vectorField;
			}
			set
			{
				this.vectorField = value;
			}
		}

		// Token: 0x04000079 RID: 121
		private global::NPOI.OpenXmlFormats.CT_Vector vectorField;
	}
}
