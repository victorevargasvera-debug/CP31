using System;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x0200003C RID: 60
	public sealed class Times
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0000CB18 File Offset: 0x0000AD18
		public static long NanoTime()
		{
			return global::System.DateTime.UtcNow.Ticks * global::Org.BouncyCastle.Utilities.Times.NanosecondsPerTick;
		}

		// Token: 0x040000FA RID: 250
		private static long NanosecondsPerTick = 100L;
	}
}
