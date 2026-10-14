using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000721 RID: 1825
	public class Gost28147Parameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600419A RID: 16794 RVA: 0x00129396 File Offset: 0x00127596
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x001293A4 File Offset: 0x001275A4
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters)
			{
				return (global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.CryptoPro.Gost28147Parameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid GOST3410Parameter: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x001293E4 File Offset: 0x001275E4
		private Gost28147Parameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.iv = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			this.paramSet = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[1]);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00129434 File Offset: 0x00127634
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.iv,
				this.paramSet
			});
		}

		// Token: 0x04001F8F RID: 8079
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString iv;

		// Token: 0x04001F90 RID: 8080
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier paramSet;
	}
}
