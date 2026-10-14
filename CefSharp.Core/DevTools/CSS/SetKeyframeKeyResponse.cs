using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000324 RID: 804
	[global::System.Runtime.Serialization.DataContract]
	public class SetKeyframeKeyResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0001A46C File Offset: 0x0001866C
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0001A474 File Offset: 0x00018674
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.Value keyText { get; set; }

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0001A47D File Offset: 0x0001867D
		public global::CefSharp.DevTools.CSS.Value KeyText
		{
			get
			{
				return this.keyText;
			}
		}
	}
}
