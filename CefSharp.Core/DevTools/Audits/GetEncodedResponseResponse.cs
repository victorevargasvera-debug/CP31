using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000370 RID: 880
	[global::System.Runtime.Serialization.DataContract]
	public class GetEncodedResponseResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0001C2DF File Offset: 0x0001A4DF
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0001C2E7 File Offset: 0x0001A4E7
		[global::System.Runtime.Serialization.DataMember]
		internal string body { get; set; }

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		public byte[] Body
		{
			get
			{
				return base.Convert(this.body);
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0001C2FE File Offset: 0x0001A4FE
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0001C306 File Offset: 0x0001A506
		[global::System.Runtime.Serialization.DataMember]
		internal int originalSize { get; set; }

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0001C30F File Offset: 0x0001A50F
		public int OriginalSize
		{
			get
			{
				return this.originalSize;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0001C317 File Offset: 0x0001A517
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0001C31F File Offset: 0x0001A51F
		[global::System.Runtime.Serialization.DataMember]
		internal int encodedSize { get; set; }

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0001C328 File Offset: 0x0001A528
		public int EncodedSize
		{
			get
			{
				return this.encodedSize;
			}
		}
	}
}
