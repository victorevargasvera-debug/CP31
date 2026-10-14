using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public interface IMessage
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17
		// (set) Token: 0x06000012 RID: 18
		int ReadTimeout { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19
		// (set) Token: 0x06000014 RID: 20
		bool hasReply { get; set; }

		// Token: 0x06000015 RID: 21
		int BuildCommandMessage(byte[] sendBuffer);

		// Token: 0x06000016 RID: 22
		void DecodeReplyMessage(byte[] replyBuffer, int offset, int length);
	}
}
