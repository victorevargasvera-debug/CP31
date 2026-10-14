using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B3 RID: 947
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ChildPref
	{
		// Token: 0x0600259D RID: 9629 RVA: 0x0005E54B File Offset: 0x0005C74B
		public CT_ChildPref()
		{
			this.valField = -1;
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0005E55A File Offset: 0x0005C75A
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0005E562 File Offset: 0x0005C762
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(-1)]
		public int val
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

		// Token: 0x04001C2C RID: 7212
		private int valField;
	}
}
