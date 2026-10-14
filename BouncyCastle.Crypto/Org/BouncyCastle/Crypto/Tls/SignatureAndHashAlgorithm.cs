using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034B RID: 843
	public class SignatureAndHashAlgorithm
	{
		// Token: 0x060022B2 RID: 8882 RVA: 0x0009891C File Offset: 0x00096B1C
		public SignatureAndHashAlgorithm(byte hash, byte signature)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8((int)hash))
			{
				throw new global::System.ArgumentException("should be a uint8", "hash");
			}
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8((int)signature))
			{
				throw new global::System.ArgumentException("should be a uint8", "signature");
			}
			if (signature == 0)
			{
				throw new global::System.ArgumentException("MUST NOT be \"anonymous\"", "signature");
			}
			this.mHash = hash;
			this.mSignature = signature;
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00098980 File Offset: 0x00096B80
		public virtual byte Hash
		{
			get
			{
				return this.mHash;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00098988 File Offset: 0x00096B88
		public virtual byte Signature
		{
			get
			{
				return this.mSignature;
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00098990 File Offset: 0x00096B90
		public override bool Equals(object obj)
		{
			if (!(obj is global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm))
			{
				return false;
			}
			global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm other = (global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)obj;
			return other.Hash == this.Hash && other.Signature == this.Signature;
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000989CC File Offset: 0x00096BCC
		public override int GetHashCode()
		{
			return (int)this.Hash << 16 | (int)this.Signature;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000989DE File Offset: 0x00096BDE
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.Hash, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.Signature, output);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000989F8 File Offset: 0x00096BF8
		public static global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm Parse(global::System.IO.Stream input)
		{
			byte hash = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			byte signature = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			return new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash, signature);
		}

		// Token: 0x04000E11 RID: 3601
		protected readonly byte mHash;

		// Token: 0x04000E12 RID: 3602
		protected readonly byte mSignature;
	}
}
