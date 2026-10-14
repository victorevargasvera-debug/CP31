using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000646 RID: 1606
	public class AuthorityKeyIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B79 RID: 15225 RVA: 0x00111B36 File Offset: 0x0010FD36
		public static global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00111B44 File Offset: 0x0010FD44
		public static global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00111B7E File Offset: 0x0010FD7E
		public static global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier));
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00111B90 File Offset: 0x0010FD90
		protected internal AuthorityKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj2 in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2);
				switch (obj.TagNo)
				{
				case 0:
					this.keyidentifier = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj, false);
					break;
				case 1:
					this.certissuer = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj, false);
					break;
				case 2:
					this.certserno = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj, false);
					break;
				default:
					throw new global::System.ArgumentException("illegal tag");
				}
			}
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00111C3C File Offset: 0x0010FE3C
		public AuthorityKeyIdentifier(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki) : this(spki, null, null)
		{
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00111C48 File Offset: 0x0010FE48
		public AuthorityKeyIdentifier(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki, global::Org.BouncyCastle.Asn1.X509.GeneralNames name, global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha1Digest sha1Digest = new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();
			byte[] resBuf = new byte[((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).GetDigestSize()];
			byte[] bytes = spki.PublicKeyData.GetBytes();
			((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).BlockUpdate(bytes, 0, bytes.Length);
			((global::Org.BouncyCastle.Crypto.IDigest)sha1Digest).DoFinal(resBuf, 0);
			this.keyidentifier = new global::Org.BouncyCastle.Asn1.DerOctetString(resBuf);
			this.certissuer = name;
			this.certserno = ((serialNumber == null) ? null : new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00111CB0 File Offset: 0x0010FEB0
		public AuthorityKeyIdentifier(global::Org.BouncyCastle.Asn1.X509.GeneralNames name, global::Org.BouncyCastle.Math.BigInteger serialNumber) : this(null, name, serialNumber)
		{
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00111CBB File Offset: 0x0010FEBB
		public AuthorityKeyIdentifier(byte[] keyIdentifier) : this(keyIdentifier, null, null)
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00111CC6 File Offset: 0x0010FEC6
		public AuthorityKeyIdentifier(byte[] keyIdentifier, global::Org.BouncyCastle.Asn1.X509.GeneralNames name, global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			this.keyidentifier = ((keyIdentifier == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(keyIdentifier));
			this.certissuer = name;
			this.certserno = ((serialNumber == null) ? null : new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00111CF9 File Offset: 0x0010FEF9
		public byte[] GetKeyIdentifier()
		{
			if (this.keyidentifier != null)
			{
				return this.keyidentifier.GetOctets();
			}
			return null;
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x00111D10 File Offset: 0x0010FF10
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames AuthorityCertIssuer
		{
			get
			{
				return this.certissuer;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x00111D18 File Offset: 0x0010FF18
		public global::Org.BouncyCastle.Math.BigInteger AuthorityCertSerialNumber
		{
			get
			{
				if (this.certserno != null)
				{
					return this.certserno.Value;
				}
				return null;
			}
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00111D2F File Offset: 0x0010FF2F
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.keyidentifier);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.certissuer);
			asn1EncodableVector.AddOptionalTagged(false, 2, this.certserno);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00111D68 File Offset: 0x0010FF68
		public override string ToString()
		{
			string keyID = (this.keyidentifier != null) ? global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(this.keyidentifier.GetOctets()) : "null";
			return "AuthorityKeyIdentifier: KeyID(" + keyID + ")";
		}

		// Token: 0x04001A38 RID: 6712
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString keyidentifier;

		// Token: 0x04001A39 RID: 6713
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames certissuer;

		// Token: 0x04001A3A RID: 6714
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certserno;
	}
}
