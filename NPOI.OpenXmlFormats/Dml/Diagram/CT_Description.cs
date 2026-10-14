using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038F RID: 911
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Description
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x0005D43B File Offset: 0x0005B63B
		public CT_Description()
		{
			this.langField = "";
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x0005D44E File Offset: 0x0005B64E
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x0005D456 File Offset: 0x0005B656
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

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0005D45F File Offset: 0x0005B65F
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0005D467 File Offset: 0x0005B667
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

		// Token: 0x04001AD4 RID: 6868
		private string langField;

		// Token: 0x04001AD5 RID: 6869
		private string valField;
	}
}
