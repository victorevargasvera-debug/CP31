using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C4 RID: 964
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SDCategory
	{
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0005E91D File Offset: 0x0005CB1D
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x0005E925 File Offset: 0x0005CB25
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

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x0005E92E File Offset: 0x0005CB2E
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x0005E936 File Offset: 0x0005CB36
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

		// Token: 0x04001C62 RID: 7266
		private string typeField;

		// Token: 0x04001C63 RID: 7267
		private uint priField;
	}
}
