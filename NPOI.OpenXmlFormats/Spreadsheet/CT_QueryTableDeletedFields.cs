using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F0 RID: 1520
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QueryTableDeletedFields
	{
		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x0009FB54 File Offset: 0x0009DD54
		// (set) Token: 0x060042DA RID: 17114 RVA: 0x0009FB5C File Offset: 0x0009DD5C
		[global::System.Xml.Serialization.XmlElement("deletedField")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DeletedField[] deletedField
		{
			get
			{
				return this.deletedFieldField;
			}
			set
			{
				this.deletedFieldField = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x0009FB65 File Offset: 0x0009DD65
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x0009FB6D File Offset: 0x0009DD6D
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

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x0009FB76 File Offset: 0x0009DD76
		// (set) Token: 0x060042DE RID: 17118 RVA: 0x0009FB7E File Offset: 0x0009DD7E
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

		// Token: 0x04002A3D RID: 10813
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DeletedField[] deletedFieldField;

		// Token: 0x04002A3E RID: 10814
		private uint countField;

		// Token: 0x04002A3F RID: 10815
		private bool countFieldSpecified;
	}
}
