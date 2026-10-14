using System;
using System.Threading;

namespace Autofac.Util
{
	// Token: 0x02000023 RID: 35
	internal static class SequenceGenerator
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00004DF4 File Offset: 0x00002FF4
		internal static long GetNextUniqueSequence()
		{
			long num;
			long num2;
			do
			{
				num = global::System.Threading.Interlocked.Read(ref global::Autofac.Util.SequenceGenerator._lastSequence);
				num2 = global::System.DateTime.UtcNow.Ticks;
				if (num2 <= num)
				{
					num2 = num + 1L;
				}
			}
			while (global::System.Threading.Interlocked.CompareExchange(ref global::Autofac.Util.SequenceGenerator._lastSequence, num2, num) != num);
			return num2;
		}

		// Token: 0x04000028 RID: 40
		private static long _lastSequence;
	}
}
