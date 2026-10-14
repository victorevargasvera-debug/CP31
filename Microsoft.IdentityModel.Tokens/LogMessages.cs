using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200002E RID: 46
	internal static class LogMessages
	{
		// Token: 0x04000086 RID: 134
		public const string IDX10000 = "IDX10000: The parameter '{0}' cannot be a 'null' or an empty object.";

		// Token: 0x04000087 RID: 135
		public const string IDX10101 = "IDX10101: MaximumTokenSizeInBytes must be greater than zero. value: '{0}'";

		// Token: 0x04000088 RID: 136
		public const string IDX10100 = "IDX10100: ClockSkew must be greater than TimeSpan.Zero. value: '{0}'";

		// Token: 0x04000089 RID: 137
		public const string IDX10102 = "IDX10102: NameClaimType cannot be null or whitespace.";

		// Token: 0x0400008A RID: 138
		public const string IDX10103 = "IDX10103: RoleClaimType cannot be null or whitespace.";

		// Token: 0x0400008B RID: 139
		public const string IDX10104 = "IDX10104: TokenLifetimeInMinutes must be greater than zero. value: '{0}'";

		// Token: 0x0400008C RID: 140
		public const string IDX10204 = "IDX10204: Unable to validate issuer. validationParameters.ValidIssuer is null or whitespace AND validationParameters.ValidIssuers is null.";

		// Token: 0x0400008D RID: 141
		public const string IDX10205 = "IDX10205: Issuer validation failed. Issuer: '{0}'. Did not match: validationParameters.ValidIssuer: '{1}' or validationParameters.ValidIssuers: '{2}'.";

		// Token: 0x0400008E RID: 142
		public const string IDX10207 = "IDX10207: Unable to validate audience. The 'audiences' parameter is null.";

		// Token: 0x0400008F RID: 143
		public const string IDX10208 = "IDX10208: Unable to validate audience. validationParameters.ValidAudience is null or whitespace and validationParameters.ValidAudiences is null.";

		// Token: 0x04000090 RID: 144
		public const string IDX10209 = "IDX10209: token has length: '{0}' which is larger than the MaximumTokenSizeInBytes: '{1}'.";

		// Token: 0x04000091 RID: 145
		public const string IDX10211 = "IDX10211: Unable to validate issuer. The 'issuer' parameter is null or whitespace";

		// Token: 0x04000092 RID: 146
		public const string IDX10214 = "IDX10214: Audience validation failed. Audiences: '{0}'. Did not match: validationParameters.ValidAudience: '{1}' or validationParameters.ValidAudiences: '{2}'.";

		// Token: 0x04000093 RID: 147
		public const string IDX10222 = "IDX10222: Lifetime validation failed. The token is not yet valid. ValidFrom: '{0}', Current time: '{1}'.";

		// Token: 0x04000094 RID: 148
		public const string IDX10223 = "IDX10223: Lifetime validation failed. The token is expired. ValidTo: '{0}', Current time: '{1}'.";

		// Token: 0x04000095 RID: 149
		public const string IDX10224 = "IDX10224: Lifetime validation failed. The NotBefore: '{0}' is after Expires: '{1}'.";

		// Token: 0x04000096 RID: 150
		public const string IDX10225 = "IDX10225: Lifetime validation failed. The token is missing an Expiration Time. Tokentype: '{0}'.";

		// Token: 0x04000097 RID: 151
		public const string IDX10227 = "IDX10227: TokenValidationParameters.TokenReplayCache is not null, indicating to check for token replay but the security token has no expiration time: token '{0}'.";

		// Token: 0x04000098 RID: 152
		public const string IDX10228 = "IDX10228: The securityToken has previously been validated, securityToken: '{0}'.";

		// Token: 0x04000099 RID: 153
		public const string IDX10229 = "IDX10229: TokenValidationParameters.TokenReplayCache was unable to add the securityToken: '{0}'.";

		// Token: 0x0400009A RID: 154
		public const string IDX10230 = "IDX10230: Lifetime validation failed. Delegate returned false, securitytoken: '{0}'.";

		// Token: 0x0400009B RID: 155
		public const string IDX10231 = "IDX10231: Audience validation failed. Delegate returned false, securitytoken: '{0}'.";

		// Token: 0x0400009C RID: 156
		public const string IDX10232 = "IDX10232: IssuerSigningKey validation failed. Delegate returned false, securityKey: '{0}'.";

		// Token: 0x0400009D RID: 157
		public const string IDX10233 = "IDX10233: ValidateAudience property on ValidationParameters is set to false. Exiting without validating the audience.";

		// Token: 0x0400009E RID: 158
		public const string IDX10234 = "IDX10234: Audience Validated.Audience: '{0}'";

		// Token: 0x0400009F RID: 159
		public const string IDX10235 = "IDX10235: ValidateIssuer property on ValidationParameters is set to false. Exiting without validating the issuer.";

		// Token: 0x040000A0 RID: 160
		public const string IDX10236 = "IDX10236: Issuer Validated.Issuer: '{0}'";

		// Token: 0x040000A1 RID: 161
		public const string IDX10237 = "IDX10237: ValidateIssuerSigningKey property on ValidationParameters is set to false. Exiting without validating the issuer signing key.";

		// Token: 0x040000A2 RID: 162
		public const string IDX10238 = "IDX10238: ValidateLifetime property on ValidationParameters is set to false. Exiting without validating the lifetime.";

		// Token: 0x040000A3 RID: 163
		public const string IDX10239 = "IDX10239: Lifetime of the token is valid.";

		// Token: 0x040000A4 RID: 164
		public const string IDX10240 = "IDX10240: No token replay is detected.";

		// Token: 0x040000A5 RID: 165
		public const string IDX10241 = "IDX10241: Security token validated. token: '{0}'.";

		// Token: 0x040000A6 RID: 166
		public const string IDX10242 = "IDX10242: Security token: '{0}' has a valid signature.";

		// Token: 0x040000A7 RID: 167
		public const string IDX10243 = "IDX10243: Reading issuer signing keys from validation parameters.";

		// Token: 0x040000A8 RID: 168
		public const string IDX10244 = "IDX10244: Issuer is null or empty. Using runtime default for creating claims '{0}'.";

		// Token: 0x040000A9 RID: 169
		public const string IDX10245 = "IDX10245: Creating claims identity from the validated token: '{0}'.";

		// Token: 0x040000AA RID: 170
		public const string IDX10246 = "IDX10246: ValidateTokenReplay property on ValidationParameters is set to false. Exiting without validating the token replay.";

		// Token: 0x040000AB RID: 171
		public const string IDX10247 = "IDX10247: The current issuer value in ValidateIssuers property on ValidationParameters is null or emptry, skipping it for issuer validation.";

		// Token: 0x040000AC RID: 172
		public const string IDX10248 = "IDX10248: X509SecurityKey validation failed. The associated certificate is not yet valid. ValidFrom: '{0}', Current time: '{1}'.";

		// Token: 0x040000AD RID: 173
		public const string IDX10249 = "IDX10249: X509SecurityKey validation failed. The associated certificate has expired. ValidTo: '{0}', Current time: '{1}'.";

		// Token: 0x040000AE RID: 174
		public const string IDX10500 = "IDX10500: Signature validation failed. No security keys were provided to validate the signature.";

		// Token: 0x040000AF RID: 175
		public const string IDX10501 = "IDX10501: Signature validation failed. Unable to match keys: \nkid: '{0}', \ntoken: '{1}'.";

		// Token: 0x040000B0 RID: 176
		public const string IDX10503 = "IDX10503: Signature validation failed. Keys tried: '{0}'.\nExceptions caught:\n '{1}'.\ntoken: '{2}'.";

		// Token: 0x040000B1 RID: 177
		public const string IDX10504 = "IDX10504: Unable to validate signature, token does not have a signature: '{0}'.";

		// Token: 0x040000B2 RID: 178
		public const string IDX10505 = "IDX10505: Signature validation failed. The user defined 'Delegate' specified on TokenValidationParameters returned null when validating token: '{0}'.";

		// Token: 0x040000B3 RID: 179
		public const string IDX10506 = "IDX10506: Signature validation failed. The user defined 'Delegate' specified on TokenValidationParameters did not return a '{0}', but returned a '{1}' when validating token: '{2}'.";

		// Token: 0x040000B4 RID: 180
		public const string IDX10507 = "IDX10507: Signature validation failed. ValidateSignature returned null when validating token: '{0}'.";

		// Token: 0x040000B5 RID: 181
		public const string IDX10508 = "IDX10508: Signature validation failed. Signature is improperly formatted.";

		// Token: 0x040000B6 RID: 182
		public const string IDX10509 = "IDX10509: Signature validation failed. The user defined 'Delegate' specified in TokenValidationParameters did not return a '{0}', but returned a '{1}' when reading token: '{2}'.";

		// Token: 0x040000B7 RID: 183
		public const string IDX10510 = "IDX10510: Signature validation failed. The user defined 'Delegate' specified in TokenValidationParameters returned null when reading token: '{0}'.";

		// Token: 0x040000B8 RID: 184
		public const string IDX10511 = "IDX10511: Signature validation failed. Keys tried: '{0}'. \nkid: '{1}'. \nExceptions caught:\n '{2}'.\ntoken: '{3}'.";

		// Token: 0x040000B9 RID: 185
		public const string IDX10600 = "IDX10600: Decryption failed. There are no security keys for decryption.";

		// Token: 0x040000BA RID: 186
		public const string IDX10601 = "IDX10601: Decryption failed. Unable to match 'kid': '{0}', \ntoken: '{1}'.";

		// Token: 0x040000BB RID: 187
		public const string IDX10603 = "IDX10603: Decryption failed. Keys tried: '{0}'.\nExceptions caught:\n '{1}'.\ntoken: '{2}'";

		// Token: 0x040000BC RID: 188
		public const string IDX10604 = "IDX10604: Decryption failed. Exception: '{0}'.";

		// Token: 0x040000BD RID: 189
		public const string IDX10605 = "IDX10605: Decryption failed. Only 'dir' is currently supported. JWE alg is: '{0}'.";

		// Token: 0x040000BE RID: 190
		public const string IDX10606 = "IDX10606: Decryption failed. To decrypt a JWE there must be 5 parts. 'tokenParts' is of length: '{0}'.";

		// Token: 0x040000BF RID: 191
		public const string IDX10607 = "IDX10607: Decryption skipping key: '{0}', both validationParameters.CryptoProviderFactory and key.CryptoProviderFactory are null.";

		// Token: 0x040000C0 RID: 192
		public const string IDX10608 = "IDX10608: Decryption skipping key: '{0}', it is not a '{1}'.";

		// Token: 0x040000C1 RID: 193
		public const string IDX10609 = "IDX10609: Decryption failed. No Keys tried: token: '{0}'.";

		// Token: 0x040000C2 RID: 194
		public const string IDX10610 = "IDX10610: Decryption failed. Could not create decryption provider. Key: '{0}', Algorithm: '{1}'.";

		// Token: 0x040000C3 RID: 195
		public const string IDX10611 = "IDX10611: Decryption failed. Encryption is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.";

		// Token: 0x040000C4 RID: 196
		public const string IDX10612 = "IDX10612: Decryption failed. Header.Enc is null or empty, it must be specified.";

		// Token: 0x040000C5 RID: 197
		public const string IDX10614 = "IDX10614: Decryption failed. JwtHeader.Base64UrlDeserialize(tokenParts[0]): '{0}'. Inner exception: '{1}'.";

		// Token: 0x040000C6 RID: 198
		public const string IDX10615 = "IDX10615: Encryption failed. No support for: Algorithm: '{0}', SecurityKey: '{1}'.";

		// Token: 0x040000C7 RID: 199
		public const string IDX10616 = "IDX10616: Encryption failed. EncryptionProvider failed for: Algorithm: '{0}', SecurityKey: '{1}'. See inner exception.";

		// Token: 0x040000C8 RID: 200
		public const string IDX10617 = "IDX10617: Encryption failed. Keywrap is only supported for: '{0}', '{1}' and '{2}'. The content encryption specified is: '{3}'.";

		// Token: 0x040000C9 RID: 201
		public const string IDX10400 = "IDX10400: Unable to decode: '{0}' as Base64url encoded string.";

		// Token: 0x040000CA RID: 202
		public const string IDX10401 = "IDX10401: Invalid requested key size. Valid key sizes are: 256, 384, and 512.";

		// Token: 0x040000CB RID: 203
		public const string IDX10621 = "IDX10621: '{0}' supports: '{1}' of types: '{2}' or '{3}'. SecurityKey received was of type '{4}'.";

		// Token: 0x040000CC RID: 204
		public const string IDX10622 = "IDX10622: The algorithm: '{0}' requires the SecurityKey.KeySize to be greater than '{1}' bits. KeySize reported: '{2}'.";

		// Token: 0x040000CD RID: 205
		public const string IDX10623 = "IDX10623: Cannot sign data because the KeyedHashAlgorithm is null.";

		// Token: 0x040000CE RID: 206
		public const string IDX10624 = "IDX10624: Cannot verify data because the KeyedHashAlgorithm is null.";

		// Token: 0x040000CF RID: 207
		public const string IDX10627 = "IDX10627: Cannot set the MinimumAsymmetricKeySizeInBitsForVerifying to less than '{0}'.";

		// Token: 0x040000D0 RID: 208
		public const string IDX10628 = "IDX10628: Cannot set the MinimumSymmetricKeySizeInBits to less than '{0}'.";

		// Token: 0x040000D1 RID: 209
		public const string IDX10630 = "IDX10630: The '{0}' for signing cannot be smaller than '{1}' bits. KeySize: '{2}'.";

		// Token: 0x040000D2 RID: 210
		public const string IDX10631 = "IDX10631: The '{0}' for verifying cannot be smaller than '{1}' bits. KeySize: '{2}'.";

		// Token: 0x040000D3 RID: 211
		public const string IDX10634 = "IDX10634: Unable to create the SignatureProvider.\nAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.";

		// Token: 0x040000D4 RID: 212
		public const string IDX10635 = "IDX10635: Unable to create signature. '{0}' returned a null '{1}'. SecurityKey: '{2}', Algorithm: '{3}'";

		// Token: 0x040000D5 RID: 213
		public const string IDX10636 = "IDX10636: CryptoProviderFactory.CreateForVerifying returned null for key: '{0}', signatureAlgorithm: '{1}'.";

		// Token: 0x040000D6 RID: 214
		public const string IDX10638 = "IDX10638: Cannot create the SignatureProvider, 'key.HasPrivateKey' is false, cannot create signatures. Key: {0}.";

		// Token: 0x040000D7 RID: 215
		public const string IDX10640 = "IDX10640: Algorithm is not supported: '{0}'.";

		// Token: 0x040000D8 RID: 216
		public const string IDX10641 = "IDX10641: Key is not supported: '{0}'.";

		// Token: 0x040000D9 RID: 217
		public const string IDX10642 = "IDX10642: Creating signature using the input: '{0}'.";

		// Token: 0x040000DA RID: 218
		public const string IDX10643 = "IDX10643: Comparing the signature created over the input with the token signature: '{0}'.";

		// Token: 0x040000DB RID: 219
		public const string IDX10644 = "IDX10644: UnwrapKey failed. Algorithm: '{0}'.";

		// Token: 0x040000DC RID: 220
		public const string IDX10645 = "IDX10645: Elliptical Curve not supported for curveId: '{0}'";

		// Token: 0x040000DD RID: 221
		public const string IDX10646 = "IDX10646: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}', Key: '{1}'), but Create.(algorithm, args) as '{2}' == NULL.";

		// Token: 0x040000DE RID: 222
		public const string IDX10647 = "IDX10647: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}'), but Create.(algorithm, args) as '{1}' == NULL.";

		// Token: 0x040000DF RID: 223
		public const string IDX10648 = "IDX10648: The SecurityKey provided for AuthenticatedEncryption must be a SymmetricSecurityKey. Type is: '{0}'.";

		// Token: 0x040000E0 RID: 224
		public const string IDX10649 = "IDX10649: Failed to create a SymmetricSignatureProvider for the algorithm '{0}'.";

		// Token: 0x040000E1 RID: 225
		public const string IDX10650 = "IDX10650: Failed to verify ciphertext with aad '{0}'; iv '{1}'; and authenticationTag '{2}'.";

		// Token: 0x040000E2 RID: 226
		public const string IDX10651 = "IDX10651: The key length for the algorithm '{0]' cannot be less than '{1}'.";

		// Token: 0x040000E3 RID: 227
		public const string IDX10652 = "IDX10652: The algorithm '{0}' is not supported.";

		// Token: 0x040000E4 RID: 228
		public const string IDX10653 = "IDX10653: The encryption algorithm '{0}' requires a key size of at least '{1}' bits. Key '{2}', is of size: '{3}'.";

		// Token: 0x040000E5 RID: 229
		public const string IDX10654 = "IDX10654: Decryption failed. Cryptographic operation exception: '{0}'.";

		// Token: 0x040000E6 RID: 230
		public const string IDX10655 = "IDX10655: 'length' must be greater than 1: '{0}'";

		// Token: 0x040000E7 RID: 231
		public const string IDX10656 = "IDX10656: 'length' cannot be greater than signature.Length. length: '{0}', signature.Length: '{1}'.";

		// Token: 0x040000E8 RID: 232
		public const string IDX10657 = "IDX10657: The SecurityKey provided for the symmetric key wrap algorithm cannot be converted to byte array. Type is: '{0}'.";

		// Token: 0x040000E9 RID: 233
		public const string IDX10658 = "IDX10658: WrapKey failed, exception from cryptographic operation: '{0}'";

		// Token: 0x040000EA RID: 234
		public const string IDX10659 = "IDX10659: UnwrapKey failed, exception from cryptographic operation: '{0}'";

		// Token: 0x040000EB RID: 235
		public const string IDX10660 = "IDX10660: The Key: '{0}' and algorithm: '{1}' pair are not supported.";

		// Token: 0x040000EC RID: 236
		public const string IDX10661 = "IDX10661: Unable to create the KeyWrapProvider.\nKeyWrapAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.";

		// Token: 0x040000ED RID: 237
		public const string IDX10662 = "IDX10662: The KeyWrap algorithm '{0}' requires a key size of '{1}' bits. Key '{2}', is of size:'{3}'.";

		// Token: 0x040000EE RID: 238
		public const string IDX10663 = "IDX10663: Failed to create symmetric algorithm with SecurityKey: '{0}', KeyWrapAlgorithm: '{1}'.";

		// Token: 0x040000EF RID: 239
		public const string IDX10664 = "IDX10664: The length of input must be a multiple of 64 bits. The input size is: '{0}' bits.";

		// Token: 0x040000F0 RID: 240
		public const string IDX10665 = "IDX10665: Data is not authentic";

		// Token: 0x040000F1 RID: 241
		public const string IDX10666 = "IDX10666: Unable to create KeyedHashAlgorithm for algorithm '{0}'.";

		// Token: 0x040000F2 RID: 242
		public const string IDX10667 = "IDX10667: Unable to obtain required byte array for KeyHashAlgorithm from SecurityKey: '{0}'.";

		// Token: 0x040000F3 RID: 243
		public const string IDX10668 = "IDX10668: Unable to create '{0}', algorithm '{1}'; key: '{2}' is not supported.";

		// Token: 0x040000F4 RID: 244
		public const string IDX10669 = "IDX10669: Failed to create symmetric algorithm.";

		// Token: 0x040000F5 RID: 245
		public const string IDX10670 = "IDX10670: The lengths of the two byte arrays do not match. The first one has: '{0}' bytes, the second one has: '{1}' bytes.";

		// Token: 0x040000F6 RID: 246
		public const string IDX10671 = "IDX10671: The ECDsa Key: '{0}' must be '{1}' bits. KeySize: '{2}'.";

		// Token: 0x040000F7 RID: 247
		public const string IDX10672 = "IDX10672: GetKeyedHashAlgorithm returned null, key: {0}, algorithm {1}.";

		// Token: 0x040000F8 RID: 248
		public const string IDX10673 = "IDX10673: CryptoProviderFactory.GetHashAlgorithm returned null, factory: {0}, algorithm: {1}.";

		// Token: 0x040000F9 RID: 249
		public const string IDX10674 = "IDX10674: JsonWebKeyConverter does not support SecurityKey of type: {0}";

		// Token: 0x040000FA RID: 250
		public const string IDX10675 = "IDX10675: The value of '{0}' must be '{1}' bits, but was {2}.";

		// Token: 0x040000FB RID: 251
		public const string IDX10676 = "IDX10676: ECDsa creation is currently only supported for the Windows operating system.";

		// Token: 0x040000FC RID: 252
		public const string IDX10677 = "IDX10677: GetKeyedHashAlgorithm threw, key: {0}, algorithm {1}.";

		// Token: 0x040000FD RID: 253
		public const string IDX10678 = "IDX10678: Unable to Sign, provider is not available, Algorithm, Key: '{0}', '{1}'.";

		// Token: 0x040000FE RID: 254
		public const string IDX10700 = "IDX10700: Invalid RsaParameters: '{0}'. Both modulus and exponent should be present";

		// Token: 0x040000FF RID: 255
		public const string IDX10701 = "IDX10701: Invalid JsonWebKey rsa keying material: '{0}'. Both modulus and exponent should be present";

		// Token: 0x04000100 RID: 256
		public const string IDX10702 = "IDX10702: One or more private RSA key parts are null in the JsonWebKey: '{0}'";

		// Token: 0x04000101 RID: 257
		public const string IDX10703 = "IDX10703: Cannot create symmetric security key. Key length is zero.";

		// Token: 0x04000102 RID: 258
		public const string IDX10801 = "IDX10801: Unable to create an RSA public key from the Exponent and Modulus found in the JsonWebKey: E: '{0}', N: '{1}'. See inner exception for additional details.";

		// Token: 0x04000103 RID: 259
		public const string IDX10802 = "IDX10802: Unable to create an X509Certificate2 from the X509Data: '{0}'. See inner exception for additional details.";

		// Token: 0x04000104 RID: 260
		public const string IDX10804 = "IDX10804: Unable to retrieve document from: '{0}'.";

		// Token: 0x04000105 RID: 261
		public const string IDX10805 = "IDX10805: Error deserializing json: '{0}' into '{1}'.";

		// Token: 0x04000106 RID: 262
		public const string IDX10806 = "IDX10806: Deserializing json: '{0}' into '{1}'.";
	}
}
