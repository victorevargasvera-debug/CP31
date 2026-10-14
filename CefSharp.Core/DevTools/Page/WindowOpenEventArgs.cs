using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A6 RID: 422
	[global::System.Runtime.Serialization.DataContract]
	public class WindowOpenEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0000E708 File Offset: 0x0000C908
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0000E710 File Offset: 0x0000C910
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0000E719 File Offset: 0x0000C919
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0000E721 File Offset: 0x0000C921
		[global::System.Runtime.Serialization.DataMember(Name = "windowName", IsRequired = true)]
		public string WindowName { get; private set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0000E72A File Offset: 0x0000C92A
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x0000E732 File Offset: 0x0000C932
		[global::System.Runtime.Serialization.DataMember(Name = "windowFeatures", IsRequired = true)]
		public string[] WindowFeatures { get; private set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0000E73B File Offset: 0x0000C93B
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0000E743 File Offset: 0x0000C943
		[global::System.Runtime.Serialization.DataMember(Name = "userGesture", IsRequired = true)]
		public bool UserGesture { get; private set; }
	}
}
