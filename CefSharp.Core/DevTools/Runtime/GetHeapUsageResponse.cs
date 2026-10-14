using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000055 RID: 85
	[global::System.Runtime.Serialization.DataContract]
	public class GetHeapUsageResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00005AF5 File Offset: 0x00003CF5
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00005AFD File Offset: 0x00003CFD
		[global::System.Runtime.Serialization.DataMember]
		internal double usedSize { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00005B06 File Offset: 0x00003D06
		public double UsedSize
		{
			get
			{
				return this.usedSize;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00005B0E File Offset: 0x00003D0E
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00005B16 File Offset: 0x00003D16
		[global::System.Runtime.Serialization.DataMember]
		internal double totalSize { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00005B1F File Offset: 0x00003D1F
		public double TotalSize
		{
			get
			{
				return this.totalSize;
			}
		}
	}
}
