using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052F RID: 1327
	public abstract class CmsPbeKey : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600333B RID: 13115 RVA: 0x000F48D4 File Offset: 0x000F2AD4
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public CmsPbeKey(string password, byte[] salt, int iterationCount) : this(password.ToCharArray(), salt, iterationCount)
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000F48E4 File Offset: 0x000F2AE4
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public CmsPbeKey(string password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm) : this(password.ToCharArray(), keyDerivationAlgorithm)
		{
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000F48F3 File Offset: 0x000F2AF3
		public CmsPbeKey(char[] password, byte[] salt, int iterationCount)
		{
			this.password = (char[])password.Clone();
			this.salt = global::Org.BouncyCastle.Utilities.Arrays.Clone(salt);
			this.iterationCount = iterationCount;
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000F4920 File Offset: 0x000F2B20
		public CmsPbeKey(char[] password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm)
		{
			if (!keyDerivationAlgorithm.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbkdf2))
			{
				string str = "Unsupported key derivation algorithm: ";
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm = keyDerivationAlgorithm.Algorithm;
				throw new global::System.ArgumentException(str + ((algorithm != null) ? algorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params kdfParams = global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params.GetInstance(keyDerivationAlgorithm.Parameters.ToAsn1Object());
			this.password = (char[])password.Clone();
			this.salt = kdfParams.GetSalt();
			this.iterationCount = kdfParams.IterationCount.IntValue;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000F49A8 File Offset: 0x000F2BA8
		~CmsPbeKey()
		{
			global::System.Array.Clear(this.password, 0, this.password.Length);
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x000F49E4 File Offset: 0x000F2BE4
		[global::System.Obsolete("Will be removed")]
		public string Password
		{
			get
			{
				return new string(this.password);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x000F49F1 File Offset: 0x000F2BF1
		public byte[] Salt
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.salt);
			}
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000F49FE File Offset: 0x000F2BFE
		[global::System.Obsolete("Use 'Salt' property instead")]
		public byte[] GetSalt()
		{
			return this.Salt;
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x000F4A06 File Offset: 0x000F2C06
		public int IterationCount
		{
			get
			{
				return this.iterationCount;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000F4A0E File Offset: 0x000F2C0E
		public string Algorithm
		{
			get
			{
				return "PKCS5S2";
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000F4A15 File Offset: 0x000F2C15
		public string Format
		{
			get
			{
				return "RAW";
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000F4A1C File Offset: 0x000F2C1C
		public byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x06003347 RID: 13127
		internal abstract global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GetEncoded(string algorithmOid);

		// Token: 0x040016E3 RID: 5859
		internal readonly char[] password;

		// Token: 0x040016E4 RID: 5860
		internal readonly byte[] salt;

		// Token: 0x040016E5 RID: 5861
		internal readonly int iterationCount;
	}
}
