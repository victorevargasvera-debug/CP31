using System;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x0200000A RID: 10
	internal static class LogMessages
	{
		// Token: 0x0400003E RID: 62
		internal const string IDX14000 = "IDX1400: Signing JWT is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.";

		// Token: 0x0400003F RID: 63
		internal const string IDX14100 = "IDX14100: JWT is not well formed: '{0}'.\nThe token needs to be in JWS or JWE Compact Serialization Format. (JWS): 'EncodedHeader.EndcodedPayload.EncodedSignature'. (JWE): 'EncodedProtectedHeader.EncodedEncryptedKey.EncodedInitializationVector.EncodedCiphertext.EncodedAuthenticationTag'.";

		// Token: 0x04000040 RID: 64
		internal const string IDX14101 = "IDX14101: Unable to decode the payload '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.";

		// Token: 0x04000041 RID: 65
		internal const string IDX14102 = "IDX14102: Unable to decode the header '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.";

		// Token: 0x04000042 RID: 66
		internal const string IDX14103 = "IDX14103: Failed to create the token encryption provider.";

		// Token: 0x04000043 RID: 67
		internal const string IDX14104 = "IDX14104: Unable to obtain a CryptoProviderFactory, both EncryptingCredentials.CryptoProviderFactory and EncryptingCredentials.Key.CrypoProviderFactory are both null.";

		// Token: 0x04000044 RID: 68
		internal const string IDX14105 = "IDX14105: Header.Cty != null, assuming JWS. Cty: '{0}'.";

		// Token: 0x04000045 RID: 69
		internal const string IDX14106 = "IDX14106: Decoding token: '{0}' into header, payload and signature.";

		// Token: 0x04000046 RID: 70
		internal const string IDX14107 = "IDX14107: Token string does not match the token formats: JWE (header.encryptedKey.iv.ciphertext.tag) or JWS (header.payload.signature)";

		// Token: 0x04000047 RID: 71
		internal const string IDX14108 = "IDX14108: Error found while parsing date time. The '{0}' claim has value '{1}' which is could not be parsed to an integer.";

		// Token: 0x04000048 RID: 72
		internal const string IDX14109 = "IDX14109: Error found while parsing date time. The '{0}' claim has value '{1}' does not lie in the valid range.";

		// Token: 0x04000049 RID: 73
		internal const string IDX14110 = "IDX14110: JWT is not well formed: '{0}'.\nThe token needs to be in JWS Compact Serialization Format. (JWS): 'EncodedHeader.EndcodedPayload.EncodedSignature'.";

		// Token: 0x0400004A RID: 74
		internal const string IDX14200 = "IDX14200: Creating raw signature using the signature credentials.";

		// Token: 0x0400004B RID: 75
		internal const string IDX14300 = "IDX14300: Could not parse '{0}' : '{1}' as a '{2}'.";
	}
}
