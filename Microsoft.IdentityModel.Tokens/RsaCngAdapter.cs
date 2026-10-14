using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200002F RID: 47
	internal class RsaCngAdapter
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0000643C File Offset: 0x0000463C
		internal RsaCngAdapter(global::System.Security.Cryptography.RSA rsa)
		{
			this.RSA = rsa;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000644B File Offset: 0x0000464B
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00006453 File Offset: 0x00004653
		internal global::System.Security.Cryptography.RSA RSA { get; private set; }

		// Token: 0x0600012A RID: 298 RVA: 0x0000645C File Offset: 0x0000465C
		internal static global::System.Type GetSystemCoreType(string namespaceQualifiedTypeName, bool throwOnError = true)
		{
			return typeof(global::System.Security.Cryptography.CngKey).Assembly.GetType(namespaceQualifiedTypeName, throwOnError);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006474 File Offset: 0x00004674
		internal static bool IsRsaCngSupported()
		{
			global::System.Type systemCoreType = global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.GetSystemCoreType("System.Security.Cryptography.RSACng", false);
			if (systemCoreType == null)
			{
				return false;
			}
			if (global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.GetSystemCoreType("System.Security.Cryptography.DSACng", false) == null)
			{
				return false;
			}
			global::System.Security.Cryptography.RSA key = (global::System.Security.Cryptography.RSA)global::System.Activator.CreateInstance(systemCoreType);
			try
			{
				new global::System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter(key).CreateKeyExchange(new byte[1]);
			}
			catch (global::System.Exception)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000064E8 File Offset: 0x000046E8
		internal byte[] Pkcs1SignData(byte[] input, string hashAlgorithmName)
		{
			if (global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1SignMethod == null)
			{
				global::System.Type[] types = new global::System.Type[]
				{
					typeof(byte[]),
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType,
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType
				};
				global::System.Reflection.MethodInfo method = typeof(global::System.Security.Cryptography.RSA).GetMethod("SignData", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public, null, types, null);
				global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType.GetProperty("Pkcs1", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType.GetProperties(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				global::System.Type type = typeof(global::System.Func<, , , , >).MakeGenericType(new global::System.Type[]
				{
					typeof(global::System.Security.Cryptography.RSA),
					typeof(byte[]),
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType,
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType,
					typeof(byte[])
				});
				global::System.Delegate openDelegate = global::System.Delegate.CreateDelegate(type, method);
				global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1SignMethod = delegate(global::System.Security.Cryptography.RSA rsaArg, byte[] dataArg, string algorithmArg)
				{
					object[] args = new object[]
					{
						rsaArg,
						dataArg,
						global::System.Activator.CreateInstance(global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType, new object[]
						{
							algorithmArg
						}),
						global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType.GetProperty("Pkcs1", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public).GetValue(null)
					};
					return (byte[])openDelegate.DynamicInvoke(args);
				};
			}
			return global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1SignMethod(this.RSA, input, hashAlgorithmName);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000065E8 File Offset: 0x000047E8
		internal bool Pkcs1VerifyData(byte[] input, byte[] signature, string hashAlgorithmName)
		{
			if (global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1VerifyMethod == null)
			{
				global::System.Type[] types = new global::System.Type[]
				{
					typeof(byte[]),
					typeof(byte[]),
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType,
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType
				};
				global::System.Reflection.MethodInfo method = typeof(global::System.Security.Cryptography.RSA).GetMethod("VerifyData", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public, null, types, null);
				global::System.Type type = typeof(global::System.Func<, , , , , >).MakeGenericType(new global::System.Type[]
				{
					typeof(global::System.Security.Cryptography.RSA),
					typeof(byte[]),
					typeof(byte[]),
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType,
					global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType,
					typeof(bool)
				});
				global::System.Delegate verifyDelegate = global::System.Delegate.CreateDelegate(type, method);
				global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1VerifyMethod = delegate(global::System.Security.Cryptography.RSA rsaArg, byte[] dataArg, byte[] signatureArg, string algorithmArg)
				{
					object[] args = new object[]
					{
						rsaArg,
						dataArg,
						signatureArg,
						global::System.Activator.CreateInstance(global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_hashAlgorithmNameType, new object[]
						{
							algorithmArg
						}),
						global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaSignaturePaddingType.GetProperty("Pkcs1", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public).GetValue(null)
					};
					return (bool)verifyDelegate.DynamicInvoke(args);
				};
			}
			return global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.s_rsaPkcs1VerifyMethod(this.RSA, input, signature, hashAlgorithmName);
		}

		// Token: 0x04000107 RID: 263
		private const string HashAlgorithmNameTypeName = "System.Security.Cryptography.HashAlgorithmName";

		// Token: 0x04000108 RID: 264
		private const string RSASignaturePaddingTypeName = "System.Security.Cryptography.RSASignaturePadding";

		// Token: 0x04000109 RID: 265
		private const string RSACngTypeName = "System.Security.Cryptography.RSACng";

		// Token: 0x0400010A RID: 266
		private const string DSACngTypeName = "System.Security.Cryptography.DSACng";

		// Token: 0x0400010B RID: 267
		private static volatile global::System.Func<global::System.Security.Cryptography.RSA, byte[], string, byte[]> s_rsaPkcs1SignMethod;

		// Token: 0x0400010C RID: 268
		private static volatile global::System.Func<global::System.Security.Cryptography.RSA, byte[], byte[], string, bool> s_rsaPkcs1VerifyMethod;

		// Token: 0x0400010D RID: 269
		private static global::System.Type s_hashAlgorithmNameType = typeof(object).Assembly.GetType("System.Security.Cryptography.HashAlgorithmName", false);

		// Token: 0x0400010E RID: 270
		private static global::System.Type s_rsaSignaturePaddingType = typeof(object).Assembly.GetType("System.Security.Cryptography.RSASignaturePadding", false);
	}
}
