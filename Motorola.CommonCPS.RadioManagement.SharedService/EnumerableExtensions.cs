using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement
{
	// Token: 0x02000004 RID: 4
	public static class EnumerableExtensions
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021E0 File Offset: 0x000003E0
		public static bool IsEqualInAll<T, TResult>(this global::System.Collections.Generic.IEnumerable<T> items, global::System.Func<T, TResult> selector)
		{
			int a_ = 12;
			if (!items.Any<T>())
			{
				short num = (short)1462752496;
				short num2 = num;
				num = (short)1749275888;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)441319424;
					if (num != 0)
					{
					}
					num = (short)1014693888;
					short num3 = num;
					num = (short)970784769;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤횦\udca8캪쎬첮풰鎲횴\ud8b6ힸ쾺\udcbc횾꿀냂꧆ꛈ꣌ꏎ듐뻒냔맖귘꣚", a_));
			}
			T arg = items.First<T>();
			TResult firstItemValue = selector(arg);
			return items.All(delegate(T x)
			{
				short num4 = (short)1957846328;
				short num5 = num4;
				num4 = (short)2068929848;
				switch (num5 == num4)
				{
				}
				num4 = (short)986251264;
				short num6 = num4;
				num4 = (short)181010433;
				if (num4 != 0)
				{
				}
				num4 = (short)1571487744;
				if (num4 != 0)
				{
				}
				return object.Equals(firstItemValue, selector(x));
			});
		}
	}
}
