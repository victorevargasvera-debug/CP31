using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003C7 RID: 967
	public class DesEdeParameters : global::Org.BouncyCastle.Crypto.Parameters.DesParameters
	{
		// Token: 0x060026FF RID: 9983 RVA: 0x000A9FB0 File Offset: 0x000A81B0
		private static byte[] FixKey(byte[] key, int keyOff, int keyLen)
		{
			byte[] tmp = new byte[24];
			if (keyLen != 16)
			{
				if (keyLen != 24)
				{
					throw new global::System.ArgumentException("Bad length for DESede key: " + keyLen.ToString(), "keyLen");
				}
				global::System.Array.Copy(key, keyOff, tmp, 0, 24);
			}
			else
			{
				global::System.Array.Copy(key, keyOff, tmp, 0, 16);
				global::System.Array.Copy(key, keyOff, tmp, 16, 8);
			}
			if (global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(tmp))
			{
				throw new global::System.ArgumentException("attempt to create weak DESede key");
			}
			return tmp;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000AA026 File Offset: 0x000A8226
		public DesEdeParameters(byte[] key) : base(global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.FixKey(key, 0, key.Length))
		{
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000AA038 File Offset: 0x000A8238
		public DesEdeParameters(byte[] key, int keyOff, int keyLen) : base(global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.FixKey(key, keyOff, keyLen))
		{
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000AA048 File Offset: 0x000A8248
		public static bool IsWeakKey(byte[] key, int offset, int length)
		{
			for (int i = offset; i < length; i += 8)
			{
				if (global::Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key, i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000AA06D File Offset: 0x000A826D
		public new static bool IsWeakKey(byte[] key, int offset)
		{
			return global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key, offset, key.Length - offset);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000AA07B File Offset: 0x000A827B
		public new static bool IsWeakKey(byte[] key)
		{
			return global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key, 0, key.Length);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000AA087 File Offset: 0x000A8287
		public static bool IsRealEdeKey(byte[] key, int offset)
		{
			if (key.Length != 16)
			{
				return global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsReal3Key(key, offset);
			}
			return global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsReal2Key(key, offset);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000AA0A0 File Offset: 0x000A82A0
		public static bool IsReal2Key(byte[] key, int offset)
		{
			bool isValid = false;
			for (int i = offset; i != offset + 8; i++)
			{
				isValid |= (key[i] != key[i + 8]);
			}
			return isValid;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000AA0D0 File Offset: 0x000A82D0
		public static bool IsReal3Key(byte[] key, int offset)
		{
			bool diff12 = false;
			bool diff13 = false;
			bool diff14 = false;
			for (int i = offset; i != offset + 8; i++)
			{
				diff12 |= (key[i] != key[i + 8]);
				diff13 |= (key[i] != key[i + 16]);
				diff14 |= (key[i + 8] != key[i + 16]);
			}
			return diff12 && diff13 && diff14;
		}

		// Token: 0x04000FD8 RID: 4056
		public const int DesEdeKeyLength = 24;
	}
}
