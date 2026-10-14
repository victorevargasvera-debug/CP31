using System;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces
{
	// Token: 0x02000029 RID: 41
	public interface IOnServerKeyExchangeSubscriber
	{
		// Token: 0x060000E7 RID: 231
		void OnServerKeyExchangeMessage(byte[] hintBytes);
	}
}
