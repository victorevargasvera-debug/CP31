using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D3 RID: 211
	[global::System.Runtime.Serialization.DataContract]
	public class AudioParam : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000099DE File Offset: 0x00007BDE
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x000099E6 File Offset: 0x00007BE6
		[global::System.Runtime.Serialization.DataMember(Name = "paramId", IsRequired = true)]
		public string ParamId { get; set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000099EF File Offset: 0x00007BEF
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x000099F7 File Offset: 0x00007BF7
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public string NodeId { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00009A00 File Offset: 0x00007C00
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00009A08 File Offset: 0x00007C08
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00009A11 File Offset: 0x00007C11
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00009A19 File Offset: 0x00007C19
		[global::System.Runtime.Serialization.DataMember(Name = "paramType", IsRequired = true)]
		public string ParamType { get; set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00009A22 File Offset: 0x00007C22
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00009A3E File Offset: 0x00007C3E
		public global::CefSharp.DevTools.WebAudio.AutomationRate Rate
		{
			get
			{
				return (global::CefSharp.DevTools.WebAudio.AutomationRate)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAudio.AutomationRate), this.rate);
			}
			set
			{
				this.rate = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00009A51 File Offset: 0x00007C51
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00009A59 File Offset: 0x00007C59
		[global::System.Runtime.Serialization.DataMember(Name = "rate", IsRequired = true)]
		internal string rate { get; set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00009A62 File Offset: 0x00007C62
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00009A6A File Offset: 0x00007C6A
		[global::System.Runtime.Serialization.DataMember(Name = "defaultValue", IsRequired = true)]
		public double DefaultValue { get; set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00009A73 File Offset: 0x00007C73
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00009A7B File Offset: 0x00007C7B
		[global::System.Runtime.Serialization.DataMember(Name = "minValue", IsRequired = true)]
		public double MinValue { get; set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00009A84 File Offset: 0x00007C84
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00009A8C File Offset: 0x00007C8C
		[global::System.Runtime.Serialization.DataMember(Name = "maxValue", IsRequired = true)]
		public double MaxValue { get; set; }
	}
}
