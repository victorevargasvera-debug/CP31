using System;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x02000006 RID: 6
	public static class JwtConstants
	{
		// Token: 0x0400000C RID: 12
		public const string HeaderType = "JWT";

		// Token: 0x0400000D RID: 13
		public const string HeaderTypeAlt = "http://openid.net/specs/jwt/1.0";

		// Token: 0x0400000E RID: 14
		public const string TokenType = "JWT";

		// Token: 0x0400000F RID: 15
		public const string TokenTypeAlt = "urn:ietf:params:oauth:token-type:jwt";

		// Token: 0x04000010 RID: 16
		public const string JsonCompactSerializationRegex = "^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*$";

		// Token: 0x04000011 RID: 17
		public const string JweCompactSerializationRegex = "^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+$";

		// Token: 0x04000012 RID: 18
		public const int JweSegmentCount = 5;

		// Token: 0x04000013 RID: 19
		public const int JwsSegmentCount = 3;

		// Token: 0x04000014 RID: 20
		public const int MaxJwtSegmentCount = 5;

		// Token: 0x04000015 RID: 21
		public const string DirectKeyUseAlg = "dir";
	}
}
