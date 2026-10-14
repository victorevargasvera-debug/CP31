using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A4 RID: 932
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Adj
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0005DD6A File Offset: 0x0005BF6A
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x0005DD72 File Offset: 0x0005BF72
		[global::System.Xml.Serialization.XmlAttribute]
		public uint idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0005DD7B File Offset: 0x0005BF7B
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x0005DD83 File Offset: 0x0005BF83
		[global::System.Xml.Serialization.XmlAttribute]
		public double val
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

		// Token: 0x04001BC0 RID: 7104
		private uint idxField;

		// Token: 0x04001BC1 RID: 7105
		private double valField;
	}
}
