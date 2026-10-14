using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000018 RID: 24
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public class CT_Cf
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002D54 File Offset: 0x00000F54
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002D5C File Offset: 0x00000F5C
		[global::System.Xml.Serialization.XmlAttribute]
		public string format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002D65 File Offset: 0x00000F65
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002D6D File Offset: 0x00000F6D
		[global::System.Xml.Serialization.XmlText(DataType = "base64Binary")]
		public byte[] Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x0400009F RID: 159
		private string formatField;

		// Token: 0x040000A0 RID: 160
		private byte[] valueField;
	}
}
