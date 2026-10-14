using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000057 RID: 87
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BookmarkRange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000047F8 File Offset: 0x000029F8
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00004800 File Offset: 0x00002A00
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string colFirst
		{
			get
			{
				return this.colFirstField;
			}
			set
			{
				this.colFirstField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00004809 File Offset: 0x00002A09
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00004811 File Offset: 0x00002A11
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string colLast
		{
			get
			{
				return this.colLastField;
			}
			set
			{
				this.colLastField = value;
			}
		}

		// Token: 0x040001BB RID: 443
		private string colFirstField;

		// Token: 0x040001BC RID: 444
		private string colLastField;
	}
}
