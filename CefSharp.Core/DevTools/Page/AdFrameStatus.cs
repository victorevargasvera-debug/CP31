using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000163 RID: 355
	[global::System.Runtime.Serialization.DataContract]
	public class AdFrameStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0000D714 File Offset: 0x0000B914
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0000D730 File Offset: 0x0000B930
		public global::CefSharp.DevTools.Page.AdFrameType AdFrameType
		{
			get
			{
				return (global::CefSharp.DevTools.Page.AdFrameType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.AdFrameType), this.adFrameType);
			}
			set
			{
				this.adFrameType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0000D743 File Offset: 0x0000B943
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x0000D74B File Offset: 0x0000B94B
		[global::System.Runtime.Serialization.DataMember(Name = "adFrameType", IsRequired = true)]
		internal string adFrameType { get; set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0000D754 File Offset: 0x0000B954
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x0000D770 File Offset: 0x0000B970
		public global::CefSharp.DevTools.Page.AdFrameExplanation[] Explanations
		{
			get
			{
				return (global::CefSharp.DevTools.Page.AdFrameExplanation[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.AdFrameExplanation[]), this.explanations);
			}
			set
			{
				this.explanations = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0000D77E File Offset: 0x0000B97E
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0000D786 File Offset: 0x0000B986
		[global::System.Runtime.Serialization.DataMember(Name = "explanations", IsRequired = false)]
		internal string explanations { get; set; }
	}
}
