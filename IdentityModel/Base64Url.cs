using System;

namespace IdentityModel
{
	// Token: 0x02000004 RID: 4
	public static class Base64Url
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020E4 File Offset: 0x000002E4
		public static string Encode(byte[] arg)
		{
			return global::System.Convert.ToBase64String(arg).Split(new char[]
			{
				'='
			})[0].Replace('+', '-').Replace('/', '_');
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002110 File Offset: 0x00000310
		public static byte[] Decode(string arg)
		{
			string text = arg.Replace('-', '+');
			text = text.Replace('_', '/');
			switch (text.Length % 4)
			{
			case 0:
				goto IL_60;
			case 2:
				text += "==";
				goto IL_60;
			case 3:
				text += "=";
				goto IL_60;
			}
			throw new global::System.Exception("Illegal base64url string!");
			IL_60:
			return global::System.Convert.FromBase64String(text);
		}
	}
}
