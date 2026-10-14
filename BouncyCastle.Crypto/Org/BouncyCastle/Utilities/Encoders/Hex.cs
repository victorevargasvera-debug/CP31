using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000062 RID: 98
	public sealed class Hex
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00015370 File Offset: 0x00013570
		private Hex()
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00015378 File Offset: 0x00013578
		public static string ToHexString(byte[] data)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data, 0, data.Length);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00015384 File Offset: 0x00013584
		public static string ToHexString(byte[] data, int off, int length)
		{
			return global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(global::Org.BouncyCastle.Utilities.Encoders.Hex.Encode(data, off, length));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00015393 File Offset: 0x00013593
		public static byte[] Encode(byte[] data)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.Encode(data, 0, data.Length);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000153A0 File Offset: 0x000135A0
		public static byte[] Encode(byte[] data, int off, int length)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream(length * 2);
			global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data, off, length, bOut);
			return bOut.ToArray();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000153CB File Offset: 0x000135CB
		public static int Encode(byte[] data, global::System.IO.Stream outStream)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data, 0, data.Length, outStream);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000153DD File Offset: 0x000135DD
		public static int Encode(byte[] data, int off, int length, global::System.IO.Stream outStream)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data, off, length, outStream);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000153F0 File Offset: 0x000135F0
		public static byte[] Decode(byte[] data)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream((data.Length + 1) / 2);
			global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Decode(data, 0, data.Length, bOut);
			return bOut.ToArray();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00015424 File Offset: 0x00013624
		public static byte[] Decode(string data)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream((data.Length + 1) / 2);
			global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeString(data, bOut);
			return bOut.ToArray();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00015454 File Offset: 0x00013654
		public static int Decode(string data, global::System.IO.Stream outStream)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeString(data, outStream);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00015462 File Offset: 0x00013662
		public static byte[] DecodeStrict(string str)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeStrict(str, 0, str.Length);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00015476 File Offset: 0x00013676
		public static byte[] DecodeStrict(string str, int off, int len)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeStrict(str, off, len);
		}

		// Token: 0x04000296 RID: 662
		private static readonly global::Org.BouncyCastle.Utilities.Encoders.HexEncoder encoder = new global::Org.BouncyCastle.Utilities.Encoders.HexEncoder();
	}
}
