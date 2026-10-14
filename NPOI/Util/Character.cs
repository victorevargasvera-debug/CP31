using System;

namespace NPOI.Util
{
	// Token: 0x02000263 RID: 611
	public class Character
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x00030E5C File Offset: 0x0002F05C
		public static int GetNumericValue(char src)
		{
			if (src >= '0' && src <= '9')
			{
				return (int)src;
			}
			if (src >= 'A' && src <= 'Z')
			{
				return (int)(src - '7');
			}
			if (src >= 'a' && src <= 'z')
			{
				return (int)(src - 'W');
			}
			return -1;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00030E89 File Offset: 0x0002F089
		public static bool isWhitespace(char src)
		{
			return char.IsWhiteSpace(src);
		}
	}
}
