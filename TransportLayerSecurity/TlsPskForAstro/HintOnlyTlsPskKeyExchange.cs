using System;
using System.Collections;
using System.IO;
using Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000022 RID: 34
	public class HintOnlyTlsPskKeyExchange : global::Org.BouncyCastle.Crypto.Tls.TlsPskKeyExchange
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000BE68 File Offset: 0x0000A068
		public HintOnlyTlsPskKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces.IOnServerKeyExchangeSubscriber subscriber, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(keyExchange, supportedSignatureAlgorithms, null, pskIdentityManager, dhParameters, namedCurves, clientECPointFormats, serverECPointFormats)
		{
			this.a = subscriber;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000BE90 File Offset: 0x0000A090
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F6;
				case 1:
					if (this.a != null)
					{
						num2 = (short)1844257869;
						short num3 = num2;
						num2 = (short)1390158925;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F6;
						case 1:
							break;
						default:
						{
							num2 = (short)776142848;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)2126774272;
						if (num2 != 0)
						{
						}
						num2 = (short)1338638336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
				IL_F6:
				this.a.OnServerKeyExchangeMessage(this.mPskIdentityHint);
				num2 = (short)535298050;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)936640513;
			if (num2 != 0)
			{
			}
			base.ProcessServerKeyExchange(input);
			num2 = (short)963641345;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000055 RID: 85
		private readonly global::Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces.IOnServerKeyExchangeSubscriber a;
	}
}
