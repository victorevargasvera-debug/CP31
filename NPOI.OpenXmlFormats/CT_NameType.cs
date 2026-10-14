using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000022 RID: 34
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NameType
	{
		// Token: 0x06000146 RID: 326 RVA: 0x0000329B File Offset: 0x0000149B
		public CT_NameType()
		{
			this.nameListField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType>();
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000032AE File Offset: 0x000014AE
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000032B6 File Offset: 0x000014B6
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("Person", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType> NameList
		{
			get
			{
				return this.nameListField;
			}
			set
			{
				this.nameListField = value;
			}
		}

		// Token: 0x04000103 RID: 259
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType> nameListField;
	}
}
