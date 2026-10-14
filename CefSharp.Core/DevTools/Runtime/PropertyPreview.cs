using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003D RID: 61
	[global::System.Runtime.Serialization.DataContract]
	public class PropertyPreview : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00005418 File Offset: 0x00003618
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00005420 File Offset: 0x00003620
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00005429 File Offset: 0x00003629
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00005445 File Offset: 0x00003645
		public global::CefSharp.DevTools.Runtime.PropertyPreviewType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.PropertyPreviewType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.PropertyPreviewType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00005458 File Offset: 0x00003658
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00005460 File Offset: 0x00003660
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00005469 File Offset: 0x00003669
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00005471 File Offset: 0x00003671
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public string Value { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000547A File Offset: 0x0000367A
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00005482 File Offset: 0x00003682
		[global::System.Runtime.Serialization.DataMember(Name = "valuePreview", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.ObjectPreview ValuePreview { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000548B File Offset: 0x0000368B
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000054A7 File Offset: 0x000036A7
		public global::CefSharp.DevTools.Runtime.PropertyPreviewSubtype? Subtype
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.PropertyPreviewSubtype?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.PropertyPreviewSubtype?), this.subtype);
			}
			set
			{
				this.subtype = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000054BA File Offset: 0x000036BA
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000054C2 File Offset: 0x000036C2
		[global::System.Runtime.Serialization.DataMember(Name = "subtype", IsRequired = false)]
		internal string subtype { get; set; }
	}
}
