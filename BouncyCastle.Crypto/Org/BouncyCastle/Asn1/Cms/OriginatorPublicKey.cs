using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000757 RID: 1879
	public class OriginatorPublicKey : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600432E RID: 17198 RVA: 0x0012D67F File Offset: 0x0012B87F
		public OriginatorPublicKey(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, byte[] publicKey)
		{
			this.mAlgorithm = algorithm;
			this.mPublicKey = new global::Org.BouncyCastle.Asn1.DerBitString(publicKey);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x0012D69A File Offset: 0x0012B89A
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public OriginatorPublicKey(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.mAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.mPublicKey = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[1]);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0012D6C6 File Offset: 0x0012B8C6
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0012D6D4 File Offset: 0x0012B8D4
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("Invalid OriginatorPublicKey: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x0012D711 File Offset: 0x0012B911
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm
		{
			get
			{
				return this.mAlgorithm;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x0012D719 File Offset: 0x0012B919
		public global::Org.BouncyCastle.Asn1.DerBitString PublicKey
		{
			get
			{
				return this.mPublicKey;
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x0012D721 File Offset: 0x0012B921
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.mAlgorithm,
				this.mPublicKey
			});
		}

		// Token: 0x04002059 RID: 8281
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mAlgorithm;

		// Token: 0x0400205A RID: 8282
		private readonly global::Org.BouncyCastle.Asn1.DerBitString mPublicKey;
	}
}
