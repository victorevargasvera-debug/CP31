using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000375 RID: 885
	[global::System.Runtime.Serialization.DataContract]
	public class AnimationEffect : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0001C55D File Offset: 0x0001A75D
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0001C565 File Offset: 0x0001A765
		[global::System.Runtime.Serialization.DataMember(Name = "delay", IsRequired = true)]
		public double Delay { get; set; }

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0001C56E File Offset: 0x0001A76E
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0001C576 File Offset: 0x0001A776
		[global::System.Runtime.Serialization.DataMember(Name = "endDelay", IsRequired = true)]
		public double EndDelay { get; set; }

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0001C57F File Offset: 0x0001A77F
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0001C587 File Offset: 0x0001A787
		[global::System.Runtime.Serialization.DataMember(Name = "iterationStart", IsRequired = true)]
		public double IterationStart { get; set; }

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0001C590 File Offset: 0x0001A790
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0001C598 File Offset: 0x0001A798
		[global::System.Runtime.Serialization.DataMember(Name = "iterations", IsRequired = true)]
		public double Iterations { get; set; }

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0001C5A1 File Offset: 0x0001A7A1
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0001C5A9 File Offset: 0x0001A7A9
		[global::System.Runtime.Serialization.DataMember(Name = "duration", IsRequired = true)]
		public double Duration { get; set; }

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0001C5B2 File Offset: 0x0001A7B2
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0001C5BA File Offset: 0x0001A7BA
		[global::System.Runtime.Serialization.DataMember(Name = "direction", IsRequired = true)]
		public string Direction { get; set; }

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0001C5C3 File Offset: 0x0001A7C3
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0001C5CB File Offset: 0x0001A7CB
		[global::System.Runtime.Serialization.DataMember(Name = "fill", IsRequired = true)]
		public string Fill { get; set; }

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0001C5D4 File Offset: 0x0001A7D4
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = false)]
		public int? BackendNodeId { get; set; }

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0001C5E5 File Offset: 0x0001A7E5
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0001C5ED File Offset: 0x0001A7ED
		[global::System.Runtime.Serialization.DataMember(Name = "keyframesRule", IsRequired = false)]
		public global::CefSharp.DevTools.Animation.KeyframesRule KeyframesRule { get; set; }

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0001C5F6 File Offset: 0x0001A7F6
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0001C5FE File Offset: 0x0001A7FE
		[global::System.Runtime.Serialization.DataMember(Name = "easing", IsRequired = true)]
		public string Easing { get; set; }
	}
}
