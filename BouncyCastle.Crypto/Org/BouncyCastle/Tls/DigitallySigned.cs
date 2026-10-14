using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B6 RID: 182
	public sealed class DigitallySigned
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x0001BD29 File Offset: 0x00019F29
		public DigitallySigned(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] signature)
		{
			if (signature == null)
			{
				throw new global::System.ArgumentNullException("signature");
			}
			this.algorithm = algorithm;
			this.signature = signature;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001BD4D File Offset: 0x00019F4D
		public global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001BD55 File Offset: 0x00019F55
		public byte[] Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001BD5D File Offset: 0x00019F5D
		public void Encode(global::System.IO.Stream output)
		{
			if (this.algorithm != null)
			{
				this.algorithm.Encode(output);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.signature, output);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001BD80 File Offset: 0x00019F80
		public static global::Org.BouncyCastle.Tls.DigitallySigned Parse(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = null;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(context))
			{
				algorithm = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Parse(input);
				if (algorithm.Signature == 0)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
			}
			byte[] signature = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			return new global::Org.BouncyCastle.Tls.DigitallySigned(algorithm, signature);
		}

		// Token: 0x040004DA RID: 1242
		private readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm;

		// Token: 0x040004DB RID: 1243
		private readonly byte[] signature;
	}
}
