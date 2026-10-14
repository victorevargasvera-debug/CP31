using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200031A RID: 794
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HSLEffect
	{
		// Token: 0x06001FA0 RID: 8096 RVA: 0x0005488A File Offset: 0x00052A8A
		public CT_HSLEffect()
		{
			this.hueField = 0;
			this.satField = 0;
			this.lumField = 0;
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000548A7 File Offset: 0x00052AA7
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x000548AF File Offset: 0x00052AAF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int hue
		{
			get
			{
				return this.hueField;
			}
			set
			{
				this.hueField = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000548B8 File Offset: 0x00052AB8
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x000548C0 File Offset: 0x00052AC0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int sat
		{
			get
			{
				return this.satField;
			}
			set
			{
				this.satField = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000548C9 File Offset: 0x00052AC9
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x000548D1 File Offset: 0x00052AD1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int lum
		{
			get
			{
				return this.lumField;
			}
			set
			{
				this.lumField = value;
			}
		}

		// Token: 0x04001896 RID: 6294
		private int hueField;

		// Token: 0x04001897 RID: 6295
		private int satField;

		// Token: 0x04001898 RID: 6296
		private int lumField;
	}
}
