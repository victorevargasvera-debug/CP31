using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000084 RID: 132
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocVars
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x0000B236 File Offset: 0x00009436
		public CT_DocVars()
		{
			this.docVarField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar>();
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000B249 File Offset: 0x00009449
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000B251 File Offset: 0x00009451
		[global::System.Xml.Serialization.XmlElement("docVar", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar> docVar
		{
			get
			{
				return this.docVarField;
			}
			set
			{
				this.docVarField = value;
			}
		}

		// Token: 0x04000356 RID: 854
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar> docVarField;
	}
}
