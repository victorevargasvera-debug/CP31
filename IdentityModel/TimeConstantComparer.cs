using System;
using System.Runtime.CompilerServices;

namespace IdentityModel
{
	// Token: 0x02000027 RID: 39
	public static class TimeConstantComparer
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002744 File Offset: 0x00000944
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
		public static bool IsEqual(string s1, string s2)
		{
			if (s1 == null && s2 == null)
			{
				return true;
			}
			if (s1 == null || s2 == null)
			{
				return false;
			}
			if (s1.Length != s2.Length)
			{
				return false;
			}
			char[] array = s1.ToCharArray();
			char[] array2 = s2.ToCharArray();
			int num = 0;
			for (int i = 0; i < s1.Length; i++)
			{
				if (array[i].Equals(array2[i]))
				{
					num += 2;
				}
				else
				{
					num++;
				}
			}
			return num == s1.Length * 2;
		}
	}
}
