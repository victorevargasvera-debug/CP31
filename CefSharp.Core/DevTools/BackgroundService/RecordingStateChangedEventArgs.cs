using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000345 RID: 837
	[global::System.Runtime.Serialization.DataContract]
	public class RecordingStateChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0001B664 File Offset: 0x00019864
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0001B66C File Offset: 0x0001986C
		[global::System.Runtime.Serialization.DataMember(Name = "isRecording", IsRequired = true)]
		public bool IsRecording { get; private set; }

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0001B675 File Offset: 0x00019875
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0001B691 File Offset: 0x00019891
		public global::CefSharp.DevTools.BackgroundService.ServiceName Service
		{
			get
			{
				return (global::CefSharp.DevTools.BackgroundService.ServiceName)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.BackgroundService.ServiceName), this.service);
			}
			set
			{
				this.service = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0001B6A4 File Offset: 0x000198A4
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0001B6AC File Offset: 0x000198AC
		[global::System.Runtime.Serialization.DataMember(Name = "service", IsRequired = true)]
		internal string service { get; private set; }
	}
}
