using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000218 RID: 536
	[global::System.Runtime.Serialization.DataContract]
	public class DataReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00011F85 File Offset: 0x00010185
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x00011F8D File Offset: 0x0001018D
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00011F96 File Offset: 0x00010196
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x00011F9E File Offset: 0x0001019E
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00011FA7 File Offset: 0x000101A7
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x00011FAF File Offset: 0x000101AF
		[global::System.Runtime.Serialization.DataMember(Name = "dataLength", IsRequired = true)]
		public int DataLength { get; private set; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x00011FB8 File Offset: 0x000101B8
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x00011FC0 File Offset: 0x000101C0
		[global::System.Runtime.Serialization.DataMember(Name = "encodedDataLength", IsRequired = true)]
		public int EncodedDataLength { get; private set; }
	}
}
