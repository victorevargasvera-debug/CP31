using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000347 RID: 839
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorSchemeList
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x0005716E File Offset: 0x0005536E
		public CT_ColorSchemeList()
		{
			this.extraClrSchemeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping>();
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x00057181 File Offset: 0x00055381
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x00057189 File Offset: 0x00055389
		[global::System.Xml.Serialization.XmlElement("extraClrScheme", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping> extraClrScheme
		{
			get
			{
				return this.extraClrSchemeField;
			}
			set
			{
				this.extraClrSchemeField = value;
			}
		}

		// Token: 0x0400196F RID: 6511
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping> extraClrSchemeField;
	}
}
