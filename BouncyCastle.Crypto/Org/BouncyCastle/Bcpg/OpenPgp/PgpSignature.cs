using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BF RID: 1471
	public class PgpSignature
	{
		// Token: 0x0600373C RID: 14140 RVA: 0x00106174 File Offset: 0x00104374
		private static global::Org.BouncyCastle.Bcpg.SignaturePacket Cast(global::Org.BouncyCastle.Bcpg.Packet packet)
		{
			if (!(packet is global::Org.BouncyCastle.Bcpg.SignaturePacket))
			{
				throw new global::System.IO.IOException("unexpected packet in stream: " + ((packet != null) ? packet.ToString() : null));
			}
			return (global::Org.BouncyCastle.Bcpg.SignaturePacket)packet;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001061A1 File Offset: 0x001043A1
		internal PgpSignature(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput) : this(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature.Cast(bcpgInput.ReadPacket()))
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x001061B4 File Offset: 0x001043B4
		internal PgpSignature(global::Org.BouncyCastle.Bcpg.SignaturePacket sigPacket) : this(sigPacket, null)
		{
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x001061BE File Offset: 0x001043BE
		internal PgpSignature(global::Org.BouncyCastle.Bcpg.SignaturePacket sigPacket, global::Org.BouncyCastle.Bcpg.TrustPacket trustPacket)
		{
			if (sigPacket == null)
			{
				throw new global::System.ArgumentNullException("sigPacket");
			}
			this.sigPck = sigPacket;
			this.signatureType = this.sigPck.SignatureType;
			this.trustPck = trustPacket;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x001061F3 File Offset: 0x001043F3
		private void GetSig()
		{
			this.sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSignatureName(this.sigPck.KeyAlgorithm, this.sigPck.HashAlgorithm));
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x0010621B File Offset: 0x0010441B
		public int Version
		{
			get
			{
				return this.sigPck.Version;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x00106228 File Offset: 0x00104428
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag KeyAlgorithm
		{
			get
			{
				return this.sigPck.KeyAlgorithm;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x00106235 File Offset: 0x00104435
		public global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.sigPck.HashAlgorithm;
			}
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00106242 File Offset: 0x00104442
		public bool IsCertification()
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature.IsCertification(this.SignatureType);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00106250 File Offset: 0x00104450
		public void InitVerify(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.lastb = 0;
			if (this.sig == null)
			{
				this.GetSig();
			}
			try
			{
				this.sig.Init(false, pubKey.GetKey());
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("invalid key.", e);
			}
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x001062A4 File Offset: 0x001044A4
		public void Update(byte b)
		{
			if (this.signatureType == 1)
			{
				this.doCanonicalUpdateByte(b);
				return;
			}
			this.sig.Update(b);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x001062C3 File Offset: 0x001044C3
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

		// Token: 0x06003748 RID: 14152 RVA: 0x001062FC File Offset: 0x001044FC
		private void doUpdateCRLF()
		{
			this.sig.Update(13);
			this.sig.Update(10);
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00106318 File Offset: 0x00104518
		public void Update(params byte[] bytes)
		{
			this.Update(bytes, 0, bytes.Length);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00106328 File Offset: 0x00104528
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

		// Token: 0x0600374B RID: 14155 RVA: 0x00106368 File Offset: 0x00104568
		public bool Verify()
		{
			byte[] trailer = this.GetSignatureTrailer();
			this.sig.BlockUpdate(trailer, 0, trailer.Length);
			return this.sig.VerifySignature(this.GetSignature());
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0010639D File Offset: 0x0010459D
		private void UpdateWithIdData(int header, byte[] idBytes)
		{
			this.Update(new byte[]
			{
				(byte)header,
				(byte)(idBytes.Length >> 24),
				(byte)(idBytes.Length >> 16),
				(byte)(idBytes.Length >> 8),
				(byte)idBytes.Length
			});
			this.Update(idBytes);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x001063DC File Offset: 0x001045DC
		private void UpdateWithPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key)
		{
			byte[] keyBytes = this.GetEncodedPublicKey(key);
			this.Update(new byte[]
			{
				153,
				(byte)(keyBytes.Length >> 8),
				(byte)keyBytes.Length
			});
			this.Update(keyBytes);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0010641C File Offset: 0x0010461C
		public bool VerifyCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key)
		{
			this.UpdateWithPublicKey(key);
			try
			{
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] array = userAttributes.ToSubpacketArray();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Encode(bOut);
				}
				this.UpdateWithIdData(209, bOut.ToArray());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("cannot encode subpacket array", e);
			}
			this.Update(this.sigPck.GetSignatureTrailer());
			return this.sig.VerifySignature(this.GetSignature());
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x001064A8 File Offset: 0x001046A8
		public bool VerifyCertification(string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key)
		{
			this.UpdateWithPublicKey(key);
			this.UpdateWithIdData(180, global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(id));
			this.Update(this.sigPck.GetSignatureTrailer());
			return this.sig.VerifySignature(this.GetSignature());
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x001064E4 File Offset: 0x001046E4
		public bool VerifyCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey masterKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.UpdateWithPublicKey(masterKey);
			this.UpdateWithPublicKey(pubKey);
			this.Update(this.sigPck.GetSignatureTrailer());
			return this.sig.VerifySignature(this.GetSignature());
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00106518 File Offset: 0x00104718
		public bool VerifyCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			if (this.SignatureType != 32 && this.SignatureType != 40)
			{
				throw new global::System.InvalidOperationException("signature is not a key signature");
			}
			this.UpdateWithPublicKey(pubKey);
			this.Update(this.sigPck.GetSignatureTrailer());
			return this.sig.VerifySignature(this.GetSignature());
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0010656D File Offset: 0x0010476D
		public int SignatureType
		{
			get
			{
				return this.sigPck.SignatureType;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x0010657A File Offset: 0x0010477A
		public long KeyId
		{
			get
			{
				return this.sigPck.KeyId;
			}
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00106587 File Offset: 0x00104787
		[global::System.Obsolete("Use 'CreationTime' property instead")]
		public global::System.DateTime GetCreationTime()
		{
			return this.CreationTime;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x0010658F File Offset: 0x0010478F
		public global::System.DateTime CreationTime
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixMsToDateTime(this.sigPck.CreationTime);
			}
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x001065A1 File Offset: 0x001047A1
		public byte[] GetSignatureTrailer()
		{
			return this.sigPck.GetSignatureTrailer();
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x001065AE File Offset: 0x001047AE
		public bool HasSubpackets
		{
			get
			{
				return this.sigPck.GetHashedSubPackets() != null || this.sigPck.GetUnhashedSubPackets() != null;
			}
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x001065CD File Offset: 0x001047CD
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector GetHashedSubPackets()
		{
			return this.createSubpacketVector(this.sigPck.GetHashedSubPackets());
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x001065E0 File Offset: 0x001047E0
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector GetUnhashedSubPackets()
		{
			return this.createSubpacketVector(this.sigPck.GetUnhashedSubPackets());
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x001065F3 File Offset: 0x001047F3
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector createSubpacketVector(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] pcks)
		{
			if (pcks != null)
			{
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector(pcks);
			}
			return null;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00106600 File Offset: 0x00104800
		public byte[] GetSignature()
		{
			global::Org.BouncyCastle.Bcpg.MPInteger[] sigValues = this.sigPck.GetSignature();
			if (sigValues != null)
			{
				if (sigValues.Length == 1)
				{
					return sigValues[0].Value.ToByteArrayUnsigned();
				}
				try
				{
					return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						new global::Org.BouncyCastle.Asn1.DerInteger(sigValues[0].Value),
						new global::Org.BouncyCastle.Asn1.DerInteger(sigValues[1].Value)
					}).GetEncoded();
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception encoding DSA sig.", e);
				}
			}
			return this.sigPck.GetSignatureBytes();
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00106690 File Offset: 0x00104890
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x001066B0 File Offset: 0x001048B0
		public void Encode(global::System.IO.Stream outStream)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut = global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStream);
			bcpgOut.WritePacket(this.sigPck);
			if (this.trustPck != null)
			{
				bcpgOut.WritePacket(this.trustPck);
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x001066E4 File Offset: 0x001048E4
		private byte[] GetEncodedPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			byte[] encodedContents;
			try
			{
				encodedContents = pubKey.publicPk.GetEncodedContents();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception preparing key.", e);
			}
			return encodedContents;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00106720 File Offset: 0x00104920
		public static bool IsCertification(int signatureType)
		{
			return signatureType - 16 <= 3;
		}

		// Token: 0x040018EF RID: 6383
		public const int BinaryDocument = 0;

		// Token: 0x040018F0 RID: 6384
		public const int CanonicalTextDocument = 1;

		// Token: 0x040018F1 RID: 6385
		public const int StandAlone = 2;

		// Token: 0x040018F2 RID: 6386
		public const int DefaultCertification = 16;

		// Token: 0x040018F3 RID: 6387
		public const int NoCertification = 17;

		// Token: 0x040018F4 RID: 6388
		public const int CasualCertification = 18;

		// Token: 0x040018F5 RID: 6389
		public const int PositiveCertification = 19;

		// Token: 0x040018F6 RID: 6390
		public const int SubkeyBinding = 24;

		// Token: 0x040018F7 RID: 6391
		public const int PrimaryKeyBinding = 25;

		// Token: 0x040018F8 RID: 6392
		public const int DirectKey = 31;

		// Token: 0x040018F9 RID: 6393
		public const int KeyRevocation = 32;

		// Token: 0x040018FA RID: 6394
		public const int SubkeyRevocation = 40;

		// Token: 0x040018FB RID: 6395
		public const int CertificationRevocation = 48;

		// Token: 0x040018FC RID: 6396
		public const int Timestamp = 64;

		// Token: 0x040018FD RID: 6397
		private readonly global::Org.BouncyCastle.Bcpg.SignaturePacket sigPck;

		// Token: 0x040018FE RID: 6398
		private readonly int signatureType;

		// Token: 0x040018FF RID: 6399
		private readonly global::Org.BouncyCastle.Bcpg.TrustPacket trustPck;

		// Token: 0x04001900 RID: 6400
		private global::Org.BouncyCastle.Crypto.ISigner sig;

		// Token: 0x04001901 RID: 6401
		private byte lastb;
	}
}
