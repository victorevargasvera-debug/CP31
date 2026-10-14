using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000044 RID: 68
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_UcharHexNumber
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000407E File Offset: 0x0000227E
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00004086 File Offset: 0x00002286
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] val
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

		// Token: 0x040001A8 RID: 424
		private byte[] valField;
	}
}
