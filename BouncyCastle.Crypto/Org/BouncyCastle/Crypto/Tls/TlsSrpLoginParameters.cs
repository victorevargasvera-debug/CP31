using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038D RID: 909
	public class TlsSrpLoginParameters
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x000A014D File Offset: 0x0009E34D
		public TlsSrpLoginParameters(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, global::Org.BouncyCastle.Math.BigInteger verifier, byte[] salt)
		{
			this.mGroup = group;
			this.mVerifier = verifier;
			this.mSalt = salt;
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x000A016A File Offset: 0x0009E36A
		public virtual global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters Group
		{
			get
			{
				return this.mGroup;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000A0172 File Offset: 0x0009E372
		public virtual byte[] Salt
		{
			get
			{
				return this.mSalt;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x000A017A File Offset: 0x0009E37A
		public virtual global::Org.BouncyCastle.Math.BigInteger Verifier
		{
			get
			{
				return this.mVerifier;
			}
		}

		// Token: 0x04000ED3 RID: 3795
		protected readonly global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mGroup;

		// Token: 0x04000ED4 RID: 3796
		protected readonly global::Org.BouncyCastle.Math.BigInteger mVerifier;

		// Token: 0x04000ED5 RID: 3797
		protected readonly byte[] mSalt;
	}
}
