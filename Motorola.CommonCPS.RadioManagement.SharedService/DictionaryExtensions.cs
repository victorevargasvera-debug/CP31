using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement
{
	// Token: 0x02000003 RID: 3
	public static class DictionaryExtensions
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static TValue GetValueOrDefault<TKey, TValue>(this global::System.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key)
		{
			short num = (short)936050689;
			if (num != 0)
			{
			}
			TValue result;
			if (!dictionary.TryGetValue(key, out result))
			{
				num = (short)609753227;
				short num2 = num;
				num = (short)1788287115;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)414187520;
					short num3 = num;
					num = (short)1300365312;
					if (num != 0)
					{
					}
					break;
				}
				}
				return default(TValue);
			}
			return result;
		}
	}
}
