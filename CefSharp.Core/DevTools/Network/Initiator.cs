using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F7 RID: 503
	[global::System.Runtime.Serialization.DataContract]
	public class Initiator : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00011413 File Offset: 0x0000F613
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x0001142F File Offset: 0x0000F62F
		public global::CefSharp.DevTools.Network.InitiatorType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.InitiatorType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.InitiatorType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00011442 File Offset: 0x0000F642
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x0001144A File Offset: 0x0000F64A
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00011453 File Offset: 0x0000F653
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x0001145B File Offset: 0x0000F65B
		[global::System.Runtime.Serialization.DataMember(Name = "stack", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace Stack { get; set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00011464 File Offset: 0x0000F664
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0001146C File Offset: 0x0000F66C
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00011475 File Offset: 0x0000F675
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0001147D File Offset: 0x0000F67D
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = false)]
		public double? LineNumber { get; set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00011486 File Offset: 0x0000F686
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0001148E File Offset: 0x0000F68E
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = false)]
		public double? ColumnNumber { get; set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00011497 File Offset: 0x0000F697
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0001149F File Offset: 0x0000F69F
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = false)]
		public string RequestId { get; set; }
	}
}
