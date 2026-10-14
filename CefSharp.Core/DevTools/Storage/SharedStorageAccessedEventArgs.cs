using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000133 RID: 307
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageAccessedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0000BF86 File Offset: 0x0000A186
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0000BF8E File Offset: 0x0000A18E
		[global::System.Runtime.Serialization.DataMember(Name = "accessTime", IsRequired = true)]
		public double AccessTime { get; private set; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0000BF97 File Offset: 0x0000A197
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x0000BFB3 File Offset: 0x0000A1B3
		public global::CefSharp.DevTools.Storage.SharedStorageAccessType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Storage.SharedStorageAccessType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Storage.SharedStorageAccessType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0000BFC6 File Offset: 0x0000A1C6
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0000BFCE File Offset: 0x0000A1CE
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0000BFDF File Offset: 0x0000A1DF
		[global::System.Runtime.Serialization.DataMember(Name = "mainFrameId", IsRequired = true)]
		public string MainFrameId { get; private set; }

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		[global::System.Runtime.Serialization.DataMember(Name = "ownerOrigin", IsRequired = true)]
		public string OwnerOrigin { get; private set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0000BFF9 File Offset: 0x0000A1F9
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0000C001 File Offset: 0x0000A201
		[global::System.Runtime.Serialization.DataMember(Name = "params", IsRequired = true)]
		public global::CefSharp.DevTools.Storage.SharedStorageAccessParams Params { get; private set; }
	}
}
