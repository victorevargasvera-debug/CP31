using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038E RID: 910
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Name
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x0005D406 File Offset: 0x0005B606
		public CT_Name()
		{
			this.langField = "";
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0005D419 File Offset: 0x0005B619
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x0005D421 File Offset: 0x0005B621
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0005D42A File Offset: 0x0005B62A
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0005D432 File Offset: 0x0005B632
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
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

		// Token: 0x04001AD2 RID: 6866
		private string langField;

		// Token: 0x04001AD3 RID: 6867
		private string valField;
	}
}
