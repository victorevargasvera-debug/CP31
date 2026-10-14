using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000313 RID: 787
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RelativeOffsetEffect
	{
		// Token: 0x06001F2C RID: 7980 RVA: 0x0005386D File Offset: 0x00051A6D
		public CT_RelativeOffsetEffect()
		{
			this.txField = 0;
			this.tyField = 0;
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00053883 File Offset: 0x00051A83
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0005388B File Offset: 0x00051A8B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int tx
		{
			get
			{
				return this.txField;
			}
			set
			{
				this.txField = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00053894 File Offset: 0x00051A94
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x0005389C File Offset: 0x00051A9C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int ty
		{
			get
			{
				return this.tyField;
			}
			set
			{
				this.tyField = value;
			}
		}

		// Token: 0x0400184E RID: 6222
		private int txField;

		// Token: 0x0400184F RID: 6223
		private int tyField;
	}
}
