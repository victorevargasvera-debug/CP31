using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BB RID: 1723
	public class PrivateKeyInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EFB RID: 16123 RVA: 0x0011F018 File Offset: 0x0011D218
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0011F026 File Offset: 0x0011D226
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0011F048 File Offset: 0x0011D248
		private static int GetVersionValue(global::Org.BouncyCastle.Asn1.DerInteger version)
		{
			global::Org.BouncyCastle.Math.BigInteger bigValue = version.Value;
			if (bigValue.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Zero) < 0 || bigValue.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) > 0)
			{
				throw new global::System.ArgumentException("invalid version for private key info", "version");
			}
			return bigValue.IntValue;
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0011F08E File Offset: 0x0011D28E
		public PrivateKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable privateKey) : this(privateKeyAlgorithm, privateKey, null, null)
		{
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0011F09A File Offset: 0x0011D29A
		public PrivateKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable privateKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes) : this(privateKeyAlgorithm, privateKey, attributes, null)
		{
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0011F0A8 File Offset: 0x0011D2A8
		public PrivateKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable privateKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes, byte[] publicKey)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger((publicKey != null) ? global::Org.BouncyCastle.Math.BigInteger.One : global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.privateKeyAlgorithm = privateKeyAlgorithm;
			this.privateKey = new global::Org.BouncyCastle.Asn1.DerOctetString(privateKey);
			this.attributes = attributes;
			this.publicKey = ((publicKey == null) ? null : new global::Org.BouncyCastle.Asn1.DerBitString(publicKey));
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0011F104 File Offset: 0x0011D304
		private PrivateKeyInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.RequireNext(e));
			int versionValue = global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetVersionValue(this.version);
			this.privateKeyAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.RequireNext(e));
			this.privateKey = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.RequireNext(e));
			int lastTag = -1;
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				int tag = tagged.TagNo;
				if (tag <= lastTag)
				{
					throw new global::System.ArgumentException("invalid optional field in private key info", "seq");
				}
				lastTag = tag;
				if (tag != 0)
				{
					if (tag != 1)
					{
						throw new global::System.ArgumentException("unknown optional field in private key info", "seq");
					}
					if (versionValue < 1)
					{
						throw new global::System.ArgumentException("'publicKey' requires version v2(1) or later", "seq");
					}
					this.publicKey = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(tagged, false);
				}
				else
				{
					this.attributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagged, false);
				}
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0011F1E5 File Offset: 0x0011D3E5
		public virtual global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x0011F1ED File Offset: 0x0011D3ED
		public virtual global::Org.BouncyCastle.Asn1.Asn1Set Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x0011F1F5 File Offset: 0x0011D3F5
		public virtual bool HasPublicKey
		{
			get
			{
				return this.publicKey != null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x0011F200 File Offset: 0x0011D400
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier PrivateKeyAlgorithm
		{
			get
			{
				return this.privateKeyAlgorithm;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x0011F208 File Offset: 0x0011D408
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString PrivateKeyData
		{
			get
			{
				return this.privateKey;
			}
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0011F210 File Offset: 0x0011D410
		public virtual global::Org.BouncyCastle.Asn1.Asn1Object ParsePrivateKey()
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.privateKey.GetOctets());
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0011F222 File Offset: 0x0011D422
		public virtual global::Org.BouncyCastle.Asn1.Asn1Object ParsePublicKey()
		{
			if (this.publicKey != null)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.publicKey.GetOctets());
			}
			return null;
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x0011F23E File Offset: 0x0011D43E
		public virtual global::Org.BouncyCastle.Asn1.DerBitString PublicKeyData
		{
			get
			{
				return this.publicKey;
			}
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0011F248 File Offset: 0x0011D448
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.privateKeyAlgorithm,
				this.privateKey
			});
			asn1EncodableVector.AddOptionalTagged(false, 0, this.attributes);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.publicKey);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D1A RID: 7450
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D1B RID: 7451
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm;

		// Token: 0x04001D1C RID: 7452
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString privateKey;

		// Token: 0x04001D1D RID: 7453
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set attributes;

		// Token: 0x04001D1E RID: 7454
		private readonly global::Org.BouncyCastle.Asn1.DerBitString publicKey;
	}
}
