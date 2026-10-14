using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002AB RID: 683
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PositiveFixedPercentage
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0004A5FD File Offset: 0x000487FD
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0004A605 File Offset: 0x00048805
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

		// Token: 0x040014E4 RID: 5348
		private int valField;
	}
}
