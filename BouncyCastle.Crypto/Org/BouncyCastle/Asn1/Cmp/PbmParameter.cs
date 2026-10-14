using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077C RID: 1916
	public class PbmParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004434 RID: 17460 RVA: 0x00130438 File Offset: 0x0012E638
		private PbmParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.salt = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			this.owf = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.iterationCount = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
			this.mac = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[3]);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00130493 File Offset: 0x0012E693
		public static global::Org.BouncyCastle.Asn1.Cmp.PbmParameter GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PbmParameter)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PbmParameter)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PbmParameter((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001304D2 File Offset: 0x0012E6D2
		public PbmParameter(byte[] salt, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf, int iterationCount, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mac) : this(new global::Org.BouncyCastle.Asn1.DerOctetString(salt), owf, new global::Org.BouncyCastle.Asn1.DerInteger(iterationCount), mac)
		{
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x001304E9 File Offset: 0x0012E6E9
		public PbmParameter(global::Org.BouncyCastle.Asn1.Asn1OctetString salt, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf, global::Org.BouncyCastle.Asn1.DerInteger iterationCount, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mac)
		{
			this.salt = salt;
			this.owf = owf;
			this.iterationCount = iterationCount;
			this.mac = mac;
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x0013050E File Offset: 0x0012E70E
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString Salt
		{
			get
			{
				return this.salt;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x00130516 File Offset: 0x0012E716
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Owf
		{
			get
			{
				return this.owf;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x0013051E File Offset: 0x0012E71E
		public virtual global::Org.BouncyCastle.Asn1.DerInteger IterationCount
		{
			get
			{
				return this.iterationCount;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x00130526 File Offset: 0x0012E726
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Mac
		{
			get
			{
				return this.mac;
			}
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x0013052E File Offset: 0x0012E72E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.salt,
				this.owf,
				this.iterationCount,
				this.mac
			});
		}

		// Token: 0x040020D8 RID: 8408
		private global::Org.BouncyCastle.Asn1.Asn1OctetString salt;

		// Token: 0x040020D9 RID: 8409
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf;

		// Token: 0x040020DA RID: 8410
		private global::Org.BouncyCastle.Asn1.DerInteger iterationCount;

		// Token: 0x040020DB RID: 8411
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mac;
	}
}
