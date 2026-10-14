using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D2 RID: 210
	[global::System.Runtime.Serialization.DataContract]
	public class AudioNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000098F0 File Offset: 0x00007AF0
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000098F8 File Offset: 0x00007AF8
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public string NodeId { get; set; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00009901 File Offset: 0x00007B01
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00009909 File Offset: 0x00007B09
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00009912 File Offset: 0x00007B12
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000991A File Offset: 0x00007B1A
		[global::System.Runtime.Serialization.DataMember(Name = "nodeType", IsRequired = true)]
		public string NodeType { get; set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00009923 File Offset: 0x00007B23
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000992B File Offset: 0x00007B2B
		[global::System.Runtime.Serialization.DataMember(Name = "numberOfInputs", IsRequired = true)]
		public double NumberOfInputs { get; set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00009934 File Offset: 0x00007B34
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0000993C File Offset: 0x00007B3C
		[global::System.Runtime.Serialization.DataMember(Name = "numberOfOutputs", IsRequired = true)]
		public double NumberOfOutputs { get; set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00009945 File Offset: 0x00007B45
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000994D File Offset: 0x00007B4D
		[global::System.Runtime.Serialization.DataMember(Name = "channelCount", IsRequired = true)]
		public double ChannelCount { get; set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00009956 File Offset: 0x00007B56
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00009972 File Offset: 0x00007B72
		public global::CefSharp.DevTools.WebAudio.ChannelCountMode ChannelCountMode
		{
			get
			{
				return (global::CefSharp.DevTools.WebAudio.ChannelCountMode)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAudio.ChannelCountMode), this.channelCountMode);
			}
			set
			{
				this.channelCountMode = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00009985 File Offset: 0x00007B85
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0000998D File Offset: 0x00007B8D
		[global::System.Runtime.Serialization.DataMember(Name = "channelCountMode", IsRequired = true)]
		internal string channelCountMode { get; set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00009996 File Offset: 0x00007B96
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000099B2 File Offset: 0x00007BB2
		public global::CefSharp.DevTools.WebAudio.ChannelInterpretation ChannelInterpretation
		{
			get
			{
				return (global::CefSharp.DevTools.WebAudio.ChannelInterpretation)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAudio.ChannelInterpretation), this.channelInterpretation);
			}
			set
			{
				this.channelInterpretation = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000099C5 File Offset: 0x00007BC5
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000099CD File Offset: 0x00007BCD
		[global::System.Runtime.Serialization.DataMember(Name = "channelInterpretation", IsRequired = true)]
		internal string channelInterpretation { get; set; }
	}
}
