using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005EE RID: 1518
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QueryTableFields
	{
		// Token: 0x060042C3 RID: 17091 RVA: 0x0009FA65 File Offset: 0x0009DC65
		public CT_QueryTableFields()
		{
			this.countField = 0U;
			this.queryTableFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableField>();
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x0009FA7F File Offset: 0x0009DC7F
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x0009FA87 File Offset: 0x0009DC87
		[global::System.Xml.Serialization.XmlElement("queryTableField")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableField> queryTableField
		{
			get
			{
				return this.queryTableFieldField;
			}
			set
			{
				this.queryTableFieldField = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x0009FA90 File Offset: 0x0009DC90
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x0009FA98 File Offset: 0x0009DC98
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

		// Token: 0x04002A33 RID: 10803
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableField> queryTableFieldField;

		// Token: 0x04002A34 RID: 10804
		private uint countField;
	}
}
