using System;
using System.IO;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000020 RID: 32
	public interface ICommunicationPipe
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000FE RID: 254
		int AvailableReadBytesCount { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		int ReceiveTimeout { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000101 RID: 257
		// (set) Token: 0x06000102 RID: 258
		bool IsOpen { get; set; }

		// Token: 0x06000103 RID: 259
		void OpenPort(int timeout);

		// Token: 0x06000104 RID: 260
		void ClosePort();

		// Token: 0x06000105 RID: 261
		void SendData(byte[] buffer, int start, int length);

		// Token: 0x06000106 RID: 262
		byte[] ReceiveData();

		// Token: 0x06000107 RID: 263
		byte[] ReceiveData(int timeout);

		// Token: 0x06000108 RID: 264
		int ReceiveData(byte[] buffer, int start);

		// Token: 0x06000109 RID: 265
		int ReceiveData(byte[] buffer, int start, int timeout);

		// Token: 0x0600010A RID: 266
		int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength);

		// Token: 0x0600010B RID: 267
		byte[] RequestData(byte[] buffer, int start, int length);

		// Token: 0x0600010C RID: 268
		byte[] RequestData(byte[] buffer, int start, int length, int timeout);

		// Token: 0x0600010D RID: 269
		byte[] PeekData(int length, int timeOut);

		// Token: 0x0600010E RID: 270
		global::System.IO.Stream GetStream();
	}
}
