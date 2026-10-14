using System;
using System.IO;
using System.Security.Cryptography;
using NPOI.Util;

namespace NPOI.HSSF.Record.Crypto
{
	// Token: 0x0200044E RID: 1102
	public class Biff8EncryptionKey
	{
		// Token: 0x060028BC RID: 10428 RVA: 0x0007AED1 File Offset: 0x000790D1
		public static global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey Create(byte[] docId)
		{
			return new global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey(global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.CreateKeyDigest("VelvetSweatshop", docId));
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0007AEE3 File Offset: 0x000790E3
		public static global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey Create(string password, byte[] docIdData)
		{
			return new global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey(global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.CreateKeyDigest(password, docIdData));
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0007AEF1 File Offset: 0x000790F1
		internal Biff8EncryptionKey(byte[] keyDigest)
		{
			if (keyDigest.Length != 5)
			{
				throw new global::System.ArgumentException("Expected 5 byte key digest, but got " + global::NPOI.Util.HexDump.ToHex(keyDigest));
			}
			this._keyDigest = keyDigest;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0007AF1C File Offset: 0x0007911C
		internal static byte[] CreateKeyDigest(string password, byte[] docIdData)
		{
			global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.Check16Bytes(docIdData, "docId");
			int num = global::System.Math.Min(password.Length, 16);
			byte[] array = new byte[num * 2];
			for (int i = 0; i < num; i++)
			{
				char c = password[i];
				array[i * 2] = (byte)(c & 'ÿ');
				array[i * 2 + 1] = (byte)((int)c << 8 & 'ÿ');
			}
			byte[] result;
			using (global::System.Security.Cryptography.MD5 md = new global::System.Security.Cryptography.MD5CryptoServiceProvider())
			{
				byte[] sourceArray = md.ComputeHash(array);
				md.Initialize();
				byte[] array2 = new byte[80 + docIdData.Length * 16];
				int num2 = 0;
				for (int j = 0; j < 16; j++)
				{
					global::System.Array.Copy(sourceArray, 0, array2, num2, 5);
					num2 += 5;
					global::System.Array.Copy(docIdData, 0, array2, num2, docIdData.Length);
					num2 += docIdData.Length;
				}
				global::System.Array sourceArray2 = md.ComputeHash(array2);
				byte[] array3 = new byte[5];
				global::System.Array.Copy(sourceArray2, 0, array3, 0, 5);
				md.Clear();
				result = array3;
			}
			return result;
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0007B028 File Offset: 0x00079228
		public bool Validate(byte[] saltData, byte[] saltHash)
		{
			global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.Check16Bytes(saltData, "saltData");
			global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.Check16Bytes(saltHash, "saltHash");
			global::NPOI.HSSF.Record.Crypto.RC4 rc = this.CreateRC4(0);
			byte[] array = new byte[saltData.Length];
			global::System.Array.Copy(saltData, array, saltData.Length);
			rc.Encrypt(array);
			byte[] array2 = new byte[saltHash.Length];
			global::System.Array.Copy(saltHash, array2, saltHash.Length);
			rc.Encrypt(array2);
			bool result;
			using (global::System.Security.Cryptography.MD5 md = new global::System.Security.Cryptography.MD5CryptoServiceProvider())
			{
				byte[] b = md.ComputeHash(array);
				result = global::NPOI.Util.Arrays.Equals(array2, b);
			}
			return result;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0007B0BC File Offset: 0x000792BC
		private static byte[] xor(byte[] a, byte[] b)
		{
			byte[] array = new byte[a.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (a[i] ^ b[i]);
			}
			return array;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0007B0EC File Offset: 0x000792EC
		private static void Check16Bytes(byte[] data, string argName)
		{
			if (data.Length != 16)
			{
				throw new global::System.ArgumentException("Expected 16 byte " + argName + ", but got " + global::NPOI.Util.HexDump.ToHex(data));
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0007B114 File Offset: 0x00079314
		internal global::NPOI.HSSF.Record.Crypto.RC4 CreateRC4(int keyBlockNo)
		{
			global::NPOI.HSSF.Record.Crypto.RC4 result;
			using (global::System.Security.Cryptography.MD5 md = new global::System.Security.Cryptography.MD5CryptoServiceProvider())
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(4))
				{
					new global::NPOI.Util.LittleEndianOutputStream(memoryStream).WriteInt(keyBlockNo);
					byte[] array = memoryStream.ToArray();
					byte[] array2 = new byte[array.Length + this._keyDigest.Length];
					global::System.Array.Copy(this._keyDigest, 0, array2, 0, this._keyDigest.Length);
					global::System.Array.Copy(array, 0, array2, this._keyDigest.Length, array.Length);
					result = new global::NPOI.HSSF.Record.Crypto.RC4(md.ComputeHash(array2));
				}
			}
			return result;
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x0007B1C0 File Offset: 0x000793C0
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0007B1C7 File Offset: 0x000793C7
		public static string CurrentUserPassword
		{
			get
			{
				return global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey._userPasswordTLS;
			}
			set
			{
				global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey._userPasswordTLS = value;
			}
		}

		// Token: 0x04001180 RID: 4480
		private const int KEY_DIGEST_LENGTH = 5;

		// Token: 0x04001181 RID: 4481
		private const int PASSWORD_HASH_NUMBER_OF_BYTES_USED = 5;

		// Token: 0x04001182 RID: 4482
		private byte[] _keyDigest;

		// Token: 0x04001183 RID: 4483
		[global::System.ThreadStatic]
		private static string _userPasswordTLS;
	}
}
