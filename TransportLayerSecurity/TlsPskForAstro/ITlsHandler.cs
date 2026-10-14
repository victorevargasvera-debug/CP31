using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000024 RID: 36
	public interface ITlsHandler
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CB RID: 203
		// (set) Token: 0x060000CC RID: 204
		bool IsSecurityLayerInitialized { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CD RID: 205
		global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Pipe { get; }

		// Token: 0x060000CE RID: 206
		void Connect(int timeout = -1);

		// Token: 0x060000CF RID: 207
		int ReceiveData(byte[] buffer, int length);

		// Token: 0x060000D0 RID: 208
		int ReceiveData(byte[] buffer, int start, int timeout);

		// Token: 0x060000D1 RID: 209
		int ReceiveData(byte[] buffer, int start, int timeout, int expectedLength);

		// Token: 0x060000D2 RID: 210
		int SendData(byte[] buffer, int len);

		// Token: 0x060000D3 RID: 211
		void SendData(byte[] buffer, int offset, int length);

		// Token: 0x060000D4 RID: 212
		void Uninitialize();
	}
}
