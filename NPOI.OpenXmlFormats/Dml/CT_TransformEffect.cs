using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000310 RID: 784
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TransformEffect
	{
		// Token: 0x06001F15 RID: 7957 RVA: 0x0005370F File Offset: 0x0005190F
		public CT_TransformEffect()
		{
			this.sxField = 100000;
			this.syField = 100000;
			this.kxField = 0;
			this.kyField = 0;
			this.txField = 0L;
			this.tyField = 0L;
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0005374B File Offset: 0x0005194B
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00053753 File Offset: 0x00051953
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int sx
		{
			get
			{
				return this.sxField;
			}
			set
			{
				this.sxField = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0005375C File Offset: 0x0005195C
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00053764 File Offset: 0x00051964
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int sy
		{
			get
			{
				return this.syField;
			}
			set
			{
				this.syField = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0005376D File Offset: 0x0005196D
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00053775 File Offset: 0x00051975
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int kx
		{
			get
			{
				return this.kxField;
			}
			set
			{
				this.kxField = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0005377E File Offset: 0x0005197E
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00053786 File Offset: 0x00051986
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int ky
		{
			get
			{
				return this.kyField;
			}
			set
			{
				this.kyField = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0005378F File Offset: 0x0005198F
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00053797 File Offset: 0x00051997
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long tx
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000537A0 File Offset: 0x000519A0
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x000537A8 File Offset: 0x000519A8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long ty
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

		// Token: 0x04001845 RID: 6213
		private int sxField;

		// Token: 0x04001846 RID: 6214
		private int syField;

		// Token: 0x04001847 RID: 6215
		private int kxField;

		// Token: 0x04001848 RID: 6216
		private int kyField;

		// Token: 0x04001849 RID: 6217
		private long txField;

		// Token: 0x0400184A RID: 6218
		private long tyField;
	}
}
