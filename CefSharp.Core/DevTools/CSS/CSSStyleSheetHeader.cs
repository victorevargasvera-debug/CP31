using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FB RID: 763
	[global::System.Runtime.Serialization.DataContract]
	public class CSSStyleSheetHeader : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00019779 File Offset: 0x00017979
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00019781 File Offset: 0x00017981
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = true)]
		public string StyleSheetId { get; set; }

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0001978A File Offset: 0x0001798A
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00019792 File Offset: 0x00017992
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; set; }

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0001979B File Offset: 0x0001799B
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x000197A3 File Offset: 0x000179A3
		[global::System.Runtime.Serialization.DataMember(Name = "sourceURL", IsRequired = true)]
		public string SourceURL { get; set; }

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x000197AC File Offset: 0x000179AC
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x000197B4 File Offset: 0x000179B4
		[global::System.Runtime.Serialization.DataMember(Name = "sourceMapURL", IsRequired = false)]
		public string SourceMapURL { get; set; }

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000197BD File Offset: 0x000179BD
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000197D9 File Offset: 0x000179D9
		public global::CefSharp.DevTools.CSS.StyleSheetOrigin Origin
		{
			get
			{
				return (global::CefSharp.DevTools.CSS.StyleSheetOrigin)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.CSS.StyleSheetOrigin), this.origin);
			}
			set
			{
				this.origin = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000197EC File Offset: 0x000179EC
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x000197F4 File Offset: 0x000179F4
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		internal string origin { get; set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x000197FD File Offset: 0x000179FD
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00019805 File Offset: 0x00017A05
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x0001980E File Offset: 0x00017A0E
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00019816 File Offset: 0x00017A16
		[global::System.Runtime.Serialization.DataMember(Name = "ownerNode", IsRequired = false)]
		public int? OwnerNode { get; set; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x0001981F File Offset: 0x00017A1F
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x00019827 File Offset: 0x00017A27
		[global::System.Runtime.Serialization.DataMember(Name = "disabled", IsRequired = true)]
		public bool Disabled { get; set; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00019830 File Offset: 0x00017A30
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00019838 File Offset: 0x00017A38
		[global::System.Runtime.Serialization.DataMember(Name = "hasSourceURL", IsRequired = false)]
		public bool? HasSourceURL { get; set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00019841 File Offset: 0x00017A41
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x00019849 File Offset: 0x00017A49
		[global::System.Runtime.Serialization.DataMember(Name = "isInline", IsRequired = true)]
		public bool IsInline { get; set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00019852 File Offset: 0x00017A52
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0001985A File Offset: 0x00017A5A
		[global::System.Runtime.Serialization.DataMember(Name = "isMutable", IsRequired = true)]
		public bool IsMutable { get; set; }

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00019863 File Offset: 0x00017A63
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0001986B File Offset: 0x00017A6B
		[global::System.Runtime.Serialization.DataMember(Name = "isConstructed", IsRequired = true)]
		public bool IsConstructed { get; set; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00019874 File Offset: 0x00017A74
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0001987C File Offset: 0x00017A7C
		[global::System.Runtime.Serialization.DataMember(Name = "startLine", IsRequired = true)]
		public double StartLine { get; set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00019885 File Offset: 0x00017A85
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0001988D File Offset: 0x00017A8D
		[global::System.Runtime.Serialization.DataMember(Name = "startColumn", IsRequired = true)]
		public double StartColumn { get; set; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00019896 File Offset: 0x00017A96
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x0001989E File Offset: 0x00017A9E
		[global::System.Runtime.Serialization.DataMember(Name = "length", IsRequired = true)]
		public double Length { get; set; }

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000198A7 File Offset: 0x00017AA7
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x000198AF File Offset: 0x00017AAF
		[global::System.Runtime.Serialization.DataMember(Name = "endLine", IsRequired = true)]
		public double EndLine { get; set; }

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x000198B8 File Offset: 0x00017AB8
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x000198C0 File Offset: 0x00017AC0
		[global::System.Runtime.Serialization.DataMember(Name = "endColumn", IsRequired = true)]
		public double EndColumn { get; set; }

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000198C9 File Offset: 0x00017AC9
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x000198D1 File Offset: 0x00017AD1
		[global::System.Runtime.Serialization.DataMember(Name = "loadingFailed", IsRequired = false)]
		public bool? LoadingFailed { get; set; }
	}
}
