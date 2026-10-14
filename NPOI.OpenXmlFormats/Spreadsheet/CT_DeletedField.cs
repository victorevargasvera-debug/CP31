using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F1 RID: 1521
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DeletedField
	{
		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x0009FB87 File Offset: 0x0009DD87
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x0009FB8F File Offset: 0x0009DD8F
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x04002A40 RID: 10816
		private string nameField;
	}
}
