using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000374 RID: 884
	[global::System.Runtime.Serialization.DataContract]
	public class Animation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0001C47C File Offset: 0x0001A67C
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0001C484 File Offset: 0x0001A684
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0001C48D File Offset: 0x0001A68D
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0001C495 File Offset: 0x0001A695
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0001C49E File Offset: 0x0001A69E
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0001C4A6 File Offset: 0x0001A6A6
		[global::System.Runtime.Serialization.DataMember(Name = "pausedState", IsRequired = true)]
		public bool PausedState { get; set; }

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0001C4AF File Offset: 0x0001A6AF
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0001C4B7 File Offset: 0x0001A6B7
		[global::System.Runtime.Serialization.DataMember(Name = "playState", IsRequired = true)]
		public string PlayState { get; set; }

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0001C4C8 File Offset: 0x0001A6C8
		[global::System.Runtime.Serialization.DataMember(Name = "playbackRate", IsRequired = true)]
		public double PlaybackRate { get; set; }

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0001C4D1 File Offset: 0x0001A6D1
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0001C4D9 File Offset: 0x0001A6D9
		[global::System.Runtime.Serialization.DataMember(Name = "startTime", IsRequired = true)]
		public double StartTime { get; set; }

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0001C4E2 File Offset: 0x0001A6E2
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0001C4EA File Offset: 0x0001A6EA
		[global::System.Runtime.Serialization.DataMember(Name = "currentTime", IsRequired = true)]
		public double CurrentTime { get; set; }

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0001C4F3 File Offset: 0x0001A6F3
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0001C50F File Offset: 0x0001A70F
		public global::CefSharp.DevTools.Animation.AnimationType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Animation.AnimationType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Animation.AnimationType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0001C522 File Offset: 0x0001A722
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0001C52A File Offset: 0x0001A72A
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0001C533 File Offset: 0x0001A733
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0001C53B File Offset: 0x0001A73B
		[global::System.Runtime.Serialization.DataMember(Name = "source", IsRequired = false)]
		public global::CefSharp.DevTools.Animation.AnimationEffect Source { get; set; }

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0001C544 File Offset: 0x0001A744
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0001C54C File Offset: 0x0001A74C
		[global::System.Runtime.Serialization.DataMember(Name = "cssId", IsRequired = false)]
		public string CssId { get; set; }
	}
}
