using System;
using Motorola.Common.Communication.TLS.OpenSslCompatibility;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000013 RID: 19
	internal class TlsCipherFactory : global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000502C File Offset: 0x0000322C
		public TlsCipherFactory(bool oldOpenSslCompatibilityMode = false)
		{
			if (oldOpenSslCompatibilityMode)
			{
				this.a = true;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005050 File Offset: 0x00003250
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateAESCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			short num = (short)2008741287;
			short num2 = num;
			num = (short)2135291303;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2109603840;
				short num3 = num;
				num = (short)100532224;
				if (num != 0)
				{
				}
				num = (short)19726337;
				if (num != 0)
				{
				}
				if (!this.a)
				{
					return base.CreateAESCipher(context, cipherKeySize, macAlgorithm);
				}
				break;
			}
			}
			return new global::Motorola.Common.Communication.TLS.OpenSslCompatibility.TlsBlockCipher(context, this.CreateAesBlockCipher(), this.CreateAesBlockCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), cipherKeySize)
			{
				SuppressAddingExtraPadBlocks = true
			};
		}

		// Token: 0x04000023 RID: 35
		private readonly bool a;
	}
}
