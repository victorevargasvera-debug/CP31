using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Utilities
{
	// Token: 0x020002F0 RID: 752
	public class CipherKeyGeneratorFactory
	{
		// Token: 0x06002010 RID: 8208 RVA: 0x00090A14 File Offset: 0x0008EC14
		private CipherKeyGeneratorFactory()
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00090A1C File Offset: 0x0008EC1C
		public static global::Org.BouncyCastle.Crypto.CipherKeyGenerator CreateKeyGenerator(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 192);
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 256);
			}
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Equals(algorithm))
			{
				global::Org.BouncyCastle.Crypto.Generators.DesEdeKeyGenerator desEdeKeyGenerator = new global::Org.BouncyCastle.Crypto.Generators.DesEdeKeyGenerator();
				desEdeKeyGenerator.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(random, 192));
				return desEdeKeyGenerator;
			}
			if (global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			if (global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 192);
			}
			if (global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 256);
			}
			if (global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			if (global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.CAST5_CBC.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			if (global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc.Equals(algorithm))
			{
				global::Org.BouncyCastle.Crypto.Generators.DesKeyGenerator desKeyGenerator = new global::Org.BouncyCastle.Crypto.Generators.DesKeyGenerator();
				desKeyGenerator.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(random, 64));
				return desKeyGenerator;
			}
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.rc4.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc.Equals(algorithm))
			{
				return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateCipherKeyGenerator(random, 128);
			}
			throw new global::System.InvalidOperationException("cannot recognise cipher: " + ((algorithm != null) ? algorithm.ToString() : null));
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00090B84 File Offset: 0x0008ED84
		private static global::Org.BouncyCastle.Crypto.CipherKeyGenerator CreateCipherKeyGenerator(global::Org.BouncyCastle.Security.SecureRandom random, int keySize)
		{
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator cipherKeyGenerator = new global::Org.BouncyCastle.Crypto.CipherKeyGenerator();
			cipherKeyGenerator.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(random, keySize));
			return cipherKeyGenerator;
		}
	}
}
