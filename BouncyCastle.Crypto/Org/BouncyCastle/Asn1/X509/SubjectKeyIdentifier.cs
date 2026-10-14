using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066B RID: 1643
	public class SubjectKeyIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C99 RID: 15513 RVA: 0x0011530D File Offset: 0x0011350D
		public static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj, explicitly));
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0011531C File Offset: 0x0011351C
		public static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier((global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj));
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00115375 File Offset: 0x00113575
		public static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectKeyIdentifier));
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00115387 File Offset: 0x00113587
		public SubjectKeyIdentifier(byte[] keyID)
		{
			if (keyID == null)
			{
				throw new global::System.ArgumentNullException("keyID");
			}
			this.keyIdentifier = global::Org.BouncyCastle.Utilities.Arrays.Clone(keyID);
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x001153A9 File Offset: 0x001135A9
		public SubjectKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString keyID) : this(keyID.GetOctets())
		{
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x001153B7 File Offset: 0x001135B7
		public SubjectKeyIdentifier(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki)
		{
			this.keyIdentifier = global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetDigest(spki);
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x001153CB File Offset: 0x001135CB
		public byte[] GetKeyIdentifier()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.keyIdentifier);
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001153D8 File Offset: 0x001135D8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerOctetString(this.GetKeyIdentifier());
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x001153E5 File Offset: 0x001135E5
		public static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier CreateSha1KeyIdentifier(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo)
		{
			return new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(keyInfo);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x001153F0 File Offset: 0x001135F0
		public static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier CreateTruncatedSha1KeyIdentifier(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo)
		{
			byte[] dig = global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetDigest(keyInfo);
			byte[] id = new byte[8];
			global::System.Array.Copy(dig, dig.Length - 8, id, 0, id.Length);
			byte[] array = id;
			int num = 0;
			array[num] &= 15;
			byte[] array2 = id;
			int num2 = 0;
			array2[num2] |= 64;
			return new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(id);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00115440 File Offset: 0x00113640
		private static byte[] GetDigest(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha1Digest sha1Digest = new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();
			byte[] resBuf = new byte[((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).GetDigestSize()];
			byte[] bytes = spki.PublicKeyData.GetBytes();
			((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).BlockUpdate(bytes, 0, bytes.Length);
			((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).DoFinal(resBuf, 0);
			return resBuf;
		}

		// Token: 0x04001AC2 RID: 6850
		private readonly byte[] keyIdentifier;
	}
}
