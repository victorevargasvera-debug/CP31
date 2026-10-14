using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002CC RID: 716
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/compatibility")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/compatibility", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Compat
	{
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0004DF26 File Offset: 0x0004C126
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0004DF2E File Offset: 0x0004C12E
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string spid
		{
			get
			{
				return this.spidField;
			}
			set
			{
				this.spidField = value;
			}
		}

		// Token: 0x04001626 RID: 5670
		private string spidField;
	}
}
