using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000015 RID: 21
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public class CT_Vstream
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002D32 File Offset: 0x00000F32
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002D3A File Offset: 0x00000F3A
		[global::System.Xml.Serialization.XmlAttribute]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002D43 File Offset: 0x00000F43
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002D4B File Offset: 0x00000F4B
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

		// Token: 0x0400009D RID: 157
		private string versionField;

		// Token: 0x0400009E RID: 158
		private byte[] valueField;
	}
}
