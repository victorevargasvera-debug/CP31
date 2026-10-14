using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000032 RID: 50
	public static class SecurityAlgorithms
	{
		// Token: 0x0400011B RID: 283
		public const string Aes128Encryption = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";

		// Token: 0x0400011C RID: 284
		public const string Aes192Encryption = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";

		// Token: 0x0400011D RID: 285
		public const string Aes256Encryption = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";

		// Token: 0x0400011E RID: 286
		public const string DesEncryption = "http://www.w3.org/2001/04/xmlenc#des-cbc";

		// Token: 0x0400011F RID: 287
		public const string Aes128KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes128";

		// Token: 0x04000120 RID: 288
		public const string Aes192KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes192";

		// Token: 0x04000121 RID: 289
		public const string Aes256KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes256";

		// Token: 0x04000122 RID: 290
		public const string RsaV15KeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";

		// Token: 0x04000123 RID: 291
		public const string Ripemd160Digest = "http://www.w3.org/2001/04/xmlenc#ripemd160";

		// Token: 0x04000124 RID: 292
		public const string RsaOaepKeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-oaep";

		// Token: 0x04000125 RID: 293
		public const string Aes128KW = "A128KW";

		// Token: 0x04000126 RID: 294
		public const string Aes256KW = "A256KW";

		// Token: 0x04000127 RID: 295
		public const string RsaPKCS1 = "RSA1_5";

		// Token: 0x04000128 RID: 296
		public const string RsaOAEP = "RSA-OAEP";

		// Token: 0x04000129 RID: 297
		public const string ExclusiveC14n = "http://www.w3.org/2001/10/xml-exc-c14n#";

		// Token: 0x0400012A RID: 298
		public const string ExclusiveC14nWithComments = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";

		// Token: 0x0400012B RID: 299
		public const string EnvelopedSignature = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";

		// Token: 0x0400012C RID: 300
		public const string Sha256Digest = "http://www.w3.org/2001/04/xmlenc#sha256";

		// Token: 0x0400012D RID: 301
		public const string Sha384Digest = "http://www.w3.org/2001/04/xmldsig-more#sha384";

		// Token: 0x0400012E RID: 302
		public const string Sha512Digest = "http://www.w3.org/2001/04/xmlenc#sha512";

		// Token: 0x0400012F RID: 303
		public const string Sha256 = "SHA256";

		// Token: 0x04000130 RID: 304
		public const string Sha384 = "SHA384";

		// Token: 0x04000131 RID: 305
		public const string Sha512 = "SHA512";

		// Token: 0x04000132 RID: 306
		public const string EcdsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256";

		// Token: 0x04000133 RID: 307
		public const string EcdsaSha384Signature = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384";

		// Token: 0x04000134 RID: 308
		public const string EcdsaSha512Signature = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512";

		// Token: 0x04000135 RID: 309
		public const string HmacSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";

		// Token: 0x04000136 RID: 310
		public const string HmacSha384Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384";

		// Token: 0x04000137 RID: 311
		public const string HmacSha512Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512";

		// Token: 0x04000138 RID: 312
		public const string RsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";

		// Token: 0x04000139 RID: 313
		public const string RsaSha384Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384";

		// Token: 0x0400013A RID: 314
		public const string RsaSha512Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512";

		// Token: 0x0400013B RID: 315
		public const string RsaSsaPssSha256Signature = "http://www.w3.org/2007/05/xmldsig-more#sha256-rsa-MGF1";

		// Token: 0x0400013C RID: 316
		public const string RsaSsaPssSha384Signature = "http://www.w3.org/2007/05/xmldsig-more#sha384-rsa-MGF1";

		// Token: 0x0400013D RID: 317
		public const string RsaSsaPssSha512Signature = "http://www.w3.org/2007/05/xmldsig-more#sha512-rsa-MGF1";

		// Token: 0x0400013E RID: 318
		public const string EcdsaSha256 = "ES256";

		// Token: 0x0400013F RID: 319
		public const string EcdsaSha384 = "ES384";

		// Token: 0x04000140 RID: 320
		public const string EcdsaSha512 = "ES512";

		// Token: 0x04000141 RID: 321
		public const string HmacSha256 = "HS256";

		// Token: 0x04000142 RID: 322
		public const string HmacSha384 = "HS384";

		// Token: 0x04000143 RID: 323
		public const string HmacSha512 = "HS512";

		// Token: 0x04000144 RID: 324
		public const string None = "none";

		// Token: 0x04000145 RID: 325
		public const string RsaSha256 = "RS256";

		// Token: 0x04000146 RID: 326
		public const string RsaSha384 = "RS384";

		// Token: 0x04000147 RID: 327
		public const string RsaSha512 = "RS512";

		// Token: 0x04000148 RID: 328
		public const string RsaSsaPssSha256 = "PS256";

		// Token: 0x04000149 RID: 329
		public const string RsaSsaPssSha384 = "PS384";

		// Token: 0x0400014A RID: 330
		public const string RsaSsaPssSha512 = "PS512";

		// Token: 0x0400014B RID: 331
		public const string Aes128CbcHmacSha256 = "A128CBC-HS256";

		// Token: 0x0400014C RID: 332
		public const string Aes192CbcHmacSha384 = "A192CBC-HS384";

		// Token: 0x0400014D RID: 333
		public const string Aes256CbcHmacSha512 = "A256CBC-HS512";
	}
}
