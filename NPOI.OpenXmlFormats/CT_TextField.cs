using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000036 RID: 54
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextField
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00003ADE File Offset: 0x00001CDE
		public CT_TextField()
		{
			this.typeField = global::NPOI.OpenXmlFormats.ST_ExternalConnectionType.general;
			this.positionField = 0U;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00003AFC File Offset: 0x00001CFC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_ExternalConnectionType.general)]
		public global::NPOI.OpenXmlFormats.ST_ExternalConnectionType type
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00003B05 File Offset: 0x00001D05
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00003B0D File Offset: 0x00001D0D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x04000171 RID: 369
		private global::NPOI.OpenXmlFormats.ST_ExternalConnectionType typeField;

		// Token: 0x04000172 RID: 370
		private uint positionField;
	}
}
