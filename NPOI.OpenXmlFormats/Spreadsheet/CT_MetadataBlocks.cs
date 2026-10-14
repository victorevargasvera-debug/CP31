using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D4 RID: 1492
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataBlocks
	{
		// Token: 0x060041D7 RID: 16855 RVA: 0x0009EF43 File Offset: 0x0009D143
		public CT_MetadataBlocks()
		{
			this.bkField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord>();
			this.countField = 0U;
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x0009EF5D File Offset: 0x0009D15D
		// (set) Token: 0x060041D9 RID: 16857 RVA: 0x0009EF65 File Offset: 0x0009D165
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("rc", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord), IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord> bk
		{
			get
			{
				return this.bkField;
			}
			set
			{
				this.bkField = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x0009EF6E File Offset: 0x0009D16E
		// (set) Token: 0x060041DB RID: 16859 RVA: 0x0009EF76 File Offset: 0x0009D176
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x04002974 RID: 10612
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord> bkField;

		// Token: 0x04002975 RID: 10613
		private uint countField;
	}
}
