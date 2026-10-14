using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000390 RID: 912
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Category
	{
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0005D470 File Offset: 0x0005B670
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0005D478 File Offset: 0x0005B678
		[global::System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x0005D481 File Offset: 0x0005B681
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0005D489 File Offset: 0x0005B689
		[global::System.Xml.Serialization.XmlAttribute]
		public uint pri
		{
			get
			{
				return this.priField;
			}
			set
			{
				this.priField = value;
			}
		}

		// Token: 0x04001AD6 RID: 6870
		private string typeField;

		// Token: 0x04001AD7 RID: 6871
		private uint priField;
	}
}
