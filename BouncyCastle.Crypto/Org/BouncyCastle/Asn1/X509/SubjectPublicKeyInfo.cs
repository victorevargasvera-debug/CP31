using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066C RID: 1644
	public class SubjectPublicKeyInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CA4 RID: 15524 RVA: 0x0011547E File Offset: 0x0011367E
		public static global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x0011548C File Offset: 0x0011368C
		public static global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)
			{
				return (global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x001154AD File Offset: 0x001136AD
		public SubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, global::Org.BouncyCastle.Asn1.Asn1Encodable publicKey)
		{
			this.keyData = new global::Org.BouncyCastle.Asn1.DerBitString(publicKey);
			this.algID = algID;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x001154C8 File Offset: 0x001136C8
		public SubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, byte[] publicKey)
		{
			this.keyData = new global::Org.BouncyCastle.Asn1.DerBitString(publicKey);
			this.algID = algID;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x001154E4 File Offset: 0x001136E4
		private SubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.algID = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.keyData = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[1]);
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00115547 File Offset: 0x00113747
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmID
		{
			get
			{
				return this.algID;
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0011554F File Offset: 0x0011374F
		public global::Org.BouncyCastle.Asn1.Asn1Object ParsePublicKey()
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.keyData.GetOctets());
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00115561 File Offset: 0x00113761
		[global::System.Obsolete("Use 'ParsePublicKey' instead")]
		public global::Org.BouncyCastle.Asn1.Asn1Object GetPublicKey()
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.keyData.GetOctets());
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x00115573 File Offset: 0x00113773
		public global::Org.BouncyCastle.Asn1.DerBitString PublicKeyData
		{
			get
			{
				return this.keyData;
			}
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x0011557B File Offset: 0x0011377B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algID,
				this.keyData
			});
		}

		// Token: 0x04001AC3 RID: 6851
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;

		// Token: 0x04001AC4 RID: 6852
		private readonly global::Org.BouncyCastle.Asn1.DerBitString keyData;
	}
}
