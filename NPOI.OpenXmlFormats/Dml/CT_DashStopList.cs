using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000294 RID: 660
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DashStopList
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00049156 File Offset: 0x00047356
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0004915E File Offset: 0x0004735E
		[global::System.Xml.Serialization.XmlElement("ds", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_DashStop> ds
		{
			get
			{
				return this.dsField;
			}
			set
			{
				this.dsField = value;
			}
		}

		// Token: 0x04001419 RID: 5145
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_DashStop> dsField;
	}
}
