using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B1 RID: 945
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OrgChart
	{
		// Token: 0x06002597 RID: 9623 RVA: 0x0005E50B File Offset: 0x0005C70B
		public CT_OrgChart()
		{
			this.valField = false;
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x0005E51A File Offset: 0x0005C71A
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x0005E522 File Offset: 0x0005C722
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04001C2A RID: 7210
		private bool valField;
	}
}
