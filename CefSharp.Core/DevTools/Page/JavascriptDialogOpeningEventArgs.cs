using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019F RID: 415
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptDialogOpeningEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0000E54D File Offset: 0x0000C74D
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x0000E555 File Offset: 0x0000C755
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0000E55E File Offset: 0x0000C75E
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0000E566 File Offset: 0x0000C766
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; private set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0000E56F File Offset: 0x0000C76F
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x0000E58B File Offset: 0x0000C78B
		public global::CefSharp.DevTools.Page.DialogType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Page.DialogType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.DialogType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0000E59E File Offset: 0x0000C79E
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x0000E5A6 File Offset: 0x0000C7A6
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0000E5AF File Offset: 0x0000C7AF
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		[global::System.Runtime.Serialization.DataMember(Name = "hasBrowserHandler", IsRequired = true)]
		public bool HasBrowserHandler { get; private set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[global::System.Runtime.Serialization.DataMember(Name = "defaultPrompt", IsRequired = false)]
		public string DefaultPrompt { get; private set; }
	}
}
