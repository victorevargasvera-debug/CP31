using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002E RID: 46
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_XStringElement
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000036A5 File Offset: 0x000018A5
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000036AD File Offset: 0x000018AD
		[global::System.Xml.Serialization.XmlAttribute]
		public string v
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

		// Token: 0x0400013F RID: 319
		private string vField;
	}
}
