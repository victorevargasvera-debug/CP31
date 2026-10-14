using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000513 RID: 1299
	internal class PKMacFactory : global::Org.BouncyCastle.Crypto.IMacFactory
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x000F26AB File Offset: 0x000F08AB
		public PKMacFactory(byte[] key, global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameters)
		{
			this.key = global::Org.BouncyCastle.Utilities.Arrays.Clone(key);
			this.parameters = parameters;
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x000F26C6 File Offset: 0x000F08C6
		public virtual object AlgorithmDetails
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Cmp.CmpObjectIdentifiers.passwordBasedMac, this.parameters);
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000F26D8 File Offset: 0x000F08D8
		public virtual global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
		{
			global::Org.BouncyCastle.Crypto.IMac mac = global::Org.BouncyCastle.Security.MacUtilities.GetMac(this.parameters.Mac.Algorithm);
			mac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.key));
			return new global::Org.BouncyCastle.Crmf.PKMacStreamCalculator(mac);
		}

		// Token: 0x04001680 RID: 5760
		protected readonly global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameters;

		// Token: 0x04001681 RID: 5761
		private readonly byte[] key;
	}
}
