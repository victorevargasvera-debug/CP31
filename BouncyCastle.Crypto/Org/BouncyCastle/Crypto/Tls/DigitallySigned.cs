using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000320 RID: 800
	public class DigitallySigned
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x000942E3 File Offset: 0x000924E3
		public DigitallySigned(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] signature)
		{
			if (signature == null)
			{
				throw new global::System.ArgumentNullException("signature");
			}
			this.mAlgorithm = algorithm;
			this.mSignature = signature;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00094307 File Offset: 0x00092507
		public virtual global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm Algorithm
		{
			get
			{
				return this.mAlgorithm;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x0009430F File Offset: 0x0009250F
		public virtual byte[] Signature
		{
			get
			{
				return this.mSignature;
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00094317 File Offset: 0x00092517
		public virtual void Encode(global::System.IO.Stream output)
		{
			if (this.mAlgorithm != null)
			{
				this.mAlgorithm.Encode(output);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(this.mSignature, output);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0009433C File Offset: 0x0009253C
		public static global::Org.BouncyCastle.Crypto.Tls.DigitallySigned Parse(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm = null;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				algorithm = global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm.Parse(input);
			}
			byte[] signature = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			return new global::Org.BouncyCastle.Crypto.Tls.DigitallySigned(algorithm, signature);
		}

		// Token: 0x04000CE3 RID: 3299
		protected readonly global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mAlgorithm;

		// Token: 0x04000CE4 RID: 3300
		protected readonly byte[] mSignature;
	}
}
