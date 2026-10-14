using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000014 RID: 20
	public interface IAccumulatingCrcGenerator<T> : global::System.IDisposable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B5 RID: 181
		global::Motorola.Acp.PackUnpack.CrcPolynomial Polynomial { get; }

		// Token: 0x060000B6 RID: 182
		void Add(object value);

		// Token: 0x060000B7 RID: 183
		T Compute();
	}
}
