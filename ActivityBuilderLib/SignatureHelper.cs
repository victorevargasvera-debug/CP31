using System;
using System.IO;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000027 RID: 39
	public static class SignatureHelper
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00011D80 File Offset: 0x0000FF80
		public static byte[] Sign(this byte[] input, string privateKey, string password)
		{
			int a_ = 14;
			short num = (short)426508288;
			short num2 = num;
			num = (short)2097717086;
			short num3 = num;
			num = (short)1857462110;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)32178176;
				if (num != 0)
				{
				}
				num = (short)864288768;
				switch (num)
				{
				}
				break;
			}
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(privateKey);
			byte[] result;
			try
			{
				global::Org.BouncyCastle.OpenSsl.PemReader pemReader = new global::Org.BouncyCastle.OpenSsl.PemReader(stringReader, new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.Password(password));
				global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair asymmetricCipherKeyPair = (global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)pemReader.ReadObject();
				global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters = (global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)asymmetricCipherKeyPair.Private;
				global::System.Security.Cryptography.RSAParameters parameters = new global::System.Security.Cryptography.RSAParameters
				{
					D = rsaPrivateCrtKeyParameters.Exponent.ToByteArrayUnsigned(),
					DP = rsaPrivateCrtKeyParameters.DP.ToByteArrayUnsigned(),
					DQ = rsaPrivateCrtKeyParameters.DQ.ToByteArrayUnsigned(),
					P = rsaPrivateCrtKeyParameters.P.ToByteArrayUnsigned(),
					Q = rsaPrivateCrtKeyParameters.Q.ToByteArrayUnsigned(),
					InverseQ = rsaPrivateCrtKeyParameters.QInv.ToByteArrayUnsigned(),
					Exponent = rsaPrivateCrtKeyParameters.PublicExponent.ToByteArrayUnsigned(),
					Modulus = rsaPrivateCrtKeyParameters.Modulus.ToByteArrayUnsigned()
				};
				global::System.Security.Cryptography.RSA rsa = global::System.Security.Cryptography.RSA.Create();
				try
				{
					global::System.Security.Cryptography.SHA1 sha = global::System.Security.Cryptography.SHA1.Create();
					try
					{
						rsa.ImportParameters(parameters);
						global::System.Security.Cryptography.RSAPKCS1SignatureFormatter rsapkcs1SignatureFormatter = new global::System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsa);
						rsapkcs1SignatureFormatter.SetHashAlgorithm(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("캜힞銢", a_));
						byte[] rgbHash = sha.ComputeHash(input);
						result = rsapkcs1SignatureFormatter.CreateSignature(rgbHash);
					}
					finally
					{
						num = (short)1137639424;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1E8;
								}
								continue;
							case 1:
								((global::System.IDisposable)sha).Dispose();
								num = (short)1102643202;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_220;
							}
							IL_1E8:
							if (sha == null)
							{
								break;
							}
							num = (short)109248513;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_220:;
					}
				}
				finally
				{
					num = (short)1868103680;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_257;
							}
							continue;
						case 1:
							((global::System.IDisposable)rsa).Dispose();
							num = (short)1638400002;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_28F;
						}
						IL_257:
						if (rsa == null)
						{
							break;
						}
						num = (short)1016070145;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_28F:;
				}
			}
			finally
			{
				num = (short)1013972992;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2C4;
						}
						continue;
					case 1:
						((global::System.IDisposable)stringReader).Dispose();
						num = (short)949288962;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2FC;
					}
					IL_2C4:
					if (stringReader == null)
					{
						break;
					}
					num = (short)428933121;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2FC:;
			}
			num = (short)201785345;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00012104 File Offset: 0x00010304
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1346811898 + A_1) + (global::System.IntPtr)37 + (global::System.IntPtr)62 + (global::System.IntPtr)49);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x02000028 RID: 40
		private class Password : global::Org.BouncyCastle.OpenSsl.IPasswordFinder
		{
			// Token: 0x060000DF RID: 223 RVA: 0x00012180 File Offset: 0x00010380
			public Password(string password)
			{
				this._password = password;
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x0001219C File Offset: 0x0001039C
			public char[] GetPassword()
			{
				short num = (short)854523904;
				short num2 = num;
				num = (short)581153653;
				short num3 = num;
				num = (short)1376433013;
				switch (num3 == num)
				{
				}
				num = (short)1144258561;
				if (num != 0)
				{
				}
				num = (short)409206784;
				if (num != 0)
				{
				}
				return this._password.ToCharArray();
			}

			// Token: 0x0400008E RID: 142
			private readonly string _password;
		}
	}
}
