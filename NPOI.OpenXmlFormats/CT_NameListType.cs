using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000025 RID: 37
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NameListType
	{
		// Token: 0x06000153 RID: 339 RVA: 0x0000332C File Offset: 0x0000152C
		public CT_NameListType()
		{
			this.personField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType>();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000333F File Offset: 0x0000153F
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00003347 File Offset: 0x00001547
		[global::System.Xml.Serialization.XmlElement("Person")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType> Person
		{
			get
			{
				return this.personField;
			}
			set
			{
				this.personField = value;
			}
		}

		// Token: 0x04000108 RID: 264
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_PersonType> personField;
	}
}
