using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017E RID: 382
	[global::System.Runtime.Serialization.DataContract]
	public class Viewport : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0000DED2 File Offset: 0x0000C0D2
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0000DEDA File Offset: 0x0000C0DA
		[global::System.Runtime.Serialization.DataMember(Name = "x", IsRequired = true)]
		public double X { get; set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0000DEEB File Offset: 0x0000C0EB
		[global::System.Runtime.Serialization.DataMember(Name = "y", IsRequired = true)]
		public double Y { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0000DEFC File Offset: 0x0000C0FC
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = true)]
		public double Width { get; set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0000DF05 File Offset: 0x0000C105
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0000DF0D File Offset: 0x0000C10D
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = true)]
		public double Height { get; set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0000DF16 File Offset: 0x0000C116
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0000DF1E File Offset: 0x0000C11E
		[global::System.Runtime.Serialization.DataMember(Name = "scale", IsRequired = true)]
		public double Scale { get; set; }

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0000DF27 File Offset: 0x0000C127
		public Viewport()
		{
			this.Scale = 1.0;
		}
	}
}
