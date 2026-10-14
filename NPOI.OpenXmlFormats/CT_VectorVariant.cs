using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200000F RID: 15
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VectorVariant
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002BCB File Offset: 0x00000DCB
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002BD3 File Offset: 0x00000DD3
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", Order = 0)]
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

		// Token: 0x04000077 RID: 119
		private global::NPOI.OpenXmlFormats.CT_Vector vectorField;
	}
}
