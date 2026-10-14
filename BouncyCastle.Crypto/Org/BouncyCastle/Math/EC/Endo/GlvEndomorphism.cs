using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023D RID: 573
	public interface GlvEndomorphism : global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism
	{
		// Token: 0x06001727 RID: 5927
		global::Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(global::Org.BouncyCastle.Math.BigInteger k);
	}
}
