using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A8 RID: 680
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Percentage
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0004A5CA File Offset: 0x000487CA
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0004A5D2 File Offset: 0x000487D2
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
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

		// Token: 0x040014E1 RID: 5345
		private int valField;
	}
}
