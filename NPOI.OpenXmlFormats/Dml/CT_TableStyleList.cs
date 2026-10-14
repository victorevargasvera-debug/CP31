using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000259 RID: 601
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("tblStyleLst", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_TableStyleList
	{
		// Token: 0x0600187C RID: 6268 RVA: 0x00043CE5 File Offset: 0x00041EE5
		public CT_TableStyleList()
		{
			this.tblStyleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableStyle>();
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00043CF8 File Offset: 0x00041EF8
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x00043D00 File Offset: 0x00041F00
		[global::System.Xml.Serialization.XmlElement("tblStyle", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableStyle> tblStyle
		{
			get
			{
				return this.tblStyleField;
			}
			set
			{
				this.tblStyleField = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00043D09 File Offset: 0x00041F09
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x00043D11 File Offset: 0x00041F11
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string def
		{
			get
			{
				return this.defField;
			}
			set
			{
				this.defField = value;
			}
		}

		// Token: 0x040012BF RID: 4799
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableStyle> tblStyleField;

		// Token: 0x040012C0 RID: 4800
		private string defField;
	}
}
