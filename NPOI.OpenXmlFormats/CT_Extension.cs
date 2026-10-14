using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002B RID: 43
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Extension
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000035ED File Offset: 0x000017ED
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000035F5 File Offset: 0x000017F5
		[global::System.Xml.Serialization.XmlAnyElement]
		public global::System.Xml.XmlElement Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000035FE File Offset: 0x000017FE
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00003606 File Offset: 0x00001806
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x0400013B RID: 315
		private global::System.Xml.XmlElement anyField;

		// Token: 0x0400013C RID: 316
		private string uriField;
	}
}
