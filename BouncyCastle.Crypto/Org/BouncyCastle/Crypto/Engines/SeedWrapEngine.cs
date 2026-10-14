using System;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B5 RID: 1205
	public class SeedWrapEngine : global::Org.BouncyCastle.Crypto.Engines.Rfc3394WrapEngine
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x000D33A0 File Offset: 0x000D15A0
		public SeedWrapEngine() : base(new global::Org.BouncyCastle.Crypto.Engines.SeedEngine())
		{
		}
	}
}
