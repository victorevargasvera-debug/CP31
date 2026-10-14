using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017D RID: 381
	[global::System.Runtime.Serialization.DataContract]
	public class VisualViewport : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0000DE42 File Offset: 0x0000C042
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0000DE4A File Offset: 0x0000C04A
		[global::System.Runtime.Serialization.DataMember(Name = "offsetX", IsRequired = true)]
		public double OffsetX { get; set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0000DE53 File Offset: 0x0000C053
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000DE5B File Offset: 0x0000C05B
		[global::System.Runtime.Serialization.DataMember(Name = "offsetY", IsRequired = true)]
		public double OffsetY { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0000DE64 File Offset: 0x0000C064
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0000DE6C File Offset: 0x0000C06C
		[global::System.Runtime.Serialization.DataMember(Name = "pageX", IsRequired = true)]
		public double PageX { get; set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0000DE75 File Offset: 0x0000C075
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000DE7D File Offset: 0x0000C07D
		[global::System.Runtime.Serialization.DataMember(Name = "pageY", IsRequired = true)]
		public double PageY { get; set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0000DE86 File Offset: 0x0000C086
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0000DE8E File Offset: 0x0000C08E
		[global::System.Runtime.Serialization.DataMember(Name = "clientWidth", IsRequired = true)]
		public double ClientWidth { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0000DE97 File Offset: 0x0000C097
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0000DE9F File Offset: 0x0000C09F
		[global::System.Runtime.Serialization.DataMember(Name = "clientHeight", IsRequired = true)]
		public double ClientHeight { get; set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		[global::System.Runtime.Serialization.DataMember(Name = "scale", IsRequired = true)]
		public double Scale { get; set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0000DEB9 File Offset: 0x0000C0B9
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0000DEC1 File Offset: 0x0000C0C1
		[global::System.Runtime.Serialization.DataMember(Name = "zoom", IsRequired = false)]
		public double? Zoom { get; set; }
	}
}
