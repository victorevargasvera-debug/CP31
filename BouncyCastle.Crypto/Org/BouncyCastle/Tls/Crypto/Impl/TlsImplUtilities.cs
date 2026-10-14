using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x02000160 RID: 352
	public abstract class TlsImplUtilities
	{
		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003399B File Offset: 0x00031B9B
		public static bool IsSsl(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			return cryptoParams.ServerVersion.IsSsl;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000339A8 File Offset: 0x00031BA8
		public static bool IsTlsV10(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000339BA File Offset: 0x00031BBA
		public static bool IsTlsV10(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV10(cryptoParams.ServerVersion);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000339C7 File Offset: 0x00031BC7
		public static bool IsTlsV11(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000339D9 File Offset: 0x00031BD9
		public static bool IsTlsV11(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV11(cryptoParams.ServerVersion);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000339E6 File Offset: 0x00031BE6
		public static bool IsTlsV12(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000339F8 File Offset: 0x00031BF8
		public static bool IsTlsV12(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV12(cryptoParams.ServerVersion);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00033A05 File Offset: 0x00031C05
		public static bool IsTlsV13(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00033A17 File Offset: 0x00031C17
		public static bool IsTlsV13(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV13(cryptoParams.ServerVersion);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00033A24 File Offset: 0x00031C24
		public static byte[] CalculateKeyBlock(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int length)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = cryptoParams.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret master_secret = securityParameters.MasterSecret;
			byte[] seed = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(securityParameters.ServerRandom, securityParameters.ClientRandom);
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.Prf(securityParameters, master_secret, "key expansion", seed, length).Extract();
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00033A64 File Offset: 0x00031C64
		public static global::Org.BouncyCastle.Tls.Crypto.TlsSecret Prf(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, string asciiLabel, byte[] seed, int length)
		{
			return secret.DeriveUsingPrf(securityParameters.PrfAlgorithm, asciiLabel, seed, length);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00033A76 File Offset: 0x00031C76
		public static global::Org.BouncyCastle.Tls.Crypto.TlsSecret Prf(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, string asciiLabel, byte[] seed, int length)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.Prf(cryptoParams.SecurityParameters, secret, asciiLabel, seed, length);
		}
	}
}
