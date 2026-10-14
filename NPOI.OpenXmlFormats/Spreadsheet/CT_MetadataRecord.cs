using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D3 RID: 1491
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataRecord
	{
		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x0009EF21 File Offset: 0x0009D121
		// (set) Token: 0x060041D3 RID: 16851 RVA: 0x0009EF29 File Offset: 0x0009D129
		[global::System.Xml.Serialization.XmlAttribute]
		public uint t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x0009EF32 File Offset: 0x0009D132
		// (set) Token: 0x060041D5 RID: 16853 RVA: 0x0009EF3A File Offset: 0x0009D13A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x04002972 RID: 10610
		private uint tField;

		// Token: 0x04002973 RID: 10611
		private uint vField;
	}
}
