using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000035 RID: 53
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextFields
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00003AAD File Offset: 0x00001CAD
		public CT_TextFields()
		{
			this.countField = 1U;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00003ABC File Offset: 0x00001CBC
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[global::System.Xml.Serialization.XmlElement("textField")]
		public global::NPOI.OpenXmlFormats.CT_TextField[] textField
		{
			get
			{
				return this.textFieldField;
			}
			set
			{
				this.textFieldField = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00003ACD File Offset: 0x00001CCD
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00003AD5 File Offset: 0x00001CD5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
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

		// Token: 0x0400016F RID: 367
		private global::NPOI.OpenXmlFormats.CT_TextField[] textFieldField;

		// Token: 0x04000170 RID: 368
		private uint countField;
	}
}
