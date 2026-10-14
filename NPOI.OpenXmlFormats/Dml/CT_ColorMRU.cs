using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C7 RID: 711
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorMRU
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x0004DA73 File Offset: 0x0004BC73
		public CT_ColorMRU()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0004DA86 File Offset: 0x0004BC86
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0004DA8E File Offset: 0x0004BC8E
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

		// Token: 0x04001601 RID: 5633
		private global::System.Collections.Generic.List<object> itemsField;
	}
}
