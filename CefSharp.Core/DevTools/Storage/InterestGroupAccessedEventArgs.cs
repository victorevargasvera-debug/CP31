using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000132 RID: 306
	[global::System.Runtime.Serialization.DataContract]
	public class InterestGroupAccessedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0000BF0B File Offset: 0x0000A10B
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0000BF13 File Offset: 0x0000A113
		[global::System.Runtime.Serialization.DataMember(Name = "accessTime", IsRequired = true)]
		public double AccessTime { get; private set; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0000BF1C File Offset: 0x0000A11C
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0000BF38 File Offset: 0x0000A138
		public global::CefSharp.DevTools.Storage.InterestGroupAccessType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Storage.InterestGroupAccessType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Storage.InterestGroupAccessType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0000BF4B File Offset: 0x0000A14B
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0000BF53 File Offset: 0x0000A153
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0000BF5C File Offset: 0x0000A15C
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x0000BF64 File Offset: 0x0000A164
		[global::System.Runtime.Serialization.DataMember(Name = "ownerOrigin", IsRequired = true)]
		public string OwnerOrigin { get; private set; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0000BF6D File Offset: 0x0000A16D
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0000BF75 File Offset: 0x0000A175
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; private set; }
	}
}
