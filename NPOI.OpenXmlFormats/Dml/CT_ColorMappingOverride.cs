using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000345 RID: 837
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorMappingOverride
	{
		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0005702C File Offset: 0x0005522C
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x00057034 File Offset: 0x00055234
		[global::System.Xml.Serialization.XmlElement("masterClrMapping", typeof(global::NPOI.OpenXmlFormats.Dml.CT_EmptyElement), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("overrideClrMapping", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x0400196C RID: 6508
		private object itemField;
	}
}
