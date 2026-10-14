using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000013 RID: 19
	public interface ICrcGenerator<T> : global::System.IDisposable
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B1 RID: 177
		global::Motorola.Acp.PackUnpack.CrcPolynomial Polynomial { get; }

		// Token: 0x060000B2 RID: 178
		T Compute(byte[] buffer, int index, int count);

		// Token: 0x060000B3 RID: 179
		T Compute(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream stream);

		// Token: 0x060000B4 RID: 180
		T Compute(int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream stream);
	}
}
