using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000036 RID: 54
	[global::System.Runtime.Serialization.DataContract]
	public class RemoteObject : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00005212 File Offset: 0x00003412
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000522E File Offset: 0x0000342E
		public global::CefSharp.DevTools.Runtime.RemoteObjectType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.RemoteObjectType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.RemoteObjectType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00005241 File Offset: 0x00003441
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00005249 File Offset: 0x00003449
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00005252 File Offset: 0x00003452
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000526E File Offset: 0x0000346E
		public global::CefSharp.DevTools.Runtime.RemoteObjectSubtype? Subtype
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.RemoteObjectSubtype?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.RemoteObjectSubtype?), this.subtype);
			}
			set
			{
				this.subtype = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00005281 File Offset: 0x00003481
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00005289 File Offset: 0x00003489
		[global::System.Runtime.Serialization.DataMember(Name = "subtype", IsRequired = false)]
		internal string subtype { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00005292 File Offset: 0x00003492
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000529A File Offset: 0x0000349A
		[global::System.Runtime.Serialization.DataMember(Name = "className", IsRequired = false)]
		public string ClassName { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000052A3 File Offset: 0x000034A3
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000052AB File Offset: 0x000034AB
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public object Value { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000052B4 File Offset: 0x000034B4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000052BC File Offset: 0x000034BC
		[global::System.Runtime.Serialization.DataMember(Name = "unserializableValue", IsRequired = false)]
		public string UnserializableValue { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000052C5 File Offset: 0x000034C5
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000052CD File Offset: 0x000034CD
		[global::System.Runtime.Serialization.DataMember(Name = "description", IsRequired = false)]
		public string Description { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000052D6 File Offset: 0x000034D6
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000052DE File Offset: 0x000034DE
		[global::System.Runtime.Serialization.DataMember(Name = "webDriverValue", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.WebDriverValue WebDriverValue { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000052E7 File Offset: 0x000034E7
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000052EF File Offset: 0x000034EF
		[global::System.Runtime.Serialization.DataMember(Name = "objectId", IsRequired = false)]
		public string ObjectId { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00005300 File Offset: 0x00003500
		[global::System.Runtime.Serialization.DataMember(Name = "preview", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.ObjectPreview Preview { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00005309 File Offset: 0x00003509
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00005311 File Offset: 0x00003511
		[global::System.Runtime.Serialization.DataMember(Name = "customPreview", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.CustomPreview CustomPreview { get; set; }
	}
}
