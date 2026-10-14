using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003C6 RID: 966
	[global::System.Obsolete("Use AeadParameters")]
	public class CcmParameters : global::Org.BouncyCastle.Crypto.Parameters.AeadParameters
	{
		// Token: 0x060026FE RID: 9982 RVA: 0x000A9FA3 File Offset: 0x000A81A3
		public CcmParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int macSize, byte[] nonce, byte[] associatedText) : base(key, macSize, nonce, associatedText)
		{
		}
	}
}
