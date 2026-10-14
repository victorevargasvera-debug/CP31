using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000047 RID: 71
	internal class ECDsaAlgorithm
	{
		// Token: 0x04000193 RID: 403
		public global::System.Security.Cryptography.ECDsa ECDsa;

		// Token: 0x04000194 RID: 404
		public bool ShouldDispose;

		// Token: 0x04000195 RID: 405
		public static readonly global::System.Collections.Generic.Dictionary<string, int> DefaultECDsaKeySizeInBitsMap = new global::System.Collections.Generic.Dictionary<string, int>
		{
			{
				"ES256",
				256
			},
			{
				"ES384",
				384
			},
			{
				"ES512",
				521
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256",
				256
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384",
				384
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512",
				521
			}
		};
	}
}
