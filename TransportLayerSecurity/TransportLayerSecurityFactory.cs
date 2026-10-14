using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200001F RID: 31
	public class TransportLayerSecurityFactory
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000A29C File Offset: 0x0000849C
		public static global::Motorola.Common.Communication.TLS.ITransportLayerSecurity Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			short num = (short)790953984;
			short num2 = num;
			num = (short)1995208500;
			short num3 = num;
			num = (short)469989172;
			switch (num3 == num)
			{
			}
			num = (short)1815478273;
			if (num != 0)
			{
			}
			num = (short)1741553664;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter(pipe);
		}
	}
}
