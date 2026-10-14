using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x0200005E RID: 94
	public sealed class Base64
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x0001491F File Offset: 0x00012B1F
		private Base64()
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00014927 File Offset: 0x00012B27
		public static string ToBase64String(byte[] data)
		{
			return global::System.Convert.ToBase64String(data, 0, data.Length);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00014933 File Offset: 0x00012B33
		public static string ToBase64String(byte[] data, int off, int length)
		{
			return global::System.Convert.ToBase64String(data, off, length);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001493D File Offset: 0x00012B3D
		public static byte[] Encode(byte[] data)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data, 0, data.Length);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00014949 File Offset: 0x00012B49
		public static byte[] Encode(byte[] data, int off, int length)
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(global::System.Convert.ToBase64String(data, off, length));
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00014958 File Offset: 0x00012B58
		public static int Encode(byte[] data, global::System.IO.Stream outStream)
		{
			byte[] encoded = global::Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data);
			outStream.Write(encoded, 0, encoded.Length);
			return encoded.Length;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001497C File Offset: 0x00012B7C
		public static int Encode(byte[] data, int off, int length, global::System.IO.Stream outStream)
		{
			byte[] encoded = global::Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data, off, length);
			outStream.Write(encoded, 0, encoded.Length);
			return encoded.Length;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000149A0 File Offset: 0x00012BA0
		public static byte[] Decode(byte[] data)
		{
			return global::System.Convert.FromBase64String(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(data));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000149AD File Offset: 0x00012BAD
		public static byte[] Decode(string data)
		{
			return global::System.Convert.FromBase64String(data);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000149B8 File Offset: 0x00012BB8
		public static int Decode(string data, global::System.IO.Stream outStream)
		{
			byte[] decoded = global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(data);
			outStream.Write(decoded, 0, decoded.Length);
			return decoded.Length;
		}
	}
}
