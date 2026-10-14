using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000048 RID: 72
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PixelsMeasure
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000041D8 File Offset: 0x000023D8
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000041E0 File Offset: 0x000023E0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x040001AC RID: 428
		private ulong valField;
	}
}
