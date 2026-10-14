using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000062 RID: 98
	public interface INumericMask<T> where T : struct, global::System.IComparable<T>
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000333 RID: 819
		int BitOffset { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000334 RID: 820
		int BitSize { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000335 RID: 821
		int MaxBitOffset { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000336 RID: 822
		int MaxBitSize { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000337 RID: 823
		int Shift { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000338 RID: 824
		T Mask { get; }

		// Token: 0x06000339 RID: 825
		T Apply(T value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication application);
	}
}
