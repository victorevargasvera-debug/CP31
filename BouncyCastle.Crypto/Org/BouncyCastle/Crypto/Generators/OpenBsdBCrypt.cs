using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047B RID: 1147
	public class OpenBsdBCrypt
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x000BDE18 File Offset: 0x000BC018
		static OpenBsdBCrypt()
		{
			global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Add("2a");
			global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Add("2y");
			global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Add("2b");
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[i] = byte.MaxValue;
			}
			for (int j = 0; j < global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable.Length; j++)
			{
				global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[(int)global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable[j]] = (byte)j;
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000BDED4 File Offset: 0x000BC0D4
		private static string CreateBcryptString(string version, byte[] password, byte[] salt, int cost)
		{
			if (!global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Contains(version))
			{
				throw new global::System.ArgumentException("Version " + version + " is not accepted by this implementation.", "version");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(60);
			stringBuilder.Append('$');
			stringBuilder.Append(version);
			stringBuilder.Append('$');
			stringBuilder.Append((cost < 10) ? ("0" + cost.ToString()) : cost.ToString());
			stringBuilder.Append('$');
			stringBuilder.Append(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodeData(salt));
			byte[] key = global::Org.BouncyCastle.Crypto.Generators.BCrypt.Generate(password, salt, cost);
			stringBuilder.Append(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodeData(key));
			return stringBuilder.ToString();
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000BDF81 File Offset: 0x000BC181
		public static string Generate(char[] password, byte[] salt, int cost)
		{
			return global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.Generate(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DefaultVersion, password, salt, cost);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000BDF90 File Offset: 0x000BC190
		public static string Generate(string version, char[] password, byte[] salt, int cost)
		{
			if (!global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Contains(version))
			{
				throw new global::System.ArgumentException("Version " + version + " is not accepted by this implementation.", "version");
			}
			if (password == null)
			{
				throw new global::System.ArgumentNullException("password");
			}
			if (salt == null)
			{
				throw new global::System.ArgumentNullException("salt");
			}
			if (salt.Length != 16)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("16 byte salt required: " + salt.Length.ToString());
			}
			if (cost < 4 || cost > 31)
			{
				throw new global::System.ArgumentException("Invalid cost factor.", "cost");
			}
			byte[] psw = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(password);
			byte[] tmp = new byte[(psw.Length >= 72) ? 72 : (psw.Length + 1)];
			int copyLen = global::System.Math.Min(psw.Length, tmp.Length);
			global::System.Array.Copy(psw, 0, tmp, 0, copyLen);
			global::System.Array.Clear(psw, 0, psw.Length);
			string result = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.CreateBcryptString(version, tmp, salt, cost);
			global::System.Array.Clear(tmp, 0, tmp.Length);
			return result;
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000BE06C File Offset: 0x000BC26C
		public static bool CheckPassword(string bcryptString, char[] password)
		{
			if (bcryptString.Length != 60)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Bcrypt String length: " + bcryptString.Length.ToString() + ", 60 required.");
			}
			if (bcryptString[0] != '$' || bcryptString[3] != '$' || bcryptString[6] != '$')
			{
				throw new global::System.ArgumentException("Invalid Bcrypt String format.", "bcryptString");
			}
			string version = bcryptString.Substring(1, 2);
			if (!global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.AllowedVersions.Contains(version))
			{
				throw new global::System.ArgumentException("Bcrypt version '" + version + "' is not supported by this implementation", "bcryptString");
			}
			int cost = 0;
			try
			{
				cost = int.Parse(bcryptString.Substring(4, 2));
			}
			catch (global::System.Exception nfe)
			{
				throw new global::System.ArgumentException("Invalid cost factor: " + bcryptString.Substring(4, 2), "bcryptString", nfe);
			}
			if (cost < 4 || cost > 31)
			{
				throw new global::System.ArgumentException("Invalid cost factor: " + cost.ToString() + ", 4 < cost < 31 expected.");
			}
			if (password == null)
			{
				throw new global::System.ArgumentNullException("Missing password.");
			}
			int start = bcryptString.LastIndexOf('$') + 1;
			int end = bcryptString.Length - 31;
			byte[] salt = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodeSaltString(bcryptString.Substring(start, end - start));
			string newBcryptString = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.Generate(version, password, salt, cost);
			return bcryptString.Equals(newBcryptString);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000BE1BC File Offset: 0x000BC3BC
		private static string EncodeData(byte[] data)
		{
			if (data.Length != 24 && data.Length != 16)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Invalid length: " + data.Length.ToString() + ", 24 for key or 16 for salt expected");
			}
			bool salt = false;
			if (data.Length == 16)
			{
				salt = true;
				byte[] tmp = new byte[18];
				global::System.Array.Copy(data, 0, tmp, 0, data.Length);
				data = tmp;
			}
			else
			{
				data[data.Length - 1] = 0;
			}
			global::System.IO.MemoryStream mOut = new global::System.IO.MemoryStream();
			int len = data.Length;
			for (int i = 0; i < len; i += 3)
			{
				uint a = (uint)data[i];
				uint a2 = (uint)data[i + 1];
				uint a3 = (uint)data[i + 2];
				mOut.WriteByte(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable[(int)(a >> 2 & 63U)]);
				mOut.WriteByte(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable[(int)((a << 4 | a2 >> 4) & 63U)]);
				mOut.WriteByte(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable[(int)((a2 << 2 | a3 >> 6) & 63U)]);
				mOut.WriteByte(global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.EncodingTable[(int)(a3 & 63U)]);
			}
			string result = global::Org.BouncyCastle.Utilities.Strings.FromByteArray(mOut.ToArray());
			int resultLen = salt ? 22 : (result.Length - 1);
			return result.Substring(0, resultLen);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000BE2D4 File Offset: 0x000BC4D4
		private static byte[] DecodeSaltString(string saltString)
		{
			char[] saltChars = saltString.ToCharArray();
			global::System.IO.MemoryStream mOut = new global::System.IO.MemoryStream(16);
			if (saltChars.Length != 22)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Invalid base64 salt length: " + saltChars.Length.ToString() + " , 22 required.");
			}
			foreach (int value in saltChars)
			{
				if (value > 122 || value < 46 || (value > 57 && value < 65))
				{
					throw new global::System.ArgumentException("Salt string contains invalid character: " + value.ToString(), "saltString");
				}
			}
			char[] tmp = new char[24];
			global::System.Array.Copy(saltChars, 0, tmp, 0, saltChars.Length);
			saltChars = tmp;
			int len = saltChars.Length;
			for (int j = 0; j < len; j += 4)
			{
				byte b = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[(int)saltChars[j]];
				byte b2 = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[(int)saltChars[j + 1]];
				byte b3 = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[(int)saltChars[j + 2]];
				byte b4 = global::Org.BouncyCastle.Crypto.Generators.OpenBsdBCrypt.DecodingTable[(int)saltChars[j + 3]];
				mOut.WriteByte((byte)((int)b << 2 | b2 >> 4));
				mOut.WriteByte((byte)((int)b2 << 4 | b3 >> 2));
				mOut.WriteByte((byte)((int)b3 << 6 | (int)b4));
			}
			global::System.Array sourceArray = mOut.ToArray();
			byte[] tmpSalt = new byte[16];
			global::System.Array.Copy(sourceArray, 0, tmpSalt, 0, tmpSalt.Length);
			return tmpSalt;
		}

		// Token: 0x04001260 RID: 4704
		private static readonly byte[] EncodingTable = new byte[]
		{
			46,
			47,
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90,
			97,
			98,
			99,
			100,
			101,
			102,
			103,
			104,
			105,
			106,
			107,
			108,
			109,
			110,
			111,
			112,
			113,
			114,
			115,
			116,
			117,
			118,
			119,
			120,
			121,
			122,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57
		};

		// Token: 0x04001261 RID: 4705
		private static readonly byte[] DecodingTable = new byte[128];

		// Token: 0x04001262 RID: 4706
		private static readonly string DefaultVersion = "2y";

		// Token: 0x04001263 RID: 4707
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet AllowedVersions = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
