using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D0 RID: 208
	[global::System.Runtime.Serialization.DataContract]
	public class BaseAudioContext : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000097E9 File Offset: 0x000079E9
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x000097F1 File Offset: 0x000079F1
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000097FA File Offset: 0x000079FA
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00009816 File Offset: 0x00007A16
		public global::CefSharp.DevTools.WebAudio.ContextType ContextType
		{
			get
			{
				return (global::CefSharp.DevTools.WebAudio.ContextType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAudio.ContextType), this.contextType);
			}
			set
			{
				this.contextType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00009829 File Offset: 0x00007A29
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00009831 File Offset: 0x00007A31
		[global::System.Runtime.Serialization.DataMember(Name = "contextType", IsRequired = true)]
		internal string contextType { get; set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0000983A File Offset: 0x00007A3A
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00009856 File Offset: 0x00007A56
		public global::CefSharp.DevTools.WebAudio.ContextState ContextState
		{
			get
			{
				return (global::CefSharp.DevTools.WebAudio.ContextState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAudio.ContextState), this.contextState);
			}
			set
			{
				this.contextState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00009869 File Offset: 0x00007A69
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x00009871 File Offset: 0x00007A71
		[global::System.Runtime.Serialization.DataMember(Name = "contextState", IsRequired = true)]
		internal string contextState { get; set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0000987A File Offset: 0x00007A7A
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00009882 File Offset: 0x00007A82
		[global::System.Runtime.Serialization.DataMember(Name = "realtimeData", IsRequired = false)]
		public global::CefSharp.DevTools.WebAudio.ContextRealtimeData RealtimeData { get; set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0000988B File Offset: 0x00007A8B
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00009893 File Offset: 0x00007A93
		[global::System.Runtime.Serialization.DataMember(Name = "callbackBufferSize", IsRequired = true)]
		public double CallbackBufferSize { get; set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000989C File Offset: 0x00007A9C
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000098A4 File Offset: 0x00007AA4
		[global::System.Runtime.Serialization.DataMember(Name = "maxOutputChannelCount", IsRequired = true)]
		public double MaxOutputChannelCount { get; set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000098AD File Offset: 0x00007AAD
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000098B5 File Offset: 0x00007AB5
		[global::System.Runtime.Serialization.DataMember(Name = "sampleRate", IsRequired = true)]
		public double SampleRate { get; set; }
	}
}
