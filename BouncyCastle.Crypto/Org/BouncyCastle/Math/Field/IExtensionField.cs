using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x020001FF RID: 511
	public interface IExtensionField : global::Org.BouncyCastle.Math.Field.IFiniteField
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600142A RID: 5162
		global::Org.BouncyCastle.Math.Field.IFiniteField Subfield { get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600142B RID: 5163
		int Degree { get; }
	}
}
