using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000745 RID: 1861
	public class CompressedDataParser
	{
		// Token: 0x060042A7 RID: 17063 RVA: 0x0012C18C File Offset: 0x0012A38C
		public CompressedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this._version = (global::Org.BouncyCastle.Asn1.DerInteger)seq.ReadObject();
			this._compressionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq.ReadObject().ToAsn1Object());
			this._encapContentInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)seq.ReadObject());
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0012C1DC File Offset: 0x0012A3DC
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x0012C1E4 File Offset: 0x0012A3E4
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier CompressionAlgorithmIdentifier
		{
			get
			{
				return this._compressionAlgorithm;
			}
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0012C1EC File Offset: 0x0012A3EC
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser GetEncapContentInfo()
		{
			return this._encapContentInfo;
		}

		// Token: 0x04002023 RID: 8227
		private global::Org.BouncyCastle.Asn1.DerInteger _version;

		// Token: 0x04002024 RID: 8228
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _compressionAlgorithm;

		// Token: 0x04002025 RID: 8229
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser _encapContentInfo;
	}
}
