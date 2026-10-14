using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200002C RID: 44
	public interface IIshType
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018F RID: 399
		string Name { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000190 RID: 400
		int Value { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000191 RID: 401
		bool IsSingleInstance { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000192 RID: 402
		global::Motorola.Acp.PackUnpack.Ish.Partition Partition { get; }
	}
}
