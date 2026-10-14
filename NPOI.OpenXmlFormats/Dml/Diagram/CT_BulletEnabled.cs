using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B4 RID: 948
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BulletEnabled
	{
		// Token: 0x060025A0 RID: 9632 RVA: 0x0005E56B File Offset: 0x0005C76B
		public CT_BulletEnabled()
		{
			this.valField = false;
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x0005E57A File Offset: 0x0005C77A
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x0005E582 File Offset: 0x0005C782
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

		// Token: 0x04001C2D RID: 7213
		private bool valField;
	}
}
