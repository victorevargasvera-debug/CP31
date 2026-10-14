using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BB RID: 699
	[global::System.Runtime.Serialization.DataContract]
	public class Rect : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0001796D File Offset: 0x00015B6D
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x00017975 File Offset: 0x00015B75
		[global::System.Runtime.Serialization.DataMember(Name = "x", IsRequired = true)]
		public double X { get; set; }

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0001797E File Offset: 0x00015B7E
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x00017986 File Offset: 0x00015B86
		[global::System.Runtime.Serialization.DataMember(Name = "y", IsRequired = true)]
		public double Y { get; set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0001798F File Offset: 0x00015B8F
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00017997 File Offset: 0x00015B97
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = true)]
		public double Width { get; set; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000179A0 File Offset: 0x00015BA0
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x000179A8 File Offset: 0x00015BA8
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = true)]
		public double Height { get; set; }
	}
}
