using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp
{
	// Token: 0x02000698 RID: 1688
	public class MessageImprint : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E19 RID: 15897 RVA: 0x0011B7EA File Offset: 0x001199EA
		public static global::Org.BouncyCastle.Asn1.Tsp.MessageImprint GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Tsp.MessageImprint)
			{
				return (global::Org.BouncyCastle.Asn1.Tsp.MessageImprint)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Tsp.MessageImprint(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x0011B80C File Offset: 0x00119A0C
		private MessageImprint(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.hashedMessage = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets();
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x0011B861 File Offset: 0x00119A61
		public MessageImprint(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, byte[] hashedMessage)
		{
			this.hashAlgorithm = hashAlgorithm;
			this.hashedMessage = hashedMessage;
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x0011B877 File Offset: 0x00119A77
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0011B87F File Offset: 0x00119A7F
		public byte[] GetHashedMessage()
		{
			return this.hashedMessage;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0011B887 File Offset: 0x00119A87
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.hashAlgorithm,
				new global::Org.BouncyCastle.Asn1.DerOctetString(this.hashedMessage)
			});
		}

		// Token: 0x04001BDD RID: 7133
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001BDE RID: 7134
		private readonly byte[] hashedMessage;
	}
}
