using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002AC RID: 684
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Ratio
	{
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0004A60E File Offset: 0x0004880E
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0004A616 File Offset: 0x00048816
		[global::System.Xml.Serialization.XmlAttribute]
		public long n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0004A61F File Offset: 0x0004881F
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0004A627 File Offset: 0x00048827
		[global::System.Xml.Serialization.XmlAttribute]
		public long d
		{
			get
			{
				return this.dField;
			}
			set
			{
				this.dField = value;
			}
		}

		// Token: 0x040014E5 RID: 5349
		private long nField;

		// Token: 0x040014E6 RID: 5350
		private long dField;
	}
}
