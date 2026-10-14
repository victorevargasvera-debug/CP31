using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B5 RID: 1717
	public class PbeParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x0011E1BC File Offset: 0x0011C3BC
		public static global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter || obj == null)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0011E20C File Offset: 0x0011C40C
		private PbeParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.salt = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			this.iterationCount = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0011E25C File Offset: 0x0011C45C
		public PbeParameter(byte[] salt, int iterationCount)
		{
			this.salt = new global::Org.BouncyCastle.Asn1.DerOctetString(salt);
			this.iterationCount = new global::Org.BouncyCastle.Asn1.DerInteger(iterationCount);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0011E27C File Offset: 0x0011C47C
		public byte[] GetSalt()
		{
			return this.salt.GetOctets();
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x0011E289 File Offset: 0x0011C489
		public global::Org.BouncyCastle.Math.BigInteger IterationCount
		{
			get
			{
				return this.iterationCount.Value;
			}
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0011E296 File Offset: 0x0011C496
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.salt,
				this.iterationCount
			});
		}

		// Token: 0x04001C7B RID: 7291
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString salt;

		// Token: 0x04001C7C RID: 7292
		private readonly global::Org.BouncyCastle.Asn1.DerInteger iterationCount;
	}
}
