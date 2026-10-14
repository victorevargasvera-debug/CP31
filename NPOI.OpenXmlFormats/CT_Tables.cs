using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000031 RID: 49
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Tables
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000038E3 File Offset: 0x00001AE3
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000038EB File Offset: 0x00001AEB
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.CT_TableMissing))]
		[global::System.Xml.Serialization.XmlElement("s", typeof(global::NPOI.OpenXmlFormats.CT_XStringElement))]
		[global::System.Xml.Serialization.XmlElement("x", typeof(global::NPOI.OpenXmlFormats.CT_Index))]
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000038F4 File Offset: 0x00001AF4
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000038FC File Offset: 0x00001AFC
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00003905 File Offset: 0x00001B05
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000390D File Offset: 0x00001B0D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x04000158 RID: 344
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04000159 RID: 345
		private uint countField;

		// Token: 0x0400015A RID: 346
		private bool countFieldSpecified;
	}
}
