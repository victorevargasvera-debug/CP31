using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B4 RID: 1716
	public class MacData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003ECD RID: 16077 RVA: 0x0011E067 File Offset: 0x0011C267
		public static global::Org.BouncyCastle.Asn1.Pkcs.MacData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.MacData)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.MacData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.MacData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0011E0A8 File Offset: 0x0011C2A8
		private MacData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.digInfo = global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(seq[0]);
			this.salt = ((global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[1]).GetOctets();
			if (seq.Count == 3)
			{
				this.iterationCount = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[2]).Value;
				return;
			}
			this.iterationCount = global::Org.BouncyCastle.Math.BigInteger.One;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0011E110 File Offset: 0x0011C310
		public MacData(global::Org.BouncyCastle.Asn1.X509.DigestInfo digInfo, byte[] salt, int iterationCount)
		{
			this.digInfo = digInfo;
			this.salt = (byte[])salt.Clone();
			this.iterationCount = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)iterationCount);
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x0011E13D File Offset: 0x0011C33D
		public global::Org.BouncyCastle.Asn1.X509.DigestInfo Mac
		{
			get
			{
				return this.digInfo;
			}
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0011E145 File Offset: 0x0011C345
		public byte[] GetSalt()
		{
			return (byte[])this.salt.Clone();
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x0011E157 File Offset: 0x0011C357
		public global::Org.BouncyCastle.Math.BigInteger IterationCount
		{
			get
			{
				return this.iterationCount;
			}
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0011E160 File Offset: 0x0011C360
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.digInfo,
				new global::Org.BouncyCastle.Asn1.DerOctetString(this.salt)
			});
			if (!this.iterationCount.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerInteger(this.iterationCount));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001C78 RID: 7288
		internal global::Org.BouncyCastle.Asn1.X509.DigestInfo digInfo;

		// Token: 0x04001C79 RID: 7289
		internal byte[] salt;

		// Token: 0x04001C7A RID: 7290
		internal global::Org.BouncyCastle.Math.BigInteger iterationCount;
	}
}
