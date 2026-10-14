using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023A RID: 570
	public interface ECEndomorphism
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600171B RID: 5915
		global::Org.BouncyCastle.Math.EC.ECPointMap PointMap { get; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600171C RID: 5916
		bool HasEfficientPointMap { get; }
	}
}
