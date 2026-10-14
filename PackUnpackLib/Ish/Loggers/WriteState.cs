using System;

namespace Motorola.Acp.PackUnpack.Ish.Loggers
{
	// Token: 0x0200004B RID: 75
	public enum WriteState
	{
		// Token: 0x040000EC RID: 236
		Start,
		// Token: 0x040000ED RID: 237
		Partition,
		// Token: 0x040000EE RID: 238
		Item,
		// Token: 0x040000EF RID: 239
		ItemData,
		// Token: 0x040000F0 RID: 240
		Structure,
		// Token: 0x040000F1 RID: 241
		Header,
		// Token: 0x040000F2 RID: 242
		Area,
		// Token: 0x040000F3 RID: 243
		ListEntry,
		// Token: 0x040000F4 RID: 244
		Field,
		// Token: 0x040000F5 RID: 245
		CompositeField,
		// Token: 0x040000F6 RID: 246
		Closed,
		// Token: 0x040000F7 RID: 247
		Error
	}
}
