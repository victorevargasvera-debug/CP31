using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B3 RID: 1459
	public class PgpOnePassSignature
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x00101C11 File Offset: 0x000FFE11
		private static global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket Cast(global::Org.BouncyCastle.Bcpg.Packet packet)
		{
			if (!(packet is global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket))
			{
				throw new global::System.IO.IOException("unexpected packet in stream: " + ((packet != null) ? packet.ToString() : null));
			}
			return (global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket)packet;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00101C3E File Offset: 0x000FFE3E
		internal PgpOnePassSignature(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput) : this(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature.Cast(bcpgInput.ReadPacket()))
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00101C51 File Offset: 0x000FFE51
		internal PgpOnePassSignature(global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket sigPack)
		{
			this.sigPack = sigPack;
			this.signatureType = sigPack.SignatureType;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00101C6C File Offset: 0x000FFE6C
		public void InitVerify(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.lastb = 0;
			try
			{
				this.sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSignatureName(this.sigPack.KeyAlgorithm, this.sigPack.HashAlgorithm));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't set up signature object.", e);
			}
			try
			{
				this.sig.Init(false, pubKey.GetKey());
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("invalid key.", e2);
			}
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00101CF4 File Offset: 0x000FFEF4
		public void Update(byte b)
		{
			if (this.signatureType == 1)
			{
				this.doCanonicalUpdateByte(b);
				return;
			}
			this.sig.Update(b);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00101D13 File Offset: 0x000FFF13
		private void doCanonicalUpdateByte(byte b)
		{
			if (b == 13)
			{
				this.doUpdateCRLF();
			}
			else if (b == 10)
			{
				if (this.lastb != 13)
				{
					this.doUpdateCRLF();
				}
			}
			else
			{
				this.sig.Update(b);
			}
			this.lastb = b;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00101D4C File Offset: 0x000FFF4C
		private void doUpdateCRLF()
		{
			this.sig.Update(13);
			this.sig.Update(10);
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00101D68 File Offset: 0x000FFF68
		public void Update(byte[] bytes)
		{
			if (this.signatureType == 1)
			{
				for (int i = 0; i != bytes.Length; i++)
				{
					this.doCanonicalUpdateByte(bytes[i]);
				}
				return;
			}
			this.sig.BlockUpdate(bytes, 0, bytes.Length);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00101DA8 File Offset: 0x000FFFA8
		public void Update(byte[] bytes, int off, int length)
		{
			if (this.signatureType == 1)
			{
				int finish = off + length;
				for (int i = off; i != finish; i++)
				{
					this.doCanonicalUpdateByte(bytes[i]);
				}
				return;
			}
			this.sig.BlockUpdate(bytes, off, length);
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00101DE8 File Offset: 0x000FFFE8
		public bool Verify(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature pgpSig)
		{
			byte[] trailer = pgpSig.GetSignatureTrailer();
			this.sig.BlockUpdate(trailer, 0, trailer.Length);
			return this.sig.VerifySignature(pgpSig.GetSignature());
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x00101E1D File Offset: 0x0010001D
		public long KeyId
		{
			get
			{
				return this.sigPack.KeyId;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x00101E2A File Offset: 0x0010002A
		public int SignatureType
		{
			get
			{
				return this.sigPack.SignatureType;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x00101E37 File Offset: 0x00100037
		public global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.sigPack.HashAlgorithm;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x00101E44 File Offset: 0x00100044
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag KeyAlgorithm
		{
			get
			{
				return this.sigPack.KeyAlgorithm;
			}
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00101E54 File Offset: 0x00100054
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00101E74 File Offset: 0x00100074
		public void Encode(global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStr).WritePacket(this.sigPack);
		}

		// Token: 0x040018D1 RID: 6353
		private readonly global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket sigPack;

		// Token: 0x040018D2 RID: 6354
		private readonly int signatureType;

		// Token: 0x040018D3 RID: 6355
		private global::Org.BouncyCastle.Crypto.ISigner sig;

		// Token: 0x040018D4 RID: 6356
		private byte lastb;
	}
}
