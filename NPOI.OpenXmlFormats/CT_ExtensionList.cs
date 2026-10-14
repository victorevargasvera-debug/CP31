using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002C RID: 44
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ExtensionList
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000360F File Offset: 0x0000180F
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00003617 File Offset: 0x00001817
		[global::System.Xml.Serialization.XmlElement("ext")]
		public global::NPOI.OpenXmlFormats.CT_Extension[] ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x0400013D RID: 317
		private global::NPOI.OpenXmlFormats.CT_Extension[] extField;
	}
}
