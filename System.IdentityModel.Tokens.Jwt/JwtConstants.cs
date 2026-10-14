using System;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x02000007 RID: 7
	public static class JwtConstants
	{
		// Token: 0x04000009 RID: 9
		public const string HeaderType = "JWT";

		// Token: 0x0400000A RID: 10
		public const string HeaderTypeAlt = "http://openid.net/specs/jwt/1.0";

		// Token: 0x0400000B RID: 11
		public const string TokenType = "JWT";

		// Token: 0x0400000C RID: 12
		public const string TokenTypeAlt = "urn:ietf:params:oauth:token-type:jwt";

		// Token: 0x0400000D RID: 13
		public const string JsonCompactSerializationRegex = "^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*$";

		// Token: 0x0400000E RID: 14
		public const string JweCompactSerializationRegex = "^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+$";

		// Token: 0x0400000F RID: 15
		internal const int JweSegmentCount = 5;

		// Token: 0x04000010 RID: 16
		internal const int JwsSegmentCount = 3;

		// Token: 0x04000011 RID: 17
		internal const int MaxJwtSegmentCount = 5;

		// Token: 0x04000012 RID: 18
		public const string DirectKeyUseAlg = "dir";
	}
}
