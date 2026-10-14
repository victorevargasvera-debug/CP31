using System;
using System.IO;
using Org.BouncyCastle.Security;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000026 RID: 38
	public class TlsConnectClientFactory : global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public global::Motorola.Common.Communication.TLS.TlsClientProtocol Create(global::System.IO.Stream stream)
		{
			short num = (short)1248687784;
			short num2 = num;
			num = (short)382236328;
			switch (num2 == num)
			{
			}
			num = (short)2135556096;
			if (num != 0)
			{
			}
			num = (short)160104448;
			short num3 = num;
			num = (short)2142175233;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.TLS.TlsClientProtocol(stream, new global::Org.BouncyCastle.Security.SecureRandom());
		}
	}
}
