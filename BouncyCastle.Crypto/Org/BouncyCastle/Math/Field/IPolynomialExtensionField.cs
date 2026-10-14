using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000202 RID: 514
	public interface IPolynomialExtensionField : global::Org.BouncyCastle.Math.Field.IExtensionField, global::Org.BouncyCastle.Math.Field.IFiniteField
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001430 RID: 5168
		global::Org.BouncyCastle.Math.Field.IPolynomial MinimalPolynomial { get; }
	}
}
