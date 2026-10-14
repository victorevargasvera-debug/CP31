using System;
using System.Net.Http;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000006 RID: 6
	public interface IHttpPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe
	{
		// Token: 0x06000009 RID: 9
		byte[] RequestData(byte[] buffer, global::System.Net.Http.HttpContent content, int start, int length, int timeout);
	}
}
