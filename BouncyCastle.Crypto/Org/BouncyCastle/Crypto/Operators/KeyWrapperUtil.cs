using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000422 RID: 1058
	internal class KeyWrapperUtil
	{
		// Token: 0x0600290A RID: 10506 RVA: 0x000AE128 File Offset: 0x000AC328
		static KeyWrapperUtil()
		{
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/ECB/PKCS1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/PKCS1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA1ANDMGF1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA224ANDMGF1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA256ANDMGF1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA384ANDMGF1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA512ANDMGF1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512));
			global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap.Add("RSA/NONE/OAEPWITHSHA256ANDMGF1WITHSHA1PADDING", new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1));
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000AE20C File Offset: 0x000AC40C
		public static global::Org.BouncyCastle.Crypto.IKeyWrapper WrapperForName(string algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Operators.WrapperProvider wrapperProvider = (global::Org.BouncyCastle.Crypto.Operators.WrapperProvider)global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap[global::Org.BouncyCastle.Utilities.Strings.ToUpperCase(algorithm)];
			if (wrapperProvider == null)
			{
				throw new global::System.ArgumentException("could not resolve " + algorithm + " to a KeyWrapper");
			}
			return (global::Org.BouncyCastle.Crypto.IKeyWrapper)wrapperProvider.CreateWrapper(true, parameters);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000AE248 File Offset: 0x000AC448
		public static global::Org.BouncyCastle.Crypto.IKeyUnwrapper UnwrapperForName(string algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Operators.WrapperProvider wrapperProvider = (global::Org.BouncyCastle.Crypto.Operators.WrapperProvider)global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.providerMap[global::Org.BouncyCastle.Utilities.Strings.ToUpperCase(algorithm)];
			if (wrapperProvider == null)
			{
				throw new global::System.ArgumentException("could not resolve " + algorithm + " to a KeyUnwrapper");
			}
			return (global::Org.BouncyCastle.Crypto.IKeyUnwrapper)wrapperProvider.CreateWrapper(false, parameters);
		}

		// Token: 0x040010A1 RID: 4257
		private static readonly global::System.Collections.IDictionary providerMap = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
