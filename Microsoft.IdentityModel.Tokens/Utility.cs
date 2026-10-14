using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000049 RID: 73
	public static class Utility
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00007BC0 File Offset: 0x00005DC0
		internal static byte[] Transform(global::System.Security.Cryptography.ICryptoTransform transform, byte[] input, int inputOffset, int inputLength)
		{
			if (transform.CanTransformMultipleBlocks)
			{
				return transform.TransformFinalBlock(input, inputOffset, inputLength);
			}
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write))
				{
					cryptoStream.Write(input, inputOffset, inputLength);
					cryptoStream.FlushFinalBlock();
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00007C38 File Offset: 0x00005E38
		public static byte[] CloneByteArray(this byte[] src)
		{
			return (byte[])src.Clone();
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00007C48 File Offset: 0x00005E48
		internal static string SerializeAsSingleCommaDelimitedString(global::System.Collections.Generic.IEnumerable<string> strings)
		{
			if (strings == null)
			{
				return "null";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (string text in strings)
			{
				if (flag)
				{
					stringBuilder.AppendFormat("{0}", text ?? "null");
					flag = false;
				}
				else
				{
					stringBuilder.AppendFormat(", {0}", text ?? "null");
				}
			}
			if (flag)
			{
				return "empty";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007CDC File Offset: 0x00005EDC
		public static bool IsHttps(string address)
		{
			if (string.IsNullOrEmpty(address))
			{
				return false;
			}
			bool result;
			try
			{
				new global::System.Uri(address);
				result = global::Microsoft.IdentityModel.Tokens.Utility.IsHttps(new global::System.Uri(address));
			}
			catch (global::System.UriFormatException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007D20 File Offset: 0x00005F20
		public static bool IsHttps(global::System.Uri uri)
		{
			return !(uri == null) && uri.Scheme.Equals(global::System.Uri.UriSchemeHttps, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007D40 File Offset: 0x00005F40
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining | global::System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
		public static bool AreEqual(byte[] a, byte[] b)
		{
			byte[] array = new byte[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13,
				14,
				15,
				16,
				17,
				18,
				19,
				20,
				21,
				22,
				23,
				24,
				25,
				26,
				27,
				28,
				29,
				30,
				31
			};
			byte[] array2 = new byte[]
			{
				31,
				30,
				29,
				28,
				27,
				26,
				25,
				24,
				23,
				22,
				21,
				20,
				19,
				18,
				17,
				16,
				15,
				14,
				13,
				12,
				11,
				10,
				9,
				8,
				7,
				6,
				5,
				4,
				3,
				2,
				1,
				0
			};
			int num = 0;
			byte[] array3;
			byte[] array4;
			if (a == null || b == null || a.Length != b.Length)
			{
				array3 = array;
				array4 = array2;
			}
			else
			{
				array3 = a;
				array4 = b;
			}
			for (int i = 0; i < array3.Length; i++)
			{
				num |= (int)(array3[i] ^ array4[i]);
			}
			return num == 0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining | global::System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
		internal static bool AreEqual(byte[] a, byte[] b, int length)
		{
			byte[] array = new byte[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13,
				14,
				15,
				16,
				17,
				18,
				19,
				20,
				21,
				22,
				23,
				24,
				25,
				26,
				27,
				28,
				29,
				30,
				31
			};
			byte[] array2 = new byte[]
			{
				31,
				30,
				29,
				28,
				27,
				26,
				25,
				24,
				23,
				22,
				21,
				20,
				19,
				18,
				17,
				16,
				15,
				14,
				13,
				12,
				11,
				10,
				9,
				8,
				7,
				6,
				5,
				4,
				3,
				2,
				1,
				0
			};
			int num = 0;
			byte[] array3;
			byte[] array4;
			int num2;
			if (a == null || b == null || a.Length < length || b.Length < length)
			{
				array3 = array;
				array4 = array2;
				num2 = array3.Length;
			}
			else
			{
				array3 = a;
				array4 = b;
				num2 = length;
			}
			for (int i = 0; i < num2; i++)
			{
				num |= (int)(array3[i] ^ array4[i]);
			}
			return num == 0;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007E34 File Offset: 0x00006034
		internal static byte[] ConvertToBigEndian(long i)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(i);
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007E58 File Offset: 0x00006058
		internal static byte[] Xor(byte[] a, byte[] b, int offset, bool inPlace)
		{
			if (inPlace)
			{
				for (int i = 0; i < a.Length; i++)
				{
					a[i] ^= b[offset + i];
				}
				return a;
			}
			byte[] array = new byte[a.Length];
			for (int j = 0; j < a.Length; j++)
			{
				array[j] = (a[j] ^ b[offset + j]);
			}
			return array;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007EAC File Offset: 0x000060AC
		internal static global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm ResolveECDsaAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool usePrivateKey)
		{
			if (key == null)
			{
				return null;
			}
			global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm ecdsaAlgorithm = new global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm();
			global::Microsoft.IdentityModel.Tokens.ECDsaSecurityKey ecdsaSecurityKey;
			if ((ecdsaSecurityKey = (key as global::Microsoft.IdentityModel.Tokens.ECDsaSecurityKey)) != null)
			{
				if (ecdsaSecurityKey.ECDsa != null && global::Microsoft.IdentityModel.Tokens.Utility.ValidateECDSAKeySize(ecdsaSecurityKey.ECDsa.KeySize, algorithm))
				{
					ecdsaAlgorithm.ECDsa = (ecdsaSecurityKey.ECDsa as global::System.Security.Cryptography.ECDsaCng);
				}
				return ecdsaAlgorithm;
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.Kty == "EC")
			{
				ecdsaAlgorithm.ShouldDispose = true;
				ecdsaAlgorithm.ECDsa = (global::System.Security.Cryptography.ECDsaCng)jsonWebKey.CreateECDsa(algorithm, usePrivateKey);
				return ecdsaAlgorithm;
			}
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007F38 File Offset: 0x00006138
		internal static global::Microsoft.IdentityModel.Tokens.RsaAlgorithm ResolveRsaAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool requirePrivateKey)
		{
			if (key == null)
			{
				return null;
			}
			global::Microsoft.IdentityModel.Tokens.RsaSecurityKey rsaSecurityKey;
			if ((rsaSecurityKey = (key as global::Microsoft.IdentityModel.Tokens.RsaSecurityKey)) != null)
			{
				if (rsaSecurityKey.Rsa == null)
				{
					global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
					rsacryptoServiceProvider.ImportParameters(rsaSecurityKey.Parameters);
					return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy(rsacryptoServiceProvider))
					{
						ShouldDispose = true
					};
				}
				global::System.Security.Cryptography.RSACryptoServiceProvider rsa;
				if ((rsa = (rsaSecurityKey.Rsa as global::System.Security.Cryptography.RSACryptoServiceProvider)) != null)
				{
					return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy(rsa));
				}
				if (global::Microsoft.IdentityModel.Tokens.RsaCngAdapter.IsRsaCngSupported())
				{
					return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RsaCngAdapter(rsaSecurityKey.Rsa));
				}
			}
			global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey;
			if ((x509SecurityKey = (key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey)) != null)
			{
				if (requirePrivateKey)
				{
					return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy(x509SecurityKey.PrivateKey as global::System.Security.Cryptography.RSACryptoServiceProvider));
				}
				return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy(x509SecurityKey.PublicKey as global::System.Security.Cryptography.RSACryptoServiceProvider));
			}
			else
			{
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
				if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.Kty == "RSA")
				{
					global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider2 = new global::System.Security.Cryptography.RSACryptoServiceProvider();
					rsacryptoServiceProvider2.ImportParameters(jsonWebKey.CreateRsaParameters());
					return new global::Microsoft.IdentityModel.Tokens.RsaAlgorithm(new global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy(rsacryptoServiceProvider2))
					{
						ShouldDispose = true
					};
				}
				return null;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000802B File Offset: 0x0000622B
		internal static bool ValidateECDSAKeySize(int keySize, string algorithm)
		{
			return global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm.DefaultECDsaKeySizeInBitsMap.ContainsKey(algorithm) && keySize == global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm.DefaultECDsaKeySizeInBitsMap[algorithm];
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000804C File Offset: 0x0000624C
		internal static void Zero(byte[] byteArray)
		{
			for (int i = 0; i < byteArray.Length; i++)
			{
				byteArray[i] = 0;
			}
		}

		// Token: 0x0400019A RID: 410
		public const string Empty = "empty";

		// Token: 0x0400019B RID: 411
		public const string Null = "null";
	}
}
