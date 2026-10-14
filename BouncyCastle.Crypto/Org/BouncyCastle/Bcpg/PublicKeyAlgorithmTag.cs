using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000584 RID: 1412
	public enum PublicKeyAlgorithmTag
	{
		// Token: 0x04001811 RID: 6161
		RsaGeneral = 1,
		// Token: 0x04001812 RID: 6162
		RsaEncrypt,
		// Token: 0x04001813 RID: 6163
		RsaSign,
		// Token: 0x04001814 RID: 6164
		ElGamalEncrypt = 16,
		// Token: 0x04001815 RID: 6165
		Dsa,
		// Token: 0x04001816 RID: 6166
		[global::System.Obsolete("Use 'ECDH' instead")]
		EC,
		// Token: 0x04001817 RID: 6167
		ECDH = 18,
		// Token: 0x04001818 RID: 6168
		ECDsa,
		// Token: 0x04001819 RID: 6169
		ElGamalGeneral,
		// Token: 0x0400181A RID: 6170
		DiffieHellman,
		// Token: 0x0400181B RID: 6171
		EdDsa,
		// Token: 0x0400181C RID: 6172
		Experimental_1 = 100,
		// Token: 0x0400181D RID: 6173
		Experimental_2,
		// Token: 0x0400181E RID: 6174
		Experimental_3,
		// Token: 0x0400181F RID: 6175
		Experimental_4,
		// Token: 0x04001820 RID: 6176
		Experimental_5,
		// Token: 0x04001821 RID: 6177
		Experimental_6,
		// Token: 0x04001822 RID: 6178
		Experimental_7,
		// Token: 0x04001823 RID: 6179
		Experimental_8,
		// Token: 0x04001824 RID: 6180
		Experimental_9,
		// Token: 0x04001825 RID: 6181
		Experimental_10,
		// Token: 0x04001826 RID: 6182
		Experimental_11
	}
}
