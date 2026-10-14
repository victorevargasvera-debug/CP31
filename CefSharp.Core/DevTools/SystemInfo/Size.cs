using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x02000114 RID: 276
	[global::System.Runtime.Serialization.DataContract]
	public class Size : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0000B77A File Offset: 0x0000997A
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x0000B782 File Offset: 0x00009982
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = true)]
		public int Width { get; set; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0000B78B File Offset: 0x0000998B
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x0000B793 File Offset: 0x00009993
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = true)]
		public int Height { get; set; }
	}
}
