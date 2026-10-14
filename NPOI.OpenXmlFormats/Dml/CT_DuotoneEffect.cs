using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200032E RID: 814
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DuotoneEffect
	{
		// Token: 0x0600206E RID: 8302 RVA: 0x000560F1 File Offset: 0x000542F1
		public CT_DuotoneEffect()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00056104 File Offset: 0x00054304
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x0005610C File Offset: 0x0005430C
		[global::System.Xml.Serialization.XmlElement("hslClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_HslColor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("prstClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_PresetColor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("schemeClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("scrgbClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("srgbClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sysClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SystemColor), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x04001928 RID: 6440
		private global::System.Collections.Generic.List<object> itemsField;
	}
}
