using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeadlessExperimental
{
	// Token: 0x02000281 RID: 641
	[global::System.Runtime.Serialization.DataContract]
	public class BeginFrameResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000159B6 File Offset: 0x00013BB6
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x000159BE File Offset: 0x00013BBE
		[global::System.Runtime.Serialization.DataMember]
		internal bool hasDamage { get; set; }

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000159C7 File Offset: 0x00013BC7
		public bool HasDamage
		{
			get
			{
				return this.hasDamage;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000159CF File Offset: 0x00013BCF
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x000159D7 File Offset: 0x00013BD7
		[global::System.Runtime.Serialization.DataMember]
		internal string screenshotData { get; set; }

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x000159E0 File Offset: 0x00013BE0
		public byte[] ScreenshotData
		{
			get
			{
				return base.Convert(this.screenshotData);
			}
		}
	}
}
