using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000190 RID: 400
	[global::System.Runtime.Serialization.DataContract]
	public class FileChooserOpenedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0000E17C File Offset: 0x0000C37C
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0000E184 File Offset: 0x0000C384
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0000E18D File Offset: 0x0000C38D
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0000E1A9 File Offset: 0x0000C3A9
		public global::CefSharp.DevTools.Page.FileChooserOpenedMode Mode
		{
			get
			{
				return (global::CefSharp.DevTools.Page.FileChooserOpenedMode)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.FileChooserOpenedMode), this.mode);
			}
			set
			{
				this.mode = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0000E1BC File Offset: 0x0000C3BC
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		[global::System.Runtime.Serialization.DataMember(Name = "mode", IsRequired = true)]
		internal string mode { get; private set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0000E1CD File Offset: 0x0000C3CD
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0000E1D5 File Offset: 0x0000C3D5
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = false)]
		public int? BackendNodeId { get; private set; }
	}
}
