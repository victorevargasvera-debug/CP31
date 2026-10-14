using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003A RID: 58
	[global::System.Runtime.Serialization.DataContract]
	public class ObjectPreview : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000534C File Offset: 0x0000354C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00005368 File Offset: 0x00003568
		public global::CefSharp.DevTools.Runtime.ObjectPreviewType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.ObjectPreviewType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.ObjectPreviewType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000537B File Offset: 0x0000357B
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00005383 File Offset: 0x00003583
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000538C File Offset: 0x0000358C
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000053A8 File Offset: 0x000035A8
		public global::CefSharp.DevTools.Runtime.ObjectPreviewSubtype? Subtype
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.ObjectPreviewSubtype?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.ObjectPreviewSubtype?), this.subtype);
			}
			set
			{
				this.subtype = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000053BB File Offset: 0x000035BB
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000053C3 File Offset: 0x000035C3
		[global::System.Runtime.Serialization.DataMember(Name = "subtype", IsRequired = false)]
		internal string subtype { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000053CC File Offset: 0x000035CC
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000053D4 File Offset: 0x000035D4
		[global::System.Runtime.Serialization.DataMember(Name = "description", IsRequired = false)]
		public string Description { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000053DD File Offset: 0x000035DD
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000053E5 File Offset: 0x000035E5
		[global::System.Runtime.Serialization.DataMember(Name = "overflow", IsRequired = true)]
		public bool Overflow { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000053EE File Offset: 0x000035EE
		// (set) Token: 0x06000272 RID: 626 RVA: 0x000053F6 File Offset: 0x000035F6
		[global::System.Runtime.Serialization.DataMember(Name = "properties", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.PropertyPreview> Properties { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000053FF File Offset: 0x000035FF
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00005407 File Offset: 0x00003607
		[global::System.Runtime.Serialization.DataMember(Name = "entries", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.EntryPreview> Entries { get; set; }
	}
}
