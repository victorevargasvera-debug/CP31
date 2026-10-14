using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200010A RID: 266
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Panose
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000161DD File Offset: 0x000143DD
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x000161E5 File Offset: 0x000143E5
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

		// Token: 0x04000661 RID: 1633
		private byte[] valField;
	}
}
