using System;
using System.Threading;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002C RID: 44
	public static class AutoReleasedSemaphore
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00026390 File Offset: 0x00024590
		static AutoReleasedSemaphore()
		{
			short num = (short)1385615010;
			short num2 = num;
			num = (short)1910230690;
			switch (num2 == num)
			{
			default:
			{
				num = (short)17694720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)204734464;
			if (num != 0)
			{
			}
			num = (short)1048510465;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem = new global::System.Threading.Semaphore(4, 4);
		}

		// Token: 0x040000CC RID: 204
		public static global::System.Threading.Semaphore addUpgradeJobSem;
	}
}
