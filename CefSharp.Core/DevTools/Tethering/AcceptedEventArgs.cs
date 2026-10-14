using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tethering
{
	// Token: 0x020000FD RID: 253
	[global::System.Runtime.Serialization.DataContract]
	public class AcceptedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0000AC05 File Offset: 0x00008E05
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000AC0D File Offset: 0x00008E0D
		[global::System.Runtime.Serialization.DataMember(Name = "port", IsRequired = true)]
		public int Port { get; private set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0000AC16 File Offset: 0x00008E16
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0000AC1E File Offset: 0x00008E1E
		[global::System.Runtime.Serialization.DataMember(Name = "connectionId", IsRequired = true)]
		public string ConnectionId { get; private set; }
	}
}
