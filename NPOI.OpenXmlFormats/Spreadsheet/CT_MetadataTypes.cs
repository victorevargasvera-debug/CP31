using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D1 RID: 1489
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataTypes
	{
		// Token: 0x06004194 RID: 16788 RVA: 0x0009EC3F File Offset: 0x0009CE3F
		public CT_MetadataTypes()
		{
			this.metadataTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataType>();
			this.countField = 0U;
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x0009EC59 File Offset: 0x0009CE59
		// (set) Token: 0x06004196 RID: 16790 RVA: 0x0009EC61 File Offset: 0x0009CE61
		[global::System.Xml.Serialization.XmlElement("metadataType")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataType> metadataType
		{
			get
			{
				return this.metadataTypeField;
			}
			set
			{
				this.metadataTypeField = value;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x0009EC6A File Offset: 0x0009CE6A
		// (set) Token: 0x06004198 RID: 16792 RVA: 0x0009EC72 File Offset: 0x0009CE72
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

		// Token: 0x04002954 RID: 10580
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataType> metadataTypeField;

		// Token: 0x04002955 RID: 10581
		private uint countField;
	}
}
