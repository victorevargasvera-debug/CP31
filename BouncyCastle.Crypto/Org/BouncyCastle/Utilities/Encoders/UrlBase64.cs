using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000067 RID: 103
	public class UrlBase64
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x000159D4 File Offset: 0x00013BD4
		public static byte[] Encode(byte[] data)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			try
			{
				global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.Encode(data, 0, data.Length, bOut);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.Exception("exception encoding URL safe base64 string: " + e.Message, e);
			}
			return bOut.ToArray();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00015A28 File Offset: 0x00013C28
		public static int Encode(byte[] data, global::System.IO.Stream outStr)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.Encode(data, 0, data.Length, outStr);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00015A3C File Offset: 0x00013C3C
		public static byte[] Decode(byte[] data)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			try
			{
				global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.Decode(data, 0, data.Length, bOut);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.Exception("exception decoding URL safe base64 string: " + e.Message, e);
			}
			return bOut.ToArray();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00015A90 File Offset: 0x00013C90
		public static int Decode(byte[] data, global::System.IO.Stream outStr)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.Decode(data, 0, data.Length, outStr);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00015AA4 File Offset: 0x00013CA4
		public static byte[] Decode(string data)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			try
			{
				global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.DecodeString(data, bOut);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.Exception("exception decoding URL safe base64 string: " + e.Message, e);
			}
			return bOut.ToArray();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00015AF4 File Offset: 0x00013CF4
		public static int Decode(string data, global::System.IO.Stream outStr)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.UrlBase64.encoder.DecodeString(data, outStr);
		}

		// Token: 0x0400029A RID: 666
		private static readonly global::Org.BouncyCastle.Utilities.Encoders.IEncoder encoder = new global::Org.BouncyCastle.Utilities.Encoders.UrlBase64Encoder();
	}
}
