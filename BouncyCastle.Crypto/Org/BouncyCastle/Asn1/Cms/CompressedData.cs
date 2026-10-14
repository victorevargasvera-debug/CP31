using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000744 RID: 1860
	public class CompressedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600429F RID: 17055 RVA: 0x0012C0A0 File Offset: 0x0012A2A0
		public CompressedData(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier compressionAlgorithm, global::Org.BouncyCastle.Asn1.Cms.ContentInfo encapContentInfo)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			this.compressionAlgorithm = compressionAlgorithm;
			this.encapContentInfo = encapContentInfo;
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x0012C0C2 File Offset: 0x0012A2C2
		public CompressedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			this.compressionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.encapContentInfo = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(seq[2]);
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x0012C100 File Offset: 0x0012A300
		public static global::Org.BouncyCastle.Asn1.Cms.CompressedData GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject ato, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.CompressedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(ato, explicitly));
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x0012C10E File Offset: 0x0012A30E
		public static global::Org.BouncyCastle.Asn1.Cms.CompressedData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.CompressedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.CompressedData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.CompressedData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid CompressedData: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x0012C14B File Offset: 0x0012A34B
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0012C153 File Offset: 0x0012A353
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier CompressionAlgorithmIdentifier
		{
			get
			{
				return this.compressionAlgorithm;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x0012C15B File Offset: 0x0012A35B
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo EncapContentInfo
		{
			get
			{
				return this.encapContentInfo;
			}
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0012C163 File Offset: 0x0012A363
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.BerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.compressionAlgorithm,
				this.encapContentInfo
			});
		}

		// Token: 0x04002020 RID: 8224
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002021 RID: 8225
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier compressionAlgorithm;

		// Token: 0x04002022 RID: 8226
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfo encapContentInfo;
	}
}
