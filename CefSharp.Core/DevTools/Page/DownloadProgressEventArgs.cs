using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019D RID: 413
	[global::System.Runtime.Serialization.DataContract]
	public class DownloadProgressEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		[global::System.Runtime.Serialization.DataMember(Name = "guid", IsRequired = true)]
		public string Guid { get; private set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0000E4B9 File Offset: 0x0000C6B9
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x0000E4C1 File Offset: 0x0000C6C1
		[global::System.Runtime.Serialization.DataMember(Name = "totalBytes", IsRequired = true)]
		public double TotalBytes { get; private set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0000E4CA File Offset: 0x0000C6CA
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x0000E4D2 File Offset: 0x0000C6D2
		[global::System.Runtime.Serialization.DataMember(Name = "receivedBytes", IsRequired = true)]
		public double ReceivedBytes { get; private set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0000E4DB File Offset: 0x0000C6DB
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		public global::CefSharp.DevTools.Page.DownloadProgressState State
		{
			get
			{
				return (global::CefSharp.DevTools.Page.DownloadProgressState)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.DownloadProgressState), this.state);
			}
			set
			{
				this.state = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0000E50A File Offset: 0x0000C70A
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0000E512 File Offset: 0x0000C712
		[global::System.Runtime.Serialization.DataMember(Name = "state", IsRequired = true)]
		internal string state { get; private set; }
	}
}
