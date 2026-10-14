using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B5 RID: 1461
	public sealed class PgpPad
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x00101EEB File Offset: 0x001000EB
		private PgpPad()
		{
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00101EF3 File Offset: 0x001000F3
		public static byte[] PadSessionData(byte[] sessionInfo)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPad.PadSessionData(sessionInfo, true);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00101EFC File Offset: 0x001000FC
		public static byte[] PadSessionData(byte[] sessionInfo, bool obfuscate)
		{
			int length = sessionInfo.Length;
			int paddedLength = (length >> 3) + 1 << 3;
			if (obfuscate)
			{
				paddedLength = global::System.Math.Max(40, paddedLength);
			}
			byte padByte = (byte)(paddedLength - length);
			byte[] result = new byte[paddedLength];
			global::System.Array.Copy(sessionInfo, 0, result, 0, length);
			for (int i = length; i < paddedLength; i++)
			{
				result[i] = padByte;
			}
			return result;
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00101F50 File Offset: 0x00100150
		public static byte[] UnpadSessionData(byte[] encoded)
		{
			int paddedLength = encoded.Length;
			byte padByte = encoded[paddedLength - 1];
			int padCount = (int)padByte;
			int length = paddedLength - padCount;
			int last = length - 1;
			int diff = 0;
			for (int i = 0; i < paddedLength; i++)
			{
				int mask = last - i >> 31;
				diff |= ((int)(padByte ^ encoded[i]) & mask);
			}
			diff |= (paddedLength & 7);
			diff |= 40 - paddedLength >> 31;
			if (diff != 0)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("bad padding found in session data");
			}
			byte[] result = new byte[length];
			global::System.Array.Copy(encoded, 0, result, 0, length);
			return result;
		}
	}
}
