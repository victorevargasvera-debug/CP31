using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000028 RID: 40
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Connections
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00003357 File Offset: 0x00001557
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000335F File Offset: 0x0000155F
		[global::System.Xml.Serialization.XmlElement("connection")]
		public global::NPOI.OpenXmlFormats.CT_Connection[] connection
		{
			get
			{
				return this.connectionField;
			}
			set
			{
				this.connectionField = value;
			}
		}

		// Token: 0x0400011B RID: 283
		private global::NPOI.OpenXmlFormats.CT_Connection[] connectionField;
	}
}
