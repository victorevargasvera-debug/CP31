using System;
using System.IO;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000246 RID: 582
	internal class GetSessionHeadersCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x00066B20 File Offset: 0x00064D20
		public GetSessionHeadersCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.GetSessionHeaders;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00066B3C File Offset: 0x00064D3C
		protected override void OnWrite(global::System.IO.Stream stream)
		{
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00066B40 File Offset: 0x00064D40
		protected override void OnRead(global::System.IO.Stream stream)
		{
		}
	}
}
