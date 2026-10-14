using System;
using System.Text;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000005 RID: 5
	public static class Base64UrlEncoder
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002905 File Offset: 0x00000B05
		public static string Encode(string arg)
		{
			if (arg == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("arg");
			}
			return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(arg));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002928 File Offset: 0x00000B28
		public static string Encode(byte[] inArray, int offset, int length)
		{
			if (inArray == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("inArray");
			}
			return global::System.Convert.ToBase64String(inArray, offset, length).Split(new char[]
			{
				global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64PadCharacter
			})[0].Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character62, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64UrlCharacter62).Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character63, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder._base64UrlCharacter63);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002980 File Offset: 0x00000B80
		public static string Encode(byte[] inArray)
		{
			if (inArray == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("inArray");
			}
			return global::System.Convert.ToBase64String(inArray, 0, inArray.Length).Split(new char[]
			{
				global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64PadCharacter
			})[0].Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character62, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64UrlCharacter62).Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character63, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder._base64UrlCharacter63);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000029D8 File Offset: 0x00000BD8
		public static byte[] DecodeBytes(string str)
		{
			if (str == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("str"));
			}
			str = str.Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64UrlCharacter62, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character62);
			str = str.Replace(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder._base64UrlCharacter63, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64Character63);
			switch (str.Length % 4)
			{
			case 0:
				goto IL_9A;
			case 2:
				str += global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.doubleBase64PadCharacter;
				goto IL_9A;
			case 3:
				str += global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.base64PadCharacter.ToString();
				goto IL_9A;
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.FormatException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10400: Unable to decode: '{0}' as Base64url encoded string.", new object[]
			{
				str
			})));
			IL_9A:
			return global::System.Convert.FromBase64String(str);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A85 File Offset: 0x00000C85
		public static string Decode(string arg)
		{
			return global::System.Text.Encoding.UTF8.GetString(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(arg));
		}

		// Token: 0x04000011 RID: 17
		private static char base64PadCharacter = '=';

		// Token: 0x04000012 RID: 18
		private static string doubleBase64PadCharacter = "==";

		// Token: 0x04000013 RID: 19
		private static char base64Character62 = '+';

		// Token: 0x04000014 RID: 20
		private static char base64Character63 = '/';

		// Token: 0x04000015 RID: 21
		private static char base64UrlCharacter62 = '-';

		// Token: 0x04000016 RID: 22
		private static char _base64UrlCharacter63 = '_';
	}
}
